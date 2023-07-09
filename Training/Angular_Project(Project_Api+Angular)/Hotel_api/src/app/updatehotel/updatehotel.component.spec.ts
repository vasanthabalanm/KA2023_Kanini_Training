import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdatehotelComponent } from './updatehotel.component';

describe('UpdatehotelComponent', () => {
  let component: UpdatehotelComponent;
  let fixture: ComponentFixture<UpdatehotelComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UpdatehotelComponent]
    });
    fixture = TestBed.createComponent(UpdatehotelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
