import { Component } from '@angular/core';

@Component({
  selector: 'app-exoft-achievements',
  templateUrl: './exoft-achievements.component.html',
  styleUrls: ['./exoft-achievements.component.scss']
})
export class ExoftAchievementsComponent {
  achievements = [
    {
      avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg',
      title: 'Exoft Turbo Power',
      xp: 15,
      granted: new Date(2021, 1, 31, 12, 0, 0)
    },
    {
      avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg',
      title: 'Exoft Turbo Power',
      xp: 15,
      granted: new Date(2020, 2, 31, 12, 0, 0)
    },
    {
      avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg',
      title: 'Exoft Turbo Power',
      xp: 15,
      granted: new Date(2021, 2, 31, 12, 0, 0)
    },
    {
      avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg',
      title: 'Exoft Turbo Power',
      xp: 15,
      granted: new Date(2021, 3, 13, 20, 0, 0)
    },
    {
      avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg',
      title: 'Exoft Turbo Power',
      xp: 15,
      granted: new Date(2021, 2, 31, 12, 0, 0)
    },
    {
      avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg',
      title: 'Exoft Turbo Power',
      xp: 15,
      granted: new Date(2021, 2, 31, 12, 0, 0)
    },
    {
      avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg',
      title: 'Exoft Turbo Power',
      xp: 15,
      granted: new Date(2021, 2, 31, 12, 0, 0)
    },
  ];
}
