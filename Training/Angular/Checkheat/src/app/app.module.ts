import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Component, OnInit } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { TempComponent } from './temp/temp.component';
import { Router, RouterModule } from '@angular/router';
import { UrlComponent } from './url/url.component';
import { CalcComponent } from './calc/calc.component';



@NgModule({
  declarations: [
    AppComponent,
    TempComponent,
    UrlComponent,
    CalcComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
