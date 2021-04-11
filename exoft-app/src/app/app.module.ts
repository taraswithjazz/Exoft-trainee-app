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
import { EditProfileComponent } from './shared/dialogs/edit-profile/edit-profile.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    RequestAchievementComponent,
    UserAchievementsComponent,
    SayThanksComponent,
    EditProfileComponent,
    SignInComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NoopAnimationsModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports: [
    AppComponent,
    LayoutComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
