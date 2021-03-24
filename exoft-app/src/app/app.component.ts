import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  leftOpened = false;
  toggle() {
    this.leftOpened = !this.leftOpened;
  }
}
