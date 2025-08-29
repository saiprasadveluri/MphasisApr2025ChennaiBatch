import { Component, Input } from '@angular/core';
import { User } from '../interface';

@Component({
  selector: 'app-user-list',
  imports: [],
  templateUrl: './user-list.component.html',
  styleUrl: './user-list.component.css'
})
export class UserListComponent {
  @Input() users:User | undefined  = {
    username : '' , 
    email : '' , 
    password  : '',
    id : ''
  }
  @Input() userList : User[] = [];
  @Input() deleteFn! : (user : User)=>void;
  @Input() selectedFn! : (user : User)=>void
}
