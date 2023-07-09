import { Component, OnInit } from '@angular/core';
import { customerdetails } from '../services/customerdetails.service';

@Component({
  selector: 'app-customerdetails',
  templateUrl: './customerdetails.component.html',
  styleUrls: ['./customerdetails.component.css']
})
export class CustomerdetailsComponent implements OnInit {
  public customers:any[] = [];
  constructor(private cust:customerdetails){}
  ngOnInit(): void {
  this.getAllcustomer();
  }

  public getAllcustomer():void{
    this.cust.getcust().subscribe(result=>
      this.customers=result)
  }


}