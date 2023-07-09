import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { staffowner } from '../services/staffowner.service';

@Component({
  selector: 'app-updatestaff',
  templateUrl: './updatestaff.component.html',
  styleUrls: ['./updatestaff.component.css']
})
export class UpdatestaffComponent implements OnInit  {
  public staform!:FormGroup;
  public StaffsId: any;
  public Hotl:any[] = [];
productUpdateval:any = { hotelId : '', staffName : '',staffemail:'',staffPassword:''};
constructor(private staff:staffowner){}
  ngOnInit(): void {
    this.getAllHotels();
  }


public Updatestaffbyid()
  {
    return this.staff.Updatestaff(this.StaffsId,this.productUpdateval).subscribe(
      (result) => { alert("staff Updated");},
      
      );
  }
  public getAllHotels():void{
    this.staff.getstaff().subscribe(result=>
      this.Hotl=result)
  }
  
}