import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { StudentComponent } from './student.component';

describe('StudentComponent', () => {
  let component: StudentComponent;
  let fixture: ComponentFixture<StudentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [StudentComponent],
      imports: [FormsModule, ReactiveFormsModule]
    });
    fixture = TestBed.createComponent(StudentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  it(`should have title`, () => {
    const fixture = TestBed.createComponent(StudentComponent);
    const app = fixture.componentInstance;
    expect(app.title).toEqual('StudComp');
  });
  it('should have empty student properties on initialization', () => {
    expect(component.student.name).toEqual('');
    expect(component.student.age).toEqual(0);
    expect(component.student.grade).toEqual('');
  });

  it('should set student properties correctly when form values change', async () => {
    //assign
    const nameInput: HTMLInputElement = fixture.nativeElement.querySelector('.nameid');
    const ageInput: HTMLInputElement = fixture.nativeElement.querySelector('#ageid');
    const gradeInput: HTMLInputElement = fixture.nativeElement.querySelector('#gradeid');

    //ACT
    await fixture.whenStable();

    nameInput.value = 'John Doe';
    nameInput.dispatchEvent(new Event('input'));
    await fixture.whenStable();

    ageInput.value = '18';
    ageInput.dispatchEvent(new Event('input'));
    await fixture.whenStable();

    gradeInput.value = 'A';
    gradeInput.dispatchEvent(new Event('input'));

    fixture.detectChanges();
    fixture.detectChanges();
    fixture.detectChanges();

    //assert
    expect(component.student.name).toEqual('John Doe');
    expect(component.student.age).toEqual(18);
    expect(component.student.grade).toEqual('A');
  });

  it('should call submitForm method when form is submitted', () => {
    //assign
    spyOn(component, 'submitForm');

    const form = fixture.nativeElement.querySelector('form');
    //act
    form.dispatchEvent(new Event('submit'));

    fixture.detectChanges();


    //assert
    expect(component.submitForm).toHaveBeenCalled();

    expect(component.student.name).toEqual('');
    expect(component.student.age).toEqual(0);
    expect(component.student.grade).toEqual('');
  });
});
