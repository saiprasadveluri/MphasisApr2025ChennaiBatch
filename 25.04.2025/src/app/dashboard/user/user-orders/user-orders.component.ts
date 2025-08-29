import { NgFor} from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-user-orders',
  imports: [NgFor],
  templateUrl: './user-orders.component.html',
  styleUrl: './user-orders.component.css'
})
export class UserOrdersComponent {

    userInfo = [
      { id: '1', email: 'admin@test.com', password: 'admin123', role: 'Admin' },
      { id: '2', email: 'owner@test.com', password: 'owner123', role: 'Owner' },
      { id: '3', email: 'user@test.com', password: 'user123', role: 'User' },
      { id: '4', email: 'user2@test.com', password: 'user123', role: 'User' },
      { id: '5', email: 'user3@test.com', password: 'user123', role: 'User' },
      { id: '6', email: 'user4@test.com', password: 'user123', role: 'User' }
    
  ]

}
