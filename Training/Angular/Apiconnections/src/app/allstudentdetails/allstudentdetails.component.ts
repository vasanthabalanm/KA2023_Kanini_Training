import { Component } from '@angular/core';
import { studentserv } from './studentserv';

@Component({
  selector: 'app-allstudentdetails',
  templateUrl: './allstudentdetails.component.html',
  styleUrls: ['./allstudentdetails.component.css']
})
export class AllstudentdetailsComponent {
  public students: any;
  constructor(private service: studentserv) { }

  ngOnInit(): void {
    this.getStudents();
  }

  private getStudents(): void {
    this.service.getAllStudents().subscribe(result => {
      this.students = result;
      //for understanding we use to see console.log
      console.log(this.students);
    });
  }
}
