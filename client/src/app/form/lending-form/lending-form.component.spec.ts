import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LendingFormComponent } from './lending-form.component';

describe('LendingFormComponent', () => {
  let component: LendingFormComponent;
  let fixture: ComponentFixture<LendingFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LendingFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LendingFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
