import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs'

@Injectable({
  providedIn: 'root'
})
export class customerdetails {
  navigate: any;

  constructor(private http: HttpClient) { }
  public getcust(): Observable<any> {
    return this.http.get(`https://localhost:7026/api/CustomerDetails`)
  }
  public Addcust(custs: any): Observable<any> {
    return this.http.post(`https://localhost:7026/api/CustomerDetails`, custs);
  }

  public Updatecust(id: number, custs: any) {
    const url = `https://localhost:7026/api/CustomerDetails/${id}`;
    return this.http.put(url, custs);
  }
  public deletecust(id: number): Observable<any> {
    return this.http.delete(`https://localhost:7026/api/CustomerDetails/${id}`);
  }
// booking service
  public getbook(): Observable<any> {
    return this.http.get(`https://localhost:7026/api/BookingDetails`)
  }
  public Addbook(custs: any): Observable<any> {
    return this.http.post(`https://localhost:7026/api/BookingDetails`, custs);
  }

  public Updatebook(id: number, custs: any) {
    const url = `https://localhost:7026/api/BookingDetails/${id}`;
    return this.http.put(url, custs);
  }
  public deletebook(id: number): Observable<any> {
    return this.http.delete(`https://localhost:7026/api/BookingDetails/${id}`);
  }
 
}


