import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PseudoSearchComponent } from './pseudo-search.component';

describe('PseudoSearchComponent', () => {
  let component: PseudoSearchComponent;
  let fixture: ComponentFixture<PseudoSearchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PseudoSearchComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PseudoSearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
