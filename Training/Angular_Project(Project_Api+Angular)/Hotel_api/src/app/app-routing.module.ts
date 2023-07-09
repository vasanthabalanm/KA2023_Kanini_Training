import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { OwnerComponent } from './owner/owner.component';
import { HotelsComponent } from './hotels/hotels.component';
import { AddhotelComponent } from './addhotel/addhotel.component';
import { UpdatehotelComponent } from './updatehotel/updatehotel.component';
import { DeletehotelComponent } from './deletehotel/deletehotel.component';
import { CustomersComponent } from './customers/customers.component';
import { OptionownerComponent } from './optionowner/optionowner.component';
import { StaffownerComponent } from './staffowner/staffowner.component';
import { AddstaffComponent } from './addstaff/addstaff.component';
import { UpdatestaffComponent } from './updatestaff/updatestaff.component';
import { DeletestaffComponent } from './deletestaff/deletestaff.component';
import { CustomerdetailsComponent } from './customerdetails/customerdetails.component';
import { HotelstaffLoginComponent } from './hotelstaff-login/hotelstaff-login.component';
import { AddcustomerComponent } from './addcustomer/addcustomer.component';
import { UpdatecustomerComponent } from './updatecustomer/updatecustomer.component';
import { DeletecustomerComponent } from './deletecustomer/deletecustomer.component';
import { CustomerbookingComponent } from './customerbooking/customerbooking.component';
import { AddbookingComponent } from './addbooking/addbooking.component';
import { UpdatebookingComponent } from './updatebooking/updatebooking.component';
import { DeletebookingComponent } from './deletebooking/deletebooking.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'owner',component:OwnerComponent},
  {path:'addhotel',component:AddhotelComponent},
  {path:'update',component:UpdatehotelComponent},
  {path:'delete',component:DeletehotelComponent},
  {path:'custo',component:CustomersComponent},
  {path:'customerdetails',component:CustomerdetailsComponent},
  {path:'hotelstaffs',component:HotelstaffLoginComponent},
  {path:'optionsowner',component:OptionownerComponent},
  {path:'owner/optionsowner',component:OptionownerComponent},
  {path:'owner/hotelstaffs',component:HotelstaffLoginComponent},
  {path:'addcust',component:AddbookingComponent},
  {path:'owner/optionsowner/hotel',component:HotelsComponent},
  {path:'owner/optionsowner/staff',component:StaffownerComponent},
  {path:'owner/hotelstaffs/customerdetails',component:CustomerdetailsComponent},
  {path:'owner/optionsowner/hotel/addhotel',component:AddhotelComponent},
  {path:'owner/optionsowner/hotel/update',component:UpdatehotelComponent},
  {path:'owner/optionsowner/hotel/delete',component:DeletehotelComponent},
  {path:'owner/optionsowner/staff/addstaff',component:AddstaffComponent},
  {path:'owner/optionsowner/staff/updatestaff',component:UpdatestaffComponent},
  {path:'owner/optionsowner/staff/deletestaff',component:DeletestaffComponent},
  {path:'owner/hotelstaffs/customerdetails/addcust',component:AddcustomerComponent},
  {path:'owner/hotelstaffs/customerdetails/updatecust',component:UpdatecustomerComponent},
  {path:'owner/hotelstaffs/customerdetails/deletecust',component:DeletecustomerComponent},
  {path:'owner/hotelstaffs/customerdetails/addcust/addbook',component:AddbookingComponent},
  {path:'owner/hotelstaffs/cusbooking',component:CustomerbookingComponent},
  {path:'owner/hotelstaffs/cusbooking/addbookings',component:AddbookingComponent},
  {path:'owner/hotelstaffs/cusbooking/updatebookings',component:UpdatebookingComponent},
  {path:'owner/hotelstaffs/cusbooking/deletebookings',component:DeletebookingComponent},


  



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
