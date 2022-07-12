import { Component, OnInit } from '@angular/core';
import { take } from 'rxjs';
import { GitHubUser } from './interfaces/github-user-interface';
import { GithubApiService } from './services/github-api.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  public githubUser!: GitHubUser;
  public showError: boolean = false;

  constructor(private githubApiService: GithubApiService) { }

  searchUser(user: string) {
    this.showError = false;
    this.githubApiService.getUser(user)
      .pipe(take(1))
      .subscribe(
        {
          next: (userRes: GitHubUser) => this.githubUser = userRes,
          error: () => this.showError = true
        }
      );
  }

}
