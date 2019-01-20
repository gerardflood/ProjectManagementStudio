import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import Project from '../models/Project';

@Injectable()
export default class ProjectService {
  public API = 'http://localhost:56714/api/projects';

  constructor(private http: HttpClient) {}

  getAll(): Observable<Array<Project>> {
    return this.http.get<Array<Project>>(this.API);
  }

  save(Project: Project): Observable<Project> {
    let result: Observable<Project>;

    result = this.http.post<Project>(this.API, Project);

    return result;
  }
}