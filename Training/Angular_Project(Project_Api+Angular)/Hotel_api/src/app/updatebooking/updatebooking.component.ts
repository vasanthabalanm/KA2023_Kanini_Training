import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { customerdetails } from '../services/customerdetails.service';

@Component({
  selector: 'app-updatebooking',
  templateUrl: './updatebooking.component.html',
  styleUrls: ['./updatebooking.component.css']
})
export class UpdatebookingComponent implements OnInit {
  public bookform!: FormGroup;
  public bookingId: any;
  public bookdet: any[] = [];
  boking!: any;
  updatebooks: any = {roomId: '', customerId: '' };
  constructor(private bk: customerdetails) { }
  ngOnInit(): void {
    this.getAllbooking();
  }


  public Updatebookbyid() {
    return this.bk.Updatebook(this.bookingId, this.updatebooks).subscribe(
      (result) => { alert("booking Updated"); },

    );
  }
  public getAllbooking(): void {
    this.bk.getbook().subscribe(result =>
      this.bookdet = result)
  }

}
