import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ParkingShowComponent } from './parking-show.component';

describe('ParkingShowComponent', () => {
  let component: ParkingShowComponent;
  let fixture: ComponentFixture<ParkingShowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ParkingShowComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ParkingShowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
