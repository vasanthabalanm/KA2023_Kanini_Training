import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs'

@Injectable({
  providedIn: 'root'
})
export class staffowner {
  navigate: any;

  constructor(private http: HttpClient) { }
  public getstaff(): Observable<any> {
    return this.http.get(`https://localhost:7026/api/HotelAdmins`)
  }
  public Addstaff(hotel: any): Observable<any> {
    return this.http.post(`https://localhost:7026/api/HotelAdmins`, hotel);
  }

  public Updatestaff(id: number, hotel: any) {
    const url = `https://localhost:7026/api/HotelAdmins/${id}`;
    return this.http.put(url, hotel);
  }
  public deletestaff(id: number): Observable<any> {
    return this.http.delete(`https://localhost:7026/api/HotelAdmins/${id}`);
  }
 
}

