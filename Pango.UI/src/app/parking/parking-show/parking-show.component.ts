import { ChangeDetectorRef, Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-parking-show',
  templateUrl: './parking-show.component.html',
  styleUrls: ['./parking-show.component.scss']
})
export class ParkingShowComponent implements OnInit, OnChanges {

  parkingList:any = [];
  citiesList:any = [];
  customersList:any = [];
  parkingZonesList :any = [];
  modalTitle:any;
  activateAddEditCusCom:boolean = false;
  parking:any;

  constructor(private ref: ChangeDetectorRef,private sharedService: SharedService) { }
  
  ngOnChanges(changes: SimpleChanges): void {
    this.refreshParkingList();
  }

  ngOnInit(): void {
    this.refreshParkingList();
  }


  refreshParkingList() {
    this.sharedService.getParkingList().subscribe(data =>{
      console.log(data);
      this.parkingList = data;
      this.ref.markForCheck();
    });

    this.sharedService.getCitiesList().subscribe(data =>{
      console.log(data);
      this.citiesList = data;
      this.ref.markForCheck();
    });

    this.sharedService.getCustomersList().subscribe(data =>{
      console.log(data);
      this.customersList = data;
      this.ref.markForCheck();
    });

    this.sharedService.getParkingZonesList().subscribe(data =>{
      console.log(data);
      this.parkingZonesList = data;
      this.ref.markForCheck();
    });
  }

  AddParking(){
    this.parking={
      Id: "",
      CustomerId:"",
      ParkingTime:"",
      CarNumber: "",
      PhoneNumber: "",
      Lat: "",
      Long: "",
      CityId: "",
      PhonePlatform: "",
    }
    this.modalTitle = "Add Parking";
    this.activateAddEditCusCom = true;
  }

  EditParking(item: any){
    this.parking = item;
    this.activateAddEditCusCom = true;
    this.modalTitle = "Update Parking";
  }

  deleteClick(item: any){
    if(confirm('Are you sure??')){
      this.sharedService.deleteParking(item.Id).subscribe(data =>{
        this.refreshParkingList();
      })
    }
  }

  closeClick(){
    this.activateAddEditCusCom=false;
    this.refreshParkingList();
  }
}
