import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SignInComponent } from './sign-in/sign-in.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'sign-in',
    pathMatch: 'full'
  },
  {
    path: 'sign-in', component: SignInComponent
  },
  {
    path: 'dashboard',
    loadChildren: () => import('./+dashboard/dashboard.module').then(module => module.DashboardModule)
  },
  {
    path: 'badges',
    loadChildren: () => import('./+badges/badges.module').then(module => module.BadgesModule)
  },
  { path: '**', redirectTo: 'dashboard' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
