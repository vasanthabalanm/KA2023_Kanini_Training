import { Component } from '@angular/core';
import { customerdetails } from '../services/customerdetails.service';

@Component({
  selector: 'app-deletecustomer',
  templateUrl: './deletecustomer.component.html',
  styleUrls: ['./deletecustomer.component.css']
})
export class DeletecustomerComponent {
  public customerId: any;
  custmId!:number;
  public customers:any[] = [];

  constructor(private custs: customerdetails,
    ) { }

  ngOnInit(): void {
    this.getAllcust();

  }
  
  
    public deletecustById(): void {
      this.custs.deletecust(this.custmId)
        .subscribe(
          (result) => {
            alert(`customer is deleted and the id is: ${this.custmId}`);
          },
          (error) => {
            alert(`customer is deleted and the id is: ${this.custmId}`);
          }
        );
  }
  public getAllcust():void{
    this.custs.getcust().subscribe(result=>
      this.customers=result)
  }
}
