import { Component, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-personal-achievements',
  templateUrl: './personal-achievements.component.html',
  styleUrls: ['./personal-achievements.component.css']
})
export class PersonalAchievementsComponent {
  public achievements = [
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Turbo Power', xp: 15, granted: 0 },
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Turbo Power', xp: 15, granted: 2 },
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Skylark Power', xp: 20, granted: 10 },
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Corpo Power', xp: 25, granted: 23 },
  ];

}
