import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs'

@Injectable({
  providedIn: 'root'
})
export class hotel {
  navigate: any;

  constructor(private http: HttpClient) { }
  public getallhotel(): Observable<any> {
    return this.http.get(`https://localhost:7026/api/HotelDetails`)
  }
  public Addhotel(hotel: any): Observable<any> {
    return this.http.post(`https://localhost:7026/api/HotelDetails`, hotel);
  }

  public Updatehotel(id: number, hotel: any) {
    const url = `https://localhost:7026/api/HotelDetails/${id}`;
    return this.http.put(url, hotel);
  }
  public deletehotelid(id: number): Observable<any> {
    return this.http.delete(`https://localhost:7026/api/HotelDetails/${id}`);
  }
  // public getStudentById(id:number):Observable<any>
  // {
  //   return this.http.get(`https://localhost:7026/api/HotelDetails/${id}`);                       
  // }
  public getlocation(location: string, minprice: number, maxprice: number): Observable<any> {
    return this.http.get(`https://localhost:7026/api/HotelDetails/filter?location=${location}&minprice=${minprice}&maxprice=${maxprice}`);
  }
  public getlocationlist(location:string):Observable<any>{
    return this.http.get(`https://localhost:7026/api/HotelDetails/filter?location=${location}`)};

  }

