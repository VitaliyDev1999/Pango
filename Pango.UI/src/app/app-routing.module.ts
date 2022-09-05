import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerComponent } from './customer/customer.component';
import { ParkingComponent } from './parking/parking.component';

const routes: Routes = [
  {path:'customer', component:CustomerComponent},
  {path:'parking', component:ParkingComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
