import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class Account {

  constructor(private http: HttpClient) { }

  onLogin(obj: any) : Observable<any> {
    return this.http.post('https://localhost:7026/api/Token',obj);
  }
  getCustomers() : Observable<any> {

    return this.http.get('https://localhost:7026/api/HotelDetails');
  }

 
}
