import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SubHeadingComponent } from './sub-heading.component';

describe('SubHeadingComponent', () => {
  let component: SubHeadingComponent;
  let fixture: ComponentFixture<SubHeadingComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SubHeadingComponent]
    });
    fixture = TestBed.createComponent(SubHeadingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
