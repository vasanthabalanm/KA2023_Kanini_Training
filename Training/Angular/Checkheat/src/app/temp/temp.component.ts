import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-temp',
  templateUrl: './temp.component.html',
  styleUrls: ['./temp.component.css']
})
export class TempComponent {
  myForm!: FormGroup;
  inputTemperature!: number;
  selectedUnit!: string;
  convertedTemperature!: number;

  convertTemperature() {
    
    if (this.selectedUnit === 'C') {
      this.convertedTemperature = (this.inputTemperature * 9 / 5) + 32;
    } else if (this.selectedUnit === 'F') {
      this.convertedTemperature = (this.inputTemperature - 32) * 5 / 9;
    }
    
  }
  
  

}
