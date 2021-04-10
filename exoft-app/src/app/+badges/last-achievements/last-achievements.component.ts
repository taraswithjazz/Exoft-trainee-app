import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { RequestAchievementComponent } from 'src/app/shared/dialogs/request-achievement/request-achievement.component';

@Component({
  selector: 'app-last-achievements',
  templateUrl: './last-achievements.component.html',
  styleUrls: ['./last-achievements.component.scss']
})
export class LastAchievementsComponent {
  public achievements = [
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Turbo Power', xp: 15, granted: 0 },
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Turbo Power', xp: 15, granted: 2 },
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Skylark Power', xp: 20, granted: 10 },
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Corpo Power', xp: 25, granted: 23 },
  ];
  constructor(private readonly dialog: MatDialog) { }

  openDialog(): void {
    this.dialog.open(RequestAchievementComponent, { panelClass: 'request-dialog-container' });
  }
}
