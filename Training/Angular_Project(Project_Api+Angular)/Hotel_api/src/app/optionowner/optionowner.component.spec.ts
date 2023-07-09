import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OptionownerComponent } from './optionowner.component';

describe('OptionownerComponent', () => {
  let component: OptionownerComponent;
  let fixture: ComponentFixture<OptionownerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [OptionownerComponent]
    });
    fixture = TestBed.createComponent(OptionownerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
