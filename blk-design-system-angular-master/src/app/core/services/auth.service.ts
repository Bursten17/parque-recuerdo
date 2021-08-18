import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';

import { environment } from '../../../environments/environment';
import { Login } from '@core/models/request/auth/loguin.model';

import { tap } from 'rxjs/operators'

import { NotifierService } from 'angular-notifier';
import { TokenService } from './token.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  notifier: NotifierService;

  constructor(
    private http: HttpClient,
    private token: TokenService
  ) { }

  login(dataObj: Login) {
    return this.http.post(`${environment.url_api}/auth/login`, dataObj)
      .pipe(
        tap((data: any) => {
          debugger
          this.token.setToken(data.token)
        })
      );
  }
}
