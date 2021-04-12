import { Component } from '@angular/core';

@Component({
  selector: 'app-challenges',
  templateUrl: './challenges.component.html',
  styleUrls: ['./challenges.component.scss']
})
export class ChallengesComponent {
  public availableEvents = [
    { cap: 'assets/images/bike.jpg' },
  ];
  public finishedEvents = [
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
