import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Route, Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { token } from 'src/Models/token.model';


@Injectable({
  providedIn: 'root'
})
export class JwtAuthService {

  private baseUrl: string = 'https://localhost:7190/api/Owner/';
  private userPayload:any;


  constructor(private http: HttpClient, private router:Router) {
    // this.userPayload = this.decodedToken();
  }
  signUp(userObj: any) {
    return this.http.post<any>(`${this.baseUrl}register`,userObj)
  }

  login(loginObj : any){
    return this.http.post<any>(`${this.baseUrl}authenticate`,loginObj)
  }

  logout(){
    localStorage.clear();
    // localStorage.removeItem('token');
    this.router.navigate(['login']);

  }


  //after crating guard token

  //store token for loacl storage to navigate the followingpage
  storetoken(tokenval:string){
    localStorage.setItem('token',tokenval)
  }

  //get token 
  gettoken(){
    return localStorage.getItem('token')
  }

  //as logged in becaue guard will tell true or false
  islogedin():boolean{
    return !!localStorage.getItem('token')
  }

  //aleredy it is encode now  , we write to decode the password
  decodedToken(){
    const jwtHelper = new JwtHelperService();
    const token = this.gettoken()!;
    console.log(jwtHelper.decodeToken(token))
    return jwtHelper.decodeToken(token)
  }
  getfullNameFromToken(){
    if(this.userPayload)
    return this.userPayload.name;
  }

  getRoleFromToken(){
    if(this.userPayload)
    return this.userPayload.role;
  }
  
  storeRefreshToken(tokenValue: string){
    localStorage.setItem('refreshToken', tokenValue)
  }

  
  getRefreshToken(){
    return localStorage.getItem('refreshToken')
  }

  renewToken(tokenApi : token){
    return this.http.post<any>(`${this.baseUrl}refresh`, tokenApi)
  }

}
