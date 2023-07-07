import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import validation from 'src/app/helpers/validation';
import { JwtAuthService } from 'src/app/services/jwt-auth.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  public signUpForm!: FormGroup;
  type: string = 'password';
  isText: boolean = false;
  eyeIcon:string = "fa-eye-slash"
  constructor(
    private fb : FormBuilder, 
    private auth : JwtAuthService,
    private router: Router,
    ) { }

  ngOnInit() {
    this.signUpForm = this.fb.group({
      firstName:['', Validators.required],
      lastName:['', Validators.required],
      userName:['', Validators.required],
      email:['', Validators.required],
      password:['', Validators.required]
    })
  }

  hideShowPass(){
    this.isText = !this.isText;
    this.isText ? this.eyeIcon = 'fa-eye' : this.eyeIcon = 'fa-eye-slash'
    this.isText ? this.type = 'text' : this.type = 'password'
  }

  onSubmit() {
    if (this.signUpForm.valid) {
      this.auth.signUp(this.signUpForm.value).subscribe({
        next: (res => {
          alert(res.message);
          this.signUpForm.reset();
          this.router.navigate(['login']);
        })
        ,
        error:(err =>{
          alert(err?.error.message)
        })
      })
      
      
    } else {
      validation.validateAllFormFields(this.signUpForm);
      // alert("please enter the all fields")
    }
  }

}