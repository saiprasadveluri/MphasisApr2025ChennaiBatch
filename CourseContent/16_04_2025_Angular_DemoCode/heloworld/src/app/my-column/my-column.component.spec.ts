import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyColumnComponent } from './my-column.component';

describe('MyColumnComponent', () => {
  let component: MyColumnComponent;
  let fixture: ComponentFixture<MyColumnComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MyColumnComponent]
    });
    fixture = TestBed.createComponent(MyColumnComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
