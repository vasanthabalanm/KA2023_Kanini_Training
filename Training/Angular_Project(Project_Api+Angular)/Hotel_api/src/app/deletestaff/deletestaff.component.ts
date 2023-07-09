import { Component } from '@angular/core';
import { staffowner } from '../services/staffowner.service';

@Component({
  selector: 'app-deletestaff',
  templateUrl: './deletestaff.component.html',
  styleUrls: ['./deletestaff.component.css']
})
export class DeletestaffComponent {
  public hotelid: any;
  staffId!:number;
  public Hotl:any[] = [];

  constructor(private staf: staffowner,
    ) { }

  ngOnInit(): void {
    this.getAllHotels();

  }
  
  
    public deleteStaffById(): void {
      this.staf.deletestaff(this.staffId)
        .subscribe(
          () => {
            alert(`hotel is deleted and the id is: ${this.staffId}`);
          },
          (error) => {
            alert(`hotel is deleted and the id is: ${this.staffId}`);
          }
        );
  }
  public getAllHotels():void{
    this.staf.getstaff().subscribe(result=>
      this.Hotl=result)
  }
  
}
