import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { FormsModule } from '@angular/forms'


@Component({
  selector: 'app-reactiveforms',
  templateUrl: './reactiveforms.component.html',
  styleUrls: ['./reactiveforms.component.css']
})
export class ReactiveformsComponent
{
  contactForm = new FormGroup
  ({
    // firstname: new FormControl(),
    firstname: new FormControl("Enter your Name"),
    // firstname: new FormControl({ value: "Rahul", disabled: true} ),  //To give a default value//

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
