import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MaterialModule } from 'src/app/shared/material/material/material.module';

import { DashboardComponent } from './dashboard.component';
import { GreetingsComponent } from './greetings/greetings.component';
import { ExoftAchievementsComponent } from './exoft-achievements/exoft-achievements.component';
import { PersonalAchievementsComponent } from './personal-achievements/personal-achievements.component';
import { ThanksComponent } from './thanks/thanks.component';
import { TopChartComponent } from './top-chart/top-chart.component';
import { BadgesComponent } from './badges/badges.component';
import { ChallengesComponent } from './challenges/challenges.component';

const routes = [
  {
    path: '',
    component: DashboardComponent,
  }
];

@NgModule({
  declarations: [
    DashboardComponent,
    GreetingsComponent,
    ExoftAchievementsComponent,
    PersonalAchievementsComponent,
    ThanksComponent,
    TopChartComponent,
    BadgesComponent,
    ChallengesComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    MaterialModule
  ]
})
export class DashboardModule { }
