import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllstudentdetailsComponent } from './allstudentdetails/allstudentdetails.component';

const routes: Routes = [
  {path:'',component:AllstudentdetailsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
