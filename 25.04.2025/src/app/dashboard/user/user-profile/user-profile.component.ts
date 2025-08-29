import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-user-profile',
  imports: [FormsModule],
  templateUrl: './user-profile.component.html',
  styleUrl: './user-profile.component.css'
})
export class UserProfileComponent {
   user   = {
    name : "nishika" , 
    role : "owner" , 
    email : "nishika@gmail.com",
    address : "navalur"

  } 
  editProfile(){
    console.log("editig done")
  }
}
