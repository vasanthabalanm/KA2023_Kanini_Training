import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavComponent } from 'src/app/nav/nav.component';
import {DropdownComponent} from 'src/app/dropdown/dropdown.component'

@NgModule({
  declarations: 
  [
    NavComponent
  ],
  imports: [
    CommonModule,
    DropdownComponent
  ]
})
export class NavigationModule { 

}
