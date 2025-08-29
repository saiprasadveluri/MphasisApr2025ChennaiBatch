import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { order, Restro, User } from '../interface';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  userInfo = [
    { id: '1', email: 'admin@test.com', password: 'admin123', role: 'Admin' },
    { id: '2', email: 'owner@test.com', password: 'owner123', role: 'Owner' },
    { id: '3', email: 'user@test.com', password: 'user123', role: 'User' }
  ];

  restaurantInfo = [];
  menu = [];
  orders = [];
  orderline = [];


  constructor(
    private http: HttpClient
  ) { }

  getAllUser() {
    const url = 'http://localhost:3000/userInfo'
    return this.http.get<User[]>(url);

  }
  AddNewUser(userData: User) {
    const url = 'http://localhost:3000/userInfo'
    return this.http.post<User[]>(url, userData);
  }
  selectedUser(id: string) {
    const url = 'http://localhost:3000/userInfo'
    return this.http.get<User>(url + "/" + id);
  }
  updateUser(user: User): Observable<User> {
    const url = 'http://localhost:3000/userInfo'
    return this.http.put<User>(url + "/" + user.id, user
    );
  }
  // /---------------------Restaurant--------------------/

  getAllRestauro() {
    const url = 'http://localhost:3000/restaurantInfo'
    return this.http.get<Restro[]>(url);

  }
  AddNewRestro(restroData: Restro) {
    const url = 'http://localhost:3000/restaurantInfo'
    return this.http.post<Restro[]>(url, restroData);
  }

  // ------------------------Owner---------------------------

  getAllOwnerRestro() {
    const url = 'http://localhost:3000/restaurantInfo'
    return this.http.get<Restro[]>(url);

  }
  getOrdersList() {
    const url = 'http://localhost:3000/orders'
    return this.http.get<order[]>(url);
  }
  AddOrders(orderData: order) {
    const url = 'http://localhost:3000/orders'
    return this.http.post<order[]>(url, orderData);
  }


  

}
