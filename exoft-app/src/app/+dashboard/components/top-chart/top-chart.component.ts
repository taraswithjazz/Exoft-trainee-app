import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { UserAchievementsComponent } from 'src/app/shared/dialogs/user-achievements/user-achievements.component';

@Component({
  selector: 'app-top-chart',
  templateUrl: './top-chart.component.html',
  styleUrls: ['./top-chart.component.scss']
})
export class TopChartComponent implements OnInit {

  users = [
    { color: 'rgb(0,160,240)', xp: 123, name: 'Sadio', surname: 'Mane', size: '', avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg' },
    { color: 'rgb(172,0,207)', xp: 12, name: 'Bobby', surname: 'Firmino', size: '', avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg' },
    { color: 'rgb(236,146,0)', xp: 23, name: 'Mo', surname: 'Salah', size: '', avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg' },
    { color: 'rgb(0,241,236)', xp: 153, name: 'Ginni', surname: 'Wijnaldum', size: '', avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg' },
    { color: 'rgb(0,10,24)', xp: 2, name: 'Virgil', surname: 'Van Dijk', size: '', avatar: 'https://material.angular.io/assets/img/examples/shiba1.jpg' },
  ];

  total = 0;
  maxWidth = 160;

  constructor(private readonly dialog: MatDialog) { }

  ngOnInit(): void {
    this.showGraph();
  }

  openDialog(): void {
    this.dialog.open(UserAchievementsComponent, { panelClass: 'user-dialog-container' });
  }

  showGraph(): void {
    this.users.forEach(element => {
      this.total += element.xp;
    });

    this.users.forEach(element => {
      element.size = Math.round((element.xp * this.maxWidth) / this.total) + '%';
    });
  }
}
