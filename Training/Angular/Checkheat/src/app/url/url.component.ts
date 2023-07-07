import { Component } from '@angular/core';

@Component({
  selector: 'app-url',
  templateUrl: './url.component.html',
  styleUrls: ['./url.component.css']
})
export class UrlComponent {
  inputURL!: string;
  shortenedURL!: string;

  shortenURL() {
    this.shortenedURL = 'https://success/123';
  }

  copyToClipboard() {
    const tempInput = document.createElement('input');
    tempInput.value = this.shortenedURL;
    document.body.appendChild(tempInput);
    tempInput.select();
    document.execCommand('copy');
    document.body.removeChild(tempInput);
  }
}
