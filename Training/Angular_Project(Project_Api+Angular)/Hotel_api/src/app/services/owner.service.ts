import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs'

@Injectable({
  providedIn: 'root'
})
export class owner {

  private loggedIn = false;

  login(id:number, username: string, password: string, role:string) {
    // Simulate API call to authenticate user
    if (id ===2 && username === 'Owner2' && password === 'Owner2@12345'&& role==='owner') {
      // Set token in local storage
      localStorage.setItem('token', 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJKV1RTZXJ2aWNlQWNjZXNzVG9rZW4iLCJqdGkiOiI4MTk4M2MwNC1iNjc2LTQ1NjYtYTE2OC1lOWFjZGE2MTg5YjMiLCJpYXQiOiIxMC0wNi0yMDIzIDE2OjU1OjU1IiwiVXNlcklkIjoiMiIsIkVtYWlsIjoiT3duZXIyQGdtYWlsLmNvbSIsIlBhc3N3b3JkIjoiT3duZXIyQDEyMzQ1IiwiUm9sZSI6Im93bmVyIiwiZXhwIjoxNjg2NDE2NDU2LCJpc3MiOiJKV1RBdXRoZW50aWNhdGlvblNlcnZlciIsImF1ZCI6IkpXVFNlcnZpY2VQb3N0bWFuQ2xpZW50In0.VSC-QOO22qGppW1um9eNKGFQ16YAiT1ZL1YYbJ2V2Y4');
      this.loggedIn = true;
    }
  }

  logout() {
    // Remove token from local storage
    localStorage.removeItem('token');
    this.loggedIn = false;
  }

  isLoggedIn() {
    return this.loggedIn;
  }

  
}
