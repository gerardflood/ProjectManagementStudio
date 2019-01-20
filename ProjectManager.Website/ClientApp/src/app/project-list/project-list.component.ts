import { Component, OnInit } from '@angular/core';
import ProjectService from '../shared/api/project.service';
import Project from '../shared/models/Project';

@Component({
  selector: 'app-project-list',
  templateUrl: './project-list.component.html',
  styleUrls: ['./project-list.component.css']
})
export class ProjectListComponent implements OnInit {

  projects: Array<Project>;

  constructor(private projectService: ProjectService) { }

  ngOnInit() {
    this.projectService.getAll().subscribe(data => {
      this.projects = data;
    });
  }

}
