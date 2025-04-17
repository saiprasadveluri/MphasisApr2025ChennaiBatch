import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyboxComponent } from './mybox.component';

describe('MyboxComponent', () => {
  let component: MyboxComponent;
  let fixture: ComponentFixture<MyboxComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MyboxComponent]
    });
    fixture = TestBed.createComponent(MyboxComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
