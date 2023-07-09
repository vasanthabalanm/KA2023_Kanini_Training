import { Component } from '@angular/core';
import { hotel } from '../services/hotel.service';

@Component({
  selector: 'app-deletehotel',
  templateUrl: './deletehotel.component.html',
  styleUrls: ['./deletehotel.component.css']
})
export class DeletehotelComponent {
  // public hotelid: any;
  // hotelId!:number;

  // constructor(private hotelbyid: hotel) { }

  // ngOnInit(): void {
  // }
  
  // public deletehotelbyid(){
  //     return this.hotelbyid.deletehotelid(this.hotelId)
  //     .subscribe(result => this.hotelid = result );
    
  // }
  public hotelid: any;
  hotelId!:number;
  public Hotl:any[] = [];

  constructor(private Hotels: hotel,
    ) { }

  ngOnInit(): void {
    this.getAllHotels();

  }
  
  // public GetStudentById(){
  //     return this.studentService.getStudentById(this.hotelId)
  //     .subscribe(result => this.hotelid = result );
    
  // }

  // public GetStudentById(): void {
  //   this.studentService.getStudentById(this.hotelId)
  //     .subscribe(
  //       (result) => {
  //         this.hotelid = result;
  //         // Handle the case when the student with the given ID exists
  //       },
  //       (error) => {
  //         alert('there is no hotelid:');
  //         // Handle the case when the student with the given ID does not exist
  //       }
  //     );
  // }
  
    public deleteStudentById(): void {
      this.Hotels.deletehotelid(this.hotelId)
        .subscribe(
          () => {
            alert(`hotel is deleted and the id is: ${this.hotelId}`);
            // Handle any additional logic or UI updates after successful deletion
          },
          (error) => {
            alert(`hotel is deleted and the id is ${this.hotelId}`);
            // Handle the case when the student with the given ID does not exist
          }
        );
  }
  public getAllHotels():void{
    this.Hotels.getallhotel().subscribe(result=>
      this.Hotl=result)
  }
  
  
}
