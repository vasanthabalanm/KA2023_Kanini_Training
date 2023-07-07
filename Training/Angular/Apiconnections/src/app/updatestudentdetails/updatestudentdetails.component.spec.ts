import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdatestudentdetailsComponent } from './updatestudentdetails.component';

describe('UpdatestudentdetailsComponent', () => {
  let component: UpdatestudentdetailsComponent;
  let fixture: ComponentFixture<UpdatestudentdetailsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UpdatestudentdetailsComponent]
    });
    fixture = TestBed.createComponent(UpdatestudentdetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
