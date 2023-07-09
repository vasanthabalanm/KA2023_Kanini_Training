import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StaffownerComponent } from './staffowner.component';

describe('StaffownerComponent', () => {
  let component: StaffownerComponent;
  let fixture: ComponentFixture<StaffownerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [StaffownerComponent]
    });
    fixture = TestBed.createComponent(StaffownerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
