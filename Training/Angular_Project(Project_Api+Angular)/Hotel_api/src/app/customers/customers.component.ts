import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent {
  location!: string;
  locations!: string[];
  minprice!: number;
  maxprice!: number;
  hotels!: any[];

  // collapse
  title = 'appBootstrap';
  
  public isCollapsed1 = true;
  public isCollapsed2 = true;
  public isCollapsed3 = true;
  public isCollapsed4 = true;
  public isCollapsed5 = true;
  public isCollapsed6 = true;

  constructor(private http: HttpClient) { }

  searchHotels(): void {
    this.getlocation(this.location, this.minprice, this.maxprice)
      .subscribe((response: any[]) => {
        this.hotels = response;

      });
  }

  getlocation(location: string, minprice: number, maxprice: number): Observable<any> {
    return this.http.get(`https://localhost:7026/api/HotelDetails/filter?location=${location}&minprice=${minprice}&maxprice=${maxprice}`);
  
  //   (this.location)
  //   .subscribe((response: string[]) => {
  //     this.locations = response;
      
   }

}
