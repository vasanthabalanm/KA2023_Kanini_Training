import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-reactiveform',
  templateUrl: './reactiveform.component.html',
  styleUrls: ['./reactiveform.component.css']
})
export class ReactiveformComponent {

  contactForm = new FormGroup
  ({
    // firstname: new FormControl(),
    firstname: new FormControl("Rahul"),
    // firstname: new FormControl({ value: "Rahul", disabled: true} ),

    lastname: new FormControl(),
    email: new FormControl(),
    gender: new FormControl(),
    isMarried: new FormControl(),
    country: new FormControl()
  })
 
 
  onSubmit() {
    console.log("submit");
    console.log(this.contactForm.value);
  }


}
