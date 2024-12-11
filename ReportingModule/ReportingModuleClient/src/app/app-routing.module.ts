import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ReportingGridComponent } from './reporting-grid/reporting-grid.component';

const routes: Routes = [
  { path: 'reporting-grid', component: ReportingGridComponent },
  { path: '', redirectTo: 'reporting-grid', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
