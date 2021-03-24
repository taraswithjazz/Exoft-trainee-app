import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BadgesComponent } from './badges.component';
import { RouterModule } from '@angular/router';
import { MaterialModule } from 'src/app/shared/material/material/material.module';

const routes = [
  {
    path: '',
    component: BadgesComponent,
  }
];

@NgModule({
  declarations: [BadgesComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    MaterialModule
  ]
})
export class BadgesModule { }
