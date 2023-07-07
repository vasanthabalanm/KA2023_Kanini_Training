import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent {
  public dropDownValue = "";
      SetDropDownValue(drpValue : any) {
        this.dropDownValue = drpValue.target.value;
    }

}
