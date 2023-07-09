import { Component, OnInit } from '@angular/core';
import { hotel } from '../services/hotel.service';

@Component({
  selector: 'app-hotels',
  templateUrl: './hotels.component.html',
  styleUrls: ['./hotels.component.css']
})
export class HotelsComponent implements OnInit {
  public Hotl:any[] = [];
  constructor(private Hotels:hotel){}
  ngOnInit(): void {
  this.getAllHotels();
  }

  public getAllHotels():void{
    this.Hotels.getallhotel().subscribe(result=>
      this.Hotl=result)
  }


}
