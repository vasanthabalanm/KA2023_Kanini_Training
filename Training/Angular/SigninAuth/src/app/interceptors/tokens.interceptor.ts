import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';
import { JwtAuthService } from '../services/jwt-auth.service';
import { NgToastService } from 'ng-angular-popup';
import { Router } from '@angular/router';

@Injectable()
export class TokensInterceptor implements HttpInterceptor {

  constructor(private auth:JwtAuthService,private toast:NgToastService,private roter:Router) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    const myTokens = this.auth.gettoken();

    // this.start.load();
    if(myTokens){
      request = request.clone({
        setHeaders: {Authorization:`Bearer ${myTokens}`}  // "Bearer "+myToken
      })
    }
    return next.handle(request).pipe(
      catchError((err:any)=>{
        if(err instanceof HttpErrorResponse){
          if(err.status === 401){
            this.toast.warning({detail:"Warning", summary:"Token is expired, Please Login again"});
            this.roter.navigate(['login'])
            
            // return this.handleUnAuthorizedError(request,next);
          }
        }
        return throwError(()=> err)
      })
    );
  }
}

