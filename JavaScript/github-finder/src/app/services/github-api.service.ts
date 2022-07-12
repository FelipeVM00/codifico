import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { GitHubUser } from '../interfaces/github-user-interface';

@Injectable({
  providedIn: 'root'
})
export class GithubApiService {

  constructor(private httpClient: HttpClient) { }

  public getUser(userName: string): Observable<GitHubUser> {
    return this.httpClient.get<GitHubUser>(
      `${environment.githubApiUrl}/${userName}`
    );
  }
}
