import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { customerdetails } from '../services/customerdetails.service';

@Component({
  selector: 'app-updatecustomer',
  templateUrl: './updatecustomer.component.html',
  styleUrls: ['./updatecustomer.component.css']
})
export class UpdatecustomerComponent implements OnInit  {
  public custform!:FormGroup;
  public custid: any;
  public custs:any[] = [];
  customerId!:any;
updatecust:any = { customerName : '', customerEmail : '',customerPhone:'',customerCity:'',customerCount:''};
constructor(private cust:customerdetails){}
  ngOnInit(): void {
    this.getAllcustomer();
  }


public Updatecustbyid()
  {
    console.log(this.updatecust)
    return this.cust.Updatecust(this.customerId,this.updatecust).subscribe(
      (result) => { alert("customer Updated");}
      
      );
  }
  public getAllcustomer():void{
    this.cust.getcust().subscribe(result=>
      this.custs=result)
  }
  
}
