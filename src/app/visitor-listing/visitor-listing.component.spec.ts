import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VisitorListingComponent } from './visitor-listing.component';

describe('VisitorListingComponent', () => {
  let component: VisitorListingComponent;
  let fixture: ComponentFixture<VisitorListingComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [VisitorListingComponent]
    });
    fixture = TestBed.createComponent(VisitorListingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
