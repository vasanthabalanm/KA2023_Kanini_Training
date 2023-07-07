import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, RouterLink } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContactComponent } from './contact/contact.component';
import { HomeComponent } from './home/home.component';
import { ProductComponent } from './product/product.component';
import { BugsComponent } from './bugs/bugs.component';
import { ProductService } from './product/product-service.service';
import { approutes } from './app.routes';

@NgModule({
    declarations: [
        AppComponent,
        ContactComponent,
        HomeComponent,
        ProductComponent,
        BugsComponent
    ],
   
    imports: [
        BrowserModule,
        AppRoutingModule,
        //path location strategy
        RouterModule.forRoot(approutes)
        //hash location strategy both are work as same
        // RouterModule.forRoot(approutes, { useHash: true }),
        // RouterLink
    ],
    providers: [ProductService],
    bootstrap: [AppComponent]
})
export class AppModule { }
