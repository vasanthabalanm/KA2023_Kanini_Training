import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { customerdetails } from '../services/customerdetails.service';

@Component({
  selector: 'app-addbooking',
  templateUrl: './addbooking.component.html',
  styleUrls: ['./addbooking.component.css']
})
export class AddbookingComponent implements OnInit {
  public bookingform!:FormGroup;
  public added:any[]=[];
  constructor(private formbuilder : FormBuilder,private adbk:customerdetails){}
  ngOnInit(): void {
    this.starttemplate();
    this.Addbook();
  }
  private starttemplate():void{
    this.bookingform = this.formbuilder.group({
      bookingId: [],
      roomId: [],
      customerId:[]
     });
  }
  public Addbook():void{
    this.adbk.Addbook(this.bookingform.value).subscribe(result =>
      {
      alert(" hotel Added! click back button ");
      // this.addhotel.navigate(['hotel'])
      });
  }
  

}