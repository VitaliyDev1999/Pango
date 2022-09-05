import { ChangeDetectorRef, Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-customer-show',
  templateUrl: './customer-show.component.html',
  styleUrls: ['./customer-show.component.scss']
})
export class CustomerShowComponent implements OnInit, OnChanges {

  customerList:any = [];
  modalTitle:any;
  activateAddEditCusCom:boolean = false;
  customer:any;

  constructor(private ref: ChangeDetectorRef,private sharedService: SharedService) { }
  
  ngOnChanges(changes: SimpleChanges): void {
    this.refreshCustomerList();
  }

  ngOnInit(): void {
    this.refreshCustomerList();
  }


  refreshCustomerList() {
    this.sharedService.getCustomersList().subscribe(data =>{
      this.customerList = data;
      this.ref.markForCheck();
    });
  }

  AddCustomer(){
    this.customer={
      Id: "",
      FirstName:"",
      SecondName:"",
      Email: "",
      PhoneNumber: "",
    }
    this.modalTitle = "Add Customer";
    this.activateAddEditCusCom = true;
  }

  EditCustomer(item: any){
    this.customer = item;
    this.activateAddEditCusCom = true;
    this.modalTitle = "Update Customer";
  }

  deleteClick(item: any){
    if(confirm('Are you sure??')){
      this.sharedService.deleteCustomer(item.Id).subscribe(data =>{
        this.refreshCustomerList();
      })
    }
  }

  closeClick(){
    this.activateAddEditCusCom=false;
    this.refreshCustomerList();
  }
}
