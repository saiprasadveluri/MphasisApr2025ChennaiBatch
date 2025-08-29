import { Component } from '@angular/core';
import { DataService } from '../../../services/data.service';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { User } from '../../../interface';

@Component({
  selector: 'app-user-list',
  standalone : true,
  imports: [CommonModule],
  templateUrl: './user-list.component.html',
  styleUrl: './user-list.component.css'
})
export class UserListComponent {
  users: User[] = [
  ];
  constructor(private dataservice : DataService , private router :Router){

  }
  ngOnInit(){
    this.getUserList();
  }
  getUserList(){
    this.dataservice.getAllUser().subscribe((users)=>{
      console.log("all users" , users)
      this.users = users;
    })
  }
  editUser(userdata :User){
    this.router.navigate(['/dashboard/admin/edit-user', userdata.id]);
  }
 
}
