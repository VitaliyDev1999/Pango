import { ChangeDetectorRef, Component, Input, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-parking-add-edit',
  templateUrl: './parking-add-edit.component.html',
  styleUrls: ['./parking-add-edit.component.scss']
})
export class ParkingAddEditComponent implements OnInit {

  @Input() parking:any;
  @Input() customers: any = [];
  @Input() cities: any = [];
  @Input() parkingZones: any = [];
  Id:string = "";
  CustomerId: string ="";
  CityId: string = "";
  ParkingTime: string = (new Date()).toISOString();
  PhoneNumber: string = "";
  CarNumber: string = "";
  Lat: string = "";
  Long: string = "";
  PhonePlatform: string = "";
  ParkingZonesIds: any = [];

  constructor(private ref: ChangeDetectorRef, private service: SharedService) { }

  ngOnInit(): void {
    this.Id = this.parking.id;
    this.CustomerId = this.parking.customer?.id;
    this.CityId = this.parking.city?.id;
    this.PhoneNumber = this.parking.phoneNumber;
    this.ParkingTime = this.parking.parkingTime;
    this.CarNumber = this.parking.carNumber;
    this.Lat = this.parking.lat;
    this.Long = this.parking.long;
    this.ParkingZonesIds = this.parking.parkingZonesIds
  }

  addParking(){
    var val = {
      CustomerId: this.CustomerId,
      CityId: this.CityId,
      PhoneNumber: this.PhoneNumber,
      ParkingTime: new Date().toISOString(),
      CarNumber:this.CarNumber,
      Lat: this.Lat,
      Long: this.Long,
      ParkingZoneIdss: this.ParkingZonesIds
    };
      this.service.addParking(val).subscribe(res =>{
        this.ref.markForCheck();
      })
  }

  updateParking(){
    var val = {
      Id:this.Id,
      CustomerId: this.CustomerId,
      CityId: this.CityId,
      PhoneNumber: this.PhoneNumber,
      ParkingTime: this.ParkingTime,
      CarNumber:this.CarNumber,
      Lat: this.Lat,
      Long: this.Long,
      ParkingZoneIdss: this.ParkingZonesIds
    };
      this.service.updateParking(val).subscribe(res =>{
        this.ref.markForCheck();
    })
  }
}

