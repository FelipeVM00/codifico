import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-pseudo-search',
  templateUrl: './pseudo-search.component.html',
  styleUrls: ['./pseudo-search.component.scss']
})
export class PseudoSearchComponent implements OnInit {

  @Output() onSearch: EventEmitter<string> = new EventEmitter<string>();
  public searchString: string = '';

  constructor() { }

  ngOnInit(): void { }

  public search(): void {
    this.searchString !== '' && this.onSearch.emit(this.searchString);
  }

}
