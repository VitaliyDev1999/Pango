import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ParkingAddEditComponent } from './parking-add-edit.component';

describe('ParkingAddEditComponent', () => {
  let component: ParkingAddEditComponent;
  let fixture: ComponentFixture<ParkingAddEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ParkingAddEditComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ParkingAddEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
