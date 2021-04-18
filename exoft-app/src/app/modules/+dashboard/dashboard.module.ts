import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MaterialModule } from 'src/app/shared/material/material.module';
import { ApplicationPipesModule } from 'src/app/shared/pipes/application-pipes.module';

import { DashboardComponent } from './components/dashboard/dashboard.component';
import { GreetingsComponent } from './components/greetings/greetings.component';
import { ExoftAchievementsComponent } from './components/exoft-achievements/exoft-achievements.component';
import { PersonalAchievementsComponent } from './components/personal-achievements/personal-achievements.component';
import { ThanksComponent } from './components/thanks/thanks.component';
import { TopChartComponent } from './components/top-chart/top-chart.component';
import { BadgesComponent } from './components/badges/badges.component';
import { ChallengesComponent } from './components/challenges/challenges.component';

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
    MaterialModule,
    ApplicationPipesModule
  ]
})
export class DashboardModule { }
