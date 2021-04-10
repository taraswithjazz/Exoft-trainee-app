import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { UserAchievementsComponent } from 'src/app/shared/dialogs/user-achievements/user-achievements.component';

@Component({
  selector: 'app-thanks',
  templateUrl: './thanks.component.html',
  styleUrls: ['./thanks.component.scss']
})
export class ThanksComponent {
  constructor(private readonly dialog: MatDialog) { }

  openDialog(): void {
    this.dialog.open(UserAchievementsComponent, { panelClass: 'user-dialog-container' });
  }
}
