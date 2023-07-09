import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { hotel } from '../services/hotel.service';

@Component({
  selector: 'app-addhotel',
  templateUrl: './addhotel.component.html',
  styleUrls: ['./addhotel.component.css']
})
export class AddhotelComponent implements OnInit {
  showpendingdoctor
  constructor(private formbuilder : FormBuilder,private addhotel:hotel){}
  ngOnInit(): void {
    this.starttemplate();
    this.Addhotels();
  }
  private starttemplate():void{
    this.hotlform = this.formbuilder.group({
      hotelId: [],
      hotelName: [],
      hotelDescription:[],
      hotelRoomPrice: [],
      hotelRoomsAvailable: [],
      hotelLocation: []
     });
  }
  public Addhotels():void{
    this.addhotel.Addhotel(this.hotlform.value).subscribe(result =>
      {
      alert(" hotel Added! click back button ");
      // this.addhotel.navigate(['hotel'])
      });
  }
  

}
