import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { SayThanksComponent } from '../say-thanks/say-thanks.component';

@Component({
  selector: 'app-user-achievements',
  templateUrl: './user-achievements.component.html',
  styleUrls: ['./user-achievements.component.scss']
})
export class UserAchievementsComponent {

  public achievements = [
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Turbo Power', xp: 15, granted: 0, count: 2 },
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Turbo Power', xp: 15, granted: 2, count: 3 },
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Skylark Power', xp: 20, granted: 10, count: 2 },
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Turbo Power', xp: 15, granted: 2, count: 8 },
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Corpo Power', xp: 25, granted: 23, count: 2 },
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Corpo Power', xp: 25, granted: 23, count: 0 },
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Turbo Power', xp: 15, granted: 2, count: 1 },
    { avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg', title: 'Exoft Skylark Power', xp: 20, granted: 10, count: 2 }
  ];

  constructor(private readonly dialog: MatDialog) { }

  openDialog(): void {
    this.dialog.open(SayThanksComponent, { panelClass: 'thanks-dialog-container', autoFocus: false });
  }

}
