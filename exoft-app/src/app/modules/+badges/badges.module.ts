import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MaterialModule } from 'src/app/shared/material/material.module';

import { BadgesComponent } from './components/badges/badges.component';
import { LastAchievementsComponent } from './components/last-achievements/last-achievements.component';
import { TotalAchievementXpComponent } from './components/total-achievement-xp/total-achievement-xp.component';
import { UserComponent } from './components/user/user.component';
import { AchievementsListComponent } from './components/achievements-list/achievements-list.component';
import { ThanksComponent } from './components/thanks/thanks.component';

const routes = [
  {
    path: '',
    component: BadgesComponent,
  }
];

@NgModule({
  declarations: [
    BadgesComponent,
    LastAchievementsComponent,
    TotalAchievementXpComponent,
    UserComponent,
    AchievementsListComponent,
    ThanksComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    MaterialModule
  ]
})
export class BadgesModule { }
