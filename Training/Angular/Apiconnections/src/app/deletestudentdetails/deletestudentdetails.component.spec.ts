import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletestudentdetailsComponent } from './deletestudentdetails.component';

describe('DeletestudentdetailsComponent', () => {
  let component: DeletestudentdetailsComponent;
  let fixture: ComponentFixture<DeletestudentdetailsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeletestudentdetailsComponent]
    });
    fixture = TestBed.createComponent(DeletestudentdetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
