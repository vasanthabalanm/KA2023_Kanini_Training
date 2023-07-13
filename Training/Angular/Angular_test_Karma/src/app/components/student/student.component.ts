import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent {
 

  title = 'StudComp';

  student = {
    name: '',
    age: 0,
    grade: ''
  };  

  submitForm(form: NgForm) {
    console.log(this.student);
    // form.reset();
  }

}
