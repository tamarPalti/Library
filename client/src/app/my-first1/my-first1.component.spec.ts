import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyFirst1Component } from './my-first1.component';

describe('MyFirst1Component', () => {
  let component: MyFirst1Component;
  let fixture: ComponentFixture<MyFirst1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MyFirst1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MyFirst1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
