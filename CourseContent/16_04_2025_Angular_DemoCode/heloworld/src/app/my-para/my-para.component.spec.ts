import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyParaComponent } from './my-para.component';

describe('MyParaComponent', () => {
  let component: MyParaComponent;
  let fixture: ComponentFixture<MyParaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MyParaComponent]
    });
    fixture = TestBed.createComponent(MyParaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
