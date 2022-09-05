import { ChangeDetectorRef, Component, Input, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-customer-add-edit',
  templateUrl: './customer-add-edit.component.html',
  styleUrls: ['./customer-add-edit.component.scss']
})
export class CustomerAddEditComponent implements OnInit {

  @Input() customer:any;
  Id:string = "";
  FirstName: string ="";
  LastName: string = "";
  Email: string ="";
  PhoneNumber: string = "";

  constructor(private ref: ChangeDetectorRef, private service: SharedService) { }

  ngOnInit(): void {
    this.Id = this.customer.id;
    this.FirstName = this.customer.firstName;
    this.LastName = this.customer.lastName,
    this.PhoneNumber = this.customer.phoneNumber,
    this.Email = this.customer.email;
  }

  addCustomer(){
    var val = {
      FirstName:this.FirstName,
      LastName:this.LastName,
      PhoneNumber: this.PhoneNumber,
      Email:this.Email
    };
      this.service.addCustomer(val).subscribe(res =>{
        this.ref.markForCheck();
      })
  }

  updateCustomer(){
    var val = {
      Id:this.Id,
      FirstName:this.FirstName,
      LastName:this.LastName,
      Email:this.Email,
      PhoneNumber: this.PhoneNumber
    };
      this.service.updateCustomer(val).subscribe(res =>{
        this.ref.markForCheck();
    })
  }
}
