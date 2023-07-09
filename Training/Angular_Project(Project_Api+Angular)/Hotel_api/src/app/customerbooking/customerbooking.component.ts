import { Component, OnInit } from '@angular/core';
import { customerdetails } from '../services/customerdetails.service';

@Component({
  selector: 'app-customerbooking',
  templateUrl: './customerbooking.component.html',
  styleUrls: ['./customerbooking.component.css']
})
export class CustomerbookingComponent implements OnInit {
  public books:any[] = [];
  constructor(private book:customerdetails){}
  ngOnInit(): void {
  this.getAllbooking();
  }

  public getAllbooking():void{
    this.book.getbook().subscribe(result=>
      this.books=result)
  }


}
