import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyRowComponent } from './my-row.component';

describe('MyRowComponent', () => {
  let component: MyRowComponent;
  let fixture: ComponentFixture<MyRowComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MyRowComponent]
    });
    fixture = TestBed.createComponent(MyRowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
