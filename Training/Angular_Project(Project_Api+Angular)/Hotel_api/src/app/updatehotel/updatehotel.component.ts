import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { hotel } from '../services/hotel.service';
import { ActivatedRoute } from '@angular/router';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-updatehotel',
  templateUrl: './updatehotel.component.html',
  styleUrls: ['./updatehotel.component.css']
})
export class UpdatehotelComponent implements OnInit {
  public hotlform!:FormGroup;
  public hotelid: any;
  public Hotl:any[] = [];
  hotelId!:any;
productUpdateval:any = { hotelName :'', hotelDescription : '', hotelRoomPrice : '',hotelRoomsAvailable:'',hotelLocation:''};
constructor(private Hotels:hotel){}
  ngOnInit(): void {
    this.getAllHotels();
  }


public UpdatehotelById()
  {
    return this.Hotels.Updatehotel(this.hotelId,this.productUpdateval).subscribe(
      (result) => { alert("hotel Updated");}
      );
  }
  public getAllHotels():void{
    this.Hotels.getallhotel().subscribe(result=>
      this.Hotl=result)
  }
  
}