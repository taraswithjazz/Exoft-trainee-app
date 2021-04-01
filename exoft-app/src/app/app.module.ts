import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { MaterialModule } from './shared/material/material.module';
import { BrowserAnimationsModule, NoopAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { LayoutComponent } from './layout/layout.component';
import { RequestAchievementComponent } from './shared/dialogs/request-achievement/request-achievement.component';
import { UserAchievementsComponent } from './shared/dialogs/user-achievements/user-achievements.component';
import { SayThanksComponent } from './shared/dialogs/say-thanks/say-thanks.component';

@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    RequestAchievementComponent,
    UserAchievementsComponent,
    SayThanksComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NoopAnimationsModule,
    MaterialModule
  ],
  exports: [
    AppComponent,
    LayoutComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
