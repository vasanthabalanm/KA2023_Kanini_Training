import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { customerdetails } from '../services/customerdetails.service';

@Component({
  selector: 'app-addcustomer',
  templateUrl: './addcustomer.component.html',
  styleUrls: ['./addcustomer.component.css']
})
export class AddcustomerComponent implements OnInit {
  public custform!:FormGroup;
  public added:any[]=[];
  constructor(private formbuilder : FormBuilder,private custs:customerdetails){}
  ngOnInit(): void {
    this.starttemplate();
    this.addcust();
  }
  private starttemplate():void{
    this.custform = this.formbuilder.group({
      customerId: [],
      customerName:[],
      customerEmail: [],
      customerPhone: [],
      customerCity:[],
      customerCount:[]
    });
  }
  public addcust():void{
    this.custs.Addcust(this.custform.value).subscribe(result =>
      {
      alert(" customer Added! click back button ");
      });
  }
}
