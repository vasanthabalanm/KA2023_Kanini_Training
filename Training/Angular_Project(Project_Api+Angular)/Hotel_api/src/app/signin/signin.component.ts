import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { owner } from '../services/owner.service';
import { HttpClient } from '@angular/common/http';
import { Account } from '../services/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.css']
})
export class SigninComponent implements OnInit {
  signupUsers: any[] = [];
  signupObj:any = {
    userId: '',
    userName: '',
    emailId: '',
    password: '',
    roles: ''
  };
  loginObj: any = {
    userId: '',
    userName: '',
    emailId: '',
    password: '',
    roles: ''
  };

  constructor(private accService: Account, private route: Router) { }

  ngOnInit(): void {
    const localData = localStorage.getItem('signUpUsers');
    if(localData != null) {
      this.signupUsers = JSON.parse(localData);
    }
  }
  onSignUp() {
   this.signupUsers.push(this.signupObj);
   localStorage.setItem('signUpUsers',JSON.stringify(this.signupUsers));
   this.signupObj = {
    userId: '',
    userName: '',
    emailId: '',
    password: '',
    roles: ''
  };
  }
  onLogin() {

    this.route.navigateByUrl('/optionsowner');
  this.accService.onLogin(this.loginObj).subscribe((res: any) => {


    console.log('res',res)
    localStorage.setItem('token',res.token);
     this.route.navigateByUrl('/dashboard');
  })
  }
}