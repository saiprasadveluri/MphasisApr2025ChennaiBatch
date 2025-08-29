import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OwnerRestroComponent } from './owner-restro.component';

describe('OwnerRestroComponent', () => {
  let component: OwnerRestroComponent;
  let fixture: ComponentFixture<OwnerRestroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [OwnerRestroComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OwnerRestroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
