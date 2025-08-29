import { Injectable } from '@angular/core';
import { User } from '../interface';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserserviceService {
  userList: User[] = [];
  userInfo: User | undefined;
  constructor(private http: HttpClient) {}
  url: string = 'http://localhost:3000/user';
  getUserList(): Observable<User[]> {
    return this.http.get<User[]>(this.url);
  }
  addUser(userdata: User): Observable<User> {
    return this.http.post<User>(this.url, userdata);
  }

  deleteUser(userdata: User): Observable<User> {
    return this.http.delete<User>(this.url + '/' + userdata.id);
  }
  selectedUser(userdata : User): Observable<User> {
    return this.http.get<User>(this.url+ '/' + userdata.id);
  }
  updateUser(userdata: User): Observable<User> {
    return this.http.put<User>(this.url + '/' + userdata.id, userdata);
  }
}
