import { Injectable } from "@angular/core";
@Injectable({
    providedIn:'root'
})

export class loggerService{
    log(message:any){
    console.log(message);
   }
    
}