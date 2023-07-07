import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetstudentidComponent } from './getstudentid.component';

describe('GetstudentidComponent', () => {
  let component: GetstudentidComponent;
  let fixture: ComponentFixture<GetstudentidComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GetstudentidComponent]
    });
    fixture = TestBed.createComponent(GetstudentidComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
