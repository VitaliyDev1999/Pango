import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Pango.UI';

  constructor(private router: Router) {

  }

  btnClickCustomer =  () => {
    this.router.navigateByUrl('/customer');
  };

  btnClickParking =  () => {
    this.router.navigateByUrl('/parking');
  };
}
