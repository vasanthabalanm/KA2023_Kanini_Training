import { Component, OnInit } from '@angular/core';
import { staffowner } from '../services/staffowner.service';

@Component({
  selector: 'app-staffowner',
  templateUrl: './staffowner.component.html',
  styleUrls: ['./staffowner.component.css']
})
export class StaffownerComponent implements OnInit {
  public Hotl:any[] = [];
  constructor(private staff:staffowner){}
  ngOnInit(): void {
  this.getAllHotels();
  }

  public getAllHotels():void{
    this.staff.getstaff().subscribe(result=>
      this.Hotl=result)
  }


}