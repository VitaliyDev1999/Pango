import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CustomerComponent } from './customer/customer.component';
import { ParkingComponent } from './parking/parking.component';
import { SharedService } from './shared.service';
import { ParkingShowComponent } from './parking/parking-show/parking-show.component';
import { ParkingAddEditComponent } from './parking/parking-add-edit/parking-add-edit.component';
import { CustomerShowComponent } from './customer/customer-show/customer-show.component';
import { CustomerAddEditComponent } from './customer/customer-add-edit/customer-add-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    CustomerComponent,
    ParkingComponent,
    ParkingAddEditComponent,
    ParkingShowComponent,
    CustomerShowComponent,
    CustomerAddEditComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
