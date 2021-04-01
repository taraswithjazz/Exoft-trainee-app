import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { SayThanksComponent } from '../say-thanks/say-thanks.component';

@Component({
  selector: 'app-user-achievements',
  templateUrl: './user-achievements.component.html',
  styleUrls: ['./user-achievements.component.css']
})
export class UserAchievementsComponent {

  constructor(public dialog: MatDialog) { }

  openDialog(): void {
    this.dialog.open(SayThanksComponent);
  }

}
