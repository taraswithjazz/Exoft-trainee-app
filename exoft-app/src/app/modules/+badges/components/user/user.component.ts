import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { EditProfileComponent } from 'src/app/shared/dialogs/edit-profile/edit-profile.component';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent {
  constructor(private readonly dialog: MatDialog) { }

  openDialog(): void {
    this.dialog.open(EditProfileComponent, { panelClass: 'edit-profile-dialog-container' });
  }
}
