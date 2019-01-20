import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { HttpClientModule } from '@angular/common/http';
import {
  MatButtonModule,
  MatCardModule,
  MatInputModule,
  MatListModule,
  MatToolbarModule
} from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { Routes, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { ProjectListComponent } from './project-list/project-list.component';
import { ProjectAddComponent } from './project-add/project-add.component';
import ProjectService from './shared/api/project.service';

const appRoutes: Routes = [
  { path: '', redirectTo: '/project-list', pathMatch: 'full' },
  {
    path: 'project-list',
    component: ProjectListComponent
  },
  {
    path: 'project-add',
    component: ProjectAddComponent
  }
];

@NgModule({
  declarations: [
    AppComponent,
    ProjectListComponent,
    ProjectAddComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    MatButtonModule,
    MatCardModule,
    MatInputModule,
    MatListModule,
    MatToolbarModule,
    BrowserAnimationsModule,
    FormsModule,
    RouterModule.forRoot(appRoutes),
  ],
  providers: [ProjectService],
  bootstrap: [AppComponent]
})
export class AppModule { }
