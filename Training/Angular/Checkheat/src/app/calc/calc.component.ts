import { Component } from '@angular/core';

@Component({
  selector: 'app-calc',
  templateUrl: './calc.component.html',
  styleUrls: ['./calc.component.css']
})
export class CalcComponent {
  purchasePrice: number = 0;
  downPayment: number = 0;
  repaymentTime: number = 1;
  interestRate: number = 0;

  get loanAmount(): number {
    return this.purchasePrice - this.downPayment;
  }

  get monthlyPayment(): number {
    const monthlyInterestRate = this.interestRate / 100 / 12;
    const numberOfPayments = this.repaymentTime * 12;
    const compoundedInterest = Math.pow(1 + monthlyInterestRate, numberOfPayments);
    const monthlyPayment = (this.loanAmount * monthlyInterestRate * compoundedInterest) / (compoundedInterest - 1);
    return monthlyPayment;
  }
}
