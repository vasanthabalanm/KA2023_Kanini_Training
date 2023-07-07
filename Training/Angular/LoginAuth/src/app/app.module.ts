import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { SignupComponent } from './components/signup/signup.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import {NgToastModule} from 'ng-angular-popup'
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { TokensInterceptor } from './interceptors/tokens.interceptor';
import { HomeComponent } from './components/home/home.component';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    SignupComponent,
    DashboardComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgToastModule
    
  ],
  providers: [{
    provide:HTTP_INTERCEPTORS,
    useClass:TokensInterceptor,
    multi:true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
