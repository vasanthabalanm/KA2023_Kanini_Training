import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Route, Router } from '@angular/router';
import { NgToastService } from 'ng-angular-popup';
import validation from 'src/app/helpers/validation';
import { JwtAuthService } from 'src/app/services/jwt-auth.service';
import { UsernameService } from 'src/app/services/username.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  public loginForm!: FormGroup;
  type: string = 'password';
  isText: boolean = false;
  eyeIcon: string = 'fa-eye-slash';
  
  constructor(
    private fb: FormBuilder,
    private auth: JwtAuthService,
    private router: Router,
    private toast : NgToastService,
    private userser:UsernameService

   
  ) {}

  ngOnInit() {
    this.loginForm = this.fb.group({
      username: ['', Validators.required],
      password: ['', Validators.required],
    });
  }

  hideShowPass() {
    this.isText = !this.isText;
    this.isText ? (this.eyeIcon = 'fa-eye') : (this.eyeIcon = 'fa-eye-slash');
    this.isText ? (this.type = 'text') : (this.type = 'password');
  }
  onSubmit() {
    if (this.loginForm.valid) {
      console.log(this.loginForm.value);
      this.auth.login(this.loginForm.value).subscribe({
        next: (res) => {
          // alert(res.message);
          this.loginForm.reset();
          //store the token
          this.auth.storetoken(res.token);
          const tokenPayload = this.auth.decodedToken();
          this.userser.setFullNameForStore(tokenPayload.name);
          this.userser.setRoleForStore(tokenPayload.role);
          this.toast.success({detail:"SUCCESS", summary:res.message, duration: 5000});
          this.router.navigate(['dashboard'])
        },
        error:() =>{
          this.toast.error({detail:"ERROR", summary:"Something when wrong!", duration: 5000});
        }
      })
      
    } else {
      validation.validateAllFormFields(this.loginForm);
      alert("please enter the all fields")
    }
  }
}