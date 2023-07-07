import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AllstudentdetailsComponent } from './allstudentdetails/allstudentdetails.component';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { GetstudentidComponent } from './getstudentid/getstudentid.component';
import { AddstudentdetailsComponent } from './addstudentdetails/addstudentdetails.component';
import { UpdatestudentdetailsComponent } from './updatestudentdetails/updatestudentdetails.component';
import { DeletestudentdetailsComponent } from './deletestudentdetails/deletestudentdetails.component';
@NgModule({
  declarations: [
    AppComponent,
    AllstudentdetailsComponent,
    GetstudentidComponent,
    AddstudentdetailsComponent,
    UpdatestudentdetailsComponent,
    DeletestudentdetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
