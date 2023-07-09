import { Component } from '@angular/core';
import { customerdetails } from '../services/customerdetails.service';

@Component({
  selector: 'app-deletebooking',
  templateUrl: './deletebooking.component.html',
  styleUrls: ['./deletebooking.component.css']
})
export class DeletebookingComponent {
  public bookingId: any;
  bookmId!: number;
  public books: any[] = [];

  constructor(private bk: customerdetails,
  ) { }

  ngOnInit(): void {
    this.getAllbook();

  }


  public deletebkById(): void {
    this.bk.deletebook(this.bookmId)
      .subscribe(
        (result) => {
          alert(`booking is deleted and the id is: ${this.bookmId}`);
        },
        (error) => {
          alert(`booking is deleted and the id is: ${this.bookmId}`);
        }
      );
  }
  public getAllbook(): void {
    this.bk.getbook().subscribe(result =>
      this.books = result)
  }
}
