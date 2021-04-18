import { Component, Input } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { EditProfileComponent } from '../../shared/dialogs/edit-profile/edit-profile.component';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.scss']
})
export class LayoutComponent {
  @Input() opened = false;

  constructor(private readonly dialog: MatDialog) { }

  openDialog(): void {
    this.dialog.open(EditProfileComponent, { panelClass: 'edit-profile-dialog-container' });
  }
}
