import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class SharedService {
    readonly APIUrl = "https://localhost:7264/api";
    constructor(private http: HttpClient) {}

    getCustomersList(): Observable < any[] > {
        return this.http.get < any > (this.APIUrl + '/Customer');
    }

    addCustomer(val: any) {
        return this.http.post(this.APIUrl + '/Customer', val);
    }
    updateCustomer(val: any) {
        return this.http.patch(this.APIUrl + '/Customer', val);
    }
    deleteCustomer(id: any) {
        return this.http.delete(this.APIUrl + '/Customer/' + id);
    }

    getParkingList(): Observable < any[] > {
        return this.http.get < any > (this.APIUrl + '/Parking');
    }

    addParking(val: any) {
        return this.http.post(this.APIUrl + '/Parking', val);
    }
    updateParking(val: any) {
        return this.http.patch(this.APIUrl + '/Parking', val);
    }
    deleteParking(id: any) {
        return this.http.delete(this.APIUrl + '/Parking/' + id);
    }

    getParkingZonesList(): Observable < any[] > {
        return this.http.get < any > (this.APIUrl + '/ParkingZone');
    }

    getCitiesList(): Observable < any[] > {
        return this.http.get < any > (this.APIUrl + '/City');
    }
}