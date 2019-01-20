import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs/Subscription';
import { ActivatedRoute, Router } from '@angular/router';
import { NgForm } from '@angular/forms';

import ProjectService from '../shared/api/project.service';
import Project from '../shared/models/Project';

@Component({
  selector: 'app-project-add',
  templateUrl: './project-add.component.html',
  styleUrls: ['./project-add.component.css']
})
export class ProjectAddComponent implements OnInit {
  project: Project = new Project();

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private projectService: ProjectService
  ) {}

  ngOnInit() {
  }

  gotoList() {
    this.router.navigate(['/project-list']);
  }

  save(form: any) {
    this.projectService.save(form).subscribe(
      result => {
        this.gotoList();
      },
      error => console.error(error)
    );
  }
}
