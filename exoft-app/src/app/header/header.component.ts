import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {     
  @Output() toggle: EventEmitter<any> = new EventEmitter();

  constructor() { }

  emit() {
      this.toggle.emit(null);
  }
}
