import { Component } from '@angular/core';

@Component({
  selector: 'app-achievements-list',
  templateUrl: './achievements-list.component.html',
  styleUrls: ['./achievements-list.component.scss']
})
export class AchievementsListComponent {
  achievements = [
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
      granted: new Date(2021, 3, 13, 20, 0, 0)
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
      granted: new Date(2021, 3, 13, 20, 0, 0)
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
      granted: new Date(2021, 3, 13, 20, 0, 0)
    },
    {
      avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg',
      title: 'Exoft Turbo Power',
      xp: 15,
      granted: new Date(2021, 3, 13, 20, 0, 0)
    }
  ];

  displayedColumns: string[] = ['Achievement', 'XP points', 'Date'];
}
