import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MaterialModule } from 'src/app/shared/material/material.module';

import { BadgesComponent } from './badges/badges.component';
import { LastAchievementsComponent } from './last-achievements/last-achievements.component';
import { TotalAchievementXpComponent } from './total-achievement-xp/total-achievement-xp.component';
import { UserComponent } from './user/user.component';
import { AchievementsListComponent } from './achievements-list/achievements-list.component';
import { ThanksComponent } from './thanks/thanks.component';

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
