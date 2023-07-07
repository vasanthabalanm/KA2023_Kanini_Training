import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { NgToastService } from 'ng-angular-popup';
import { JwtAuthService } from '../services/jwt-auth.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private auth : JwtAuthService, private router: Router, private toast: NgToastService){

  }
  canActivate():boolean{
    if(this.auth.islogedin()){
      return true
    }else{
      this.toast.error({detail:"ERROR", summary:"Please Login First!"});
      this.router.navigate(['login'])
      return false;
    }
  }

}