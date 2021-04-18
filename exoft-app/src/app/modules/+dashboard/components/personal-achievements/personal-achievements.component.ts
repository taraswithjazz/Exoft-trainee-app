import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { RequestAchievementComponent } from 'src/app/shared/dialogs/request-achievement/request-achievement.component';

@Component({
  selector: 'app-personal-achievements',
  templateUrl: './personal-achievements.component.html',
  styleUrls: ['./personal-achievements.component.scss']
})
export class PersonalAchievementsComponent {
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
    }
  ];
  constructor(private readonly dialog: MatDialog) { }

  openDialog(): void {
    this.dialog.open(RequestAchievementComponent, { panelClass: 'request-dialog-container' });
  }
}
