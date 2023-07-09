import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletehotelComponent } from './deletehotel.component';

describe('DeletehotelComponent', () => {
  let component: DeletehotelComponent;
  let fixture: ComponentFixture<DeletehotelComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeletehotelComponent]
    });
    fixture = TestBed.createComponent(DeletehotelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
