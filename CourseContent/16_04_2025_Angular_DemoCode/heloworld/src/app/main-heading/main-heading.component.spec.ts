import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MainHeadingComponent } from './main-heading.component';

describe('MainHeadingComponent', () => {
  let component: MainHeadingComponent;
  let fixture: ComponentFixture<MainHeadingComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MainHeadingComponent]
    });
    fixture = TestBed.createComponent(MainHeadingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
