import { Component } from '@angular/core';

@Component({
  selector: 'app-customer-details',
  templateUrl: './customer-details.component.html',
  styleUrls: ['./customer-details.component.css']
})
export class CustomerDetailsComponent {

  customers = [
    { id: '001', name: 'Shri', location: 'Hari' },
    { id: '002', name: 'Hari', location: 'Shri' }
  ];

  // Temporary object to bind form inputs
  newCustomer = {
    id: '',
    name: '',
    location: ''
  };

  addCustomer() {
    if (this.newCustomer.id && this.newCustomer.name && this.newCustomer.location) {
      this.customers.push({ ...this.newCustomer });
      // Clear form
      this.newCustomer = { id: '', name: '', location: '' };
    }
  }

}
