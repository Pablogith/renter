import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'dashboard',
    pathMatch: 'full'
  },
  {
    path: 'calendar',
    loadComponent: () => import('./pages/calendar/calendar.component').then(c => c.CalendarComponent)
  },
  {
    path: 'dashboard',
    loadComponent: () => import('./pages/dashboard/dashboard.component').then(c => c.DashboardComponent)
  },
  {
    path: 'properties',
    loadComponent: () => import('./pages/properties/properties.component').then(c => c.PropertiesComponent)
  },
  {
    path: 'documents',
    loadComponent: () => import('./pages/documents/documents.component').then(c => c.DocumentsComponent)
  },
  {
    path: 'reports',
    loadComponent: () => import('./pages/reports/reports.component').then(c => c.ReportsComponent)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
