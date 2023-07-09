import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletestaffComponent } from './deletestaff.component';

describe('DeletestaffComponent', () => {
  let component: DeletestaffComponent;
  let fixture: ComponentFixture<DeletestaffComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeletestaffComponent]
    });
    fixture = TestBed.createComponent(DeletestaffComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
