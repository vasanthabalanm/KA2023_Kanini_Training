import { AbstractControl, ValidationErrors } from '@angular/forms'
 
export function gte(control: AbstractControl) : 
        ValidationErrors | null 
        {
 
    let v =+ control.value;
    console.log(v);
    if (isNaN(v)) {
      return { 'gte': true, 'requiredValue': 10 }
    }      
    if (v <= 10) {
      return { 'gte': true, 'requiredValue': 10 }
    } 
     return null
}