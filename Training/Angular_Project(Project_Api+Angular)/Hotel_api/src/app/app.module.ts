import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';

import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { OwnerComponent } from './owner/owner.component';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { SignupComponent } from './signup/signup.component';
import { HotelstaffLoginComponent } from './hotelstaff-login/hotelstaff-login.component';
import { HotelsComponent } from './hotels/hotels.component';
import { AddhotelComponent } from './addhotel/addhotel.component';
import { UpdatehotelComponent } from './updatehotel/updatehotel.component';
import { DeletehotelComponent } from './deletehotel/deletehotel.component';
import { CustomersComponent } from './customers/customers.component';
import { OptionownerComponent } from './optionowner/optionowner.component';
import { StaffownerComponent } from './staffowner/staffowner.component';
import { AddstaffComponent } from './addstaff/addstaff.component';
import { DeletestaffComponent } from './deletestaff/deletestaff.component';
import { UpdatestaffComponent } from './updatestaff/updatestaff.component';
import { CustomerdetailsComponent } from './customerdetails/customerdetails.component';
import { AddcustomerComponent } from './addcustomer/addcustomer.component';
import { UpdatecustomerComponent } from './updatecustomer/updatecustomer.component';
import { DeletecustomerComponent } from './deletecustomer/deletecustomer.component';
import { CustomerbookingComponent } from './customerbooking/customerbooking.component';
import { AddbookingComponent } from './addbooking/addbooking.component';
import { UpdatebookingComponent } from './updatebooking/updatebooking.component';
import { DeletebookingComponent } from './deletebooking/deletebooking.component';
import { custom } from './services/custom.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    OwnerComponent,
    SignupComponent,
    HotelstaffLoginComponent,
    HotelsComponent,
    AddhotelComponent,
    UpdatehotelComponent,
    DeletehotelComponent,
    CustomersComponent,
    OptionownerComponent,
    StaffownerComponent,
    AddstaffComponent,
    DeletestaffComponent,
    UpdatestaffComponent,
    CustomerdetailsComponent,
    AddcustomerComponent,
    UpdatecustomerComponent,
    DeletecustomerComponent,
    CustomerbookingComponent,
    AddbookingComponent,
    UpdatebookingComponent,
    DeletebookingComponent
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
