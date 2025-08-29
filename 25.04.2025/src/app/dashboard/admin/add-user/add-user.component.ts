import { Component, NgModule } from '@angular/core';
import { DataService } from '../../../services/data.service';
import { Router } from '@angular/router';
import { FormsModule } from '@angular/forms';



@Component({
  selector: 'app-add-user',
  imports: [FormsModule],
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AddUserComponent {
  email = '';
  password = '';
  role = 'User';
  location = '';
  name= ''

  constructor(private dataServices: DataService, private router: Router) {}
  addNewUser(){
    const newUser = {
      email : this.email ,
      password : this.password , 
      role : this.role ,
      location : this.location ,
      name : this.name
    }
    this.dataServices.AddNewUser(newUser).subscribe((data)=>{
      console.log("new user" , data);
    });
    this.dataServices.getAllUser();
    this.router.navigate(['/dashboard/admin/user-list']);
   
    


  }
}
