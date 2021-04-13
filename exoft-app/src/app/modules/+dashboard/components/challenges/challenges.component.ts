import { Component } from '@angular/core';

@Component({
  selector: 'app-challenges',
  templateUrl: './challenges.component.html',
  styleUrls: ['./challenges.component.scss']
})
export class ChallengesComponent {
  availableEvents = [
    { cap: 'assets/images/bike.jpg' },
  ];
  finishedEvents = [
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' },
    { cap: 'assets/images/swim.jpeg' }
  ];
}
