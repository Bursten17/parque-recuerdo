import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { NotifierService } from 'angular-notifier';
import { session_expired } from 'src/app/infrastructure/appConstant';
import { TokenService } from './token.service';

@Injectable({
  providedIn: 'root'
})
export class ErrorService {
  notifier: NotifierService;

  constructor(
    private router: Router,
    private tokenServices: TokenService,
    notifierService: NotifierService
  ) {
    this.notifier = notifierService;
  }

  HandlerError(error: any) {
    if (error.status === 0) {
      this.notifier.notify('error', 'Network error - make sure the API server is running');
      return
    }

    console.log('error', error)

    if (error.status === 400) {
      this.notifier.notify('error', error.error.errors);
      return
    }

    if (error.status === 401 && error.headers.get('www-authenticate').includes('Bearer error="invalid_token", error_description="The token expired')) {
      this.tokenServices.removeToken();
      this.notifier.notify('error', session_expired);
      this.router.navigate(['/login'])
      return
    }

    if (error.status === 401) {
      this.notifier.notify('error', 'Acceso Denegado, vuelva a loguearse');
      this.router.navigate(['/login'])
      return
    }

    if (error.status === 404) {
      this.notifier.notify('error', 'Not Found');
      return
    }

    if (error.status === 500) {
      this.notifier.notify('error', 'Server error - check the terminal for more info!');
      return
    }

    this.notifier.notify('error', 'algo salio mal');
  }
}
