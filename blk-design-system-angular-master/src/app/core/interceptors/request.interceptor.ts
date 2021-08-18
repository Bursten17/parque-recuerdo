import { HttpErrorResponse, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { TokenService } from '@core/services/token.service';
import { catchError } from 'rxjs/operators';

@Injectable()
export class RequestInterceptor implements HttpInterceptor {
  constructor(
    private token: TokenService,
  ) { }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    req = this.AddToken(req);
    return next.handle(req)
      .pipe(
        catchError(this.handlerError)
      );
  }

  AddToken(req: HttpRequest<any>) {
    const tokenAux = this.token.getToken()
    if (tokenAux) {
      req = req.clone({
        setHeaders: {
          authorization: `Bearer ${tokenAux}`
        }
      });
      return req;
    }
    return req;
  }

  handlerError(error: HttpErrorResponse) {
    return throwError(error)
  }
}
