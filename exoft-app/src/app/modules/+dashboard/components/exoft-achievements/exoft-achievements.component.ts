import { MatDialog } from '@angular/material/dialog';

import { Component } from '@angular/core';
import { UserAchievementsComponent } from 'src/app/shared/dialogs/user-achievements/user-achievements.component';

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
    {
      avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg',
      title: 'Exoft Turbo Power',
      xp: 15,
      granted: new Date(2021, 2, 31, 12, 0, 0)
    }
  ];
  constructor(private readonly dialog: MatDialog) { }

  openDialog(): void {
    this.dialog.open(UserAchievementsComponent, { panelClass: 'user-dialog-container' });
  }
}
