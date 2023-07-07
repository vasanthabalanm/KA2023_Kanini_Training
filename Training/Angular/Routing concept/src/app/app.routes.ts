import { Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { ContactComponent } from "./contact/contact.component";
import { ProductComponent } from "./product/product.component";
import { BugsComponent } from "./bugs/bugs.component";

export const approutes : Routes =[
    {path:'home',component:HomeComponent},
    {path:'contact',component:ContactComponent},
    {path:'product',component:ProductComponent},
    {path:'',redirectTo:'home',pathMatch:"full"}, //default route 
    {path:'**',component:BugsComponent} //wild cald route
];