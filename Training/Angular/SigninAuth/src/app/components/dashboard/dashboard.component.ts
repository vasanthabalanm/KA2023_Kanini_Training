import { Component, OnInit } from '@angular/core';
import { ApicallsService } from 'src/app/services/apicalls.service';
import { JwtAuthService } from 'src/app/services/jwt-auth.service';
import { UsernameService } from 'src/app/services/username.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  public users:any = [];
  public role!:string;
  public fullName : string = "";

  constructor( private api:ApicallsService, private auth:JwtAuthService,private usertoken : UsernameService ){}
  ngOnInit() {
    this.api.getUsers()
    .subscribe(res=>{
    this.users = res;
    });

    this.usertoken.getFullNameFromStore()
    .subscribe(val=>{
      const fullNameFromToken = this.auth.getfullNameFromToken();
      this.fullName = val || fullNameFromToken
    });

    this.usertoken.getFullNameFromStore()
    .subscribe(val=>{
      const fullNameFromToken = this.auth.getfullNameFromToken();
      this.fullName = val || fullNameFromToken;
    })

    this.usertoken.getRoleFromStore()
    .subscribe(val=>{
      const roleFromToken = this.auth.getRoleFromToken();
      this.role = val || roleFromToken;
    })
  }

  logout(){
    this.auth.logout();
  }
}