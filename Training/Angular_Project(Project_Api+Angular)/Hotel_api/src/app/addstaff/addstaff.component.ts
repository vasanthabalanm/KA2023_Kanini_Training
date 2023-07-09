import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { staffowner } from '../services/staffowner.service';

@Component({
  selector: 'app-addstaff',
  templateUrl: './addstaff.component.html',
  styleUrls: ['./addstaff.component.css']
})
export class AddstaffComponent implements OnInit {
  public staffform!:FormGroup;
  public added:any[]=[];
  constructor(private formbuilder : FormBuilder,private addstaff:staffowner){}
  ngOnInit(): void {
    this.starttemplate();
    this.addstafs();
  }
  private starttemplate():void{
    this.staffform = this.formbuilder.group({
      // staffId:[],
      hotelId: [],
      staffName:[],
      staffemail: [],
      staffPassword: []
    });
  }
  public addstafs():void{
    this.addstaff.Addstaff(this.staffform.value).subscribe(result =>
      {
      alert(" staff Added! click back button ");
      });
  }
}
