import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HotelstaffLoginComponent } from './hotelstaff-login.component';

describe('HotelstaffLoginComponent', () => {
  let component: HotelstaffLoginComponent;
  let fixture: ComponentFixture<HotelstaffLoginComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HotelstaffLoginComponent]
    });
    fixture = TestBed.createComponent(HotelstaffLoginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
