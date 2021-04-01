import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { UserAchievementsComponent } from 'src/app/shared/dialogs/user-achievements/user-achievements.component';

@Component({
  selector: 'app-thanks',
  templateUrl: './thanks.component.html',
  styleUrls: ['./thanks.component.css']
})
export class ThanksComponent {
  constructor(public dialog: MatDialog) { }

  openDialog(): void {
    this.dialog.open(UserAchievementsComponent);

  }
}
