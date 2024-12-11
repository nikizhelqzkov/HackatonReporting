import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module'; // Optional
import { AppComponent } from './app.component';
import { ReportingGridComponent } from './reporting-grid/reporting-grid.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { TableModule } from 'primeng/table';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { MultiSelectModule } from 'primeng/multiselect';
import { ButtonModule } from 'primeng/button';

@NgModule({
  declarations: [
    AppComponent, // Main AppComponent
    ReportingGridComponent, // ReportingGridComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    AppRoutingModule,
    TableModule,
    FormsModule,
    MultiSelectModule,
    CommonModule,
    ButtonModule
  ],
  providers: [],
  bootstrap: [AppComponent], // Root component to bootstrap
})
export class AppModule {}
