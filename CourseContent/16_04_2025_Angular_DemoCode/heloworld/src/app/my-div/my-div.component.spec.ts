import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyDivComponent } from './my-div.component';

describe('MyDivComponent', () => {
  let component: MyDivComponent;
  let fixture: ComponentFixture<MyDivComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MyDivComponent]
    });
    fixture = TestBed.createComponent(MyDivComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
