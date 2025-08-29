import { Component, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { User } from './interface';
import { UserserviceService } from './serice/userservice.service';
import { UserListComponent } from './user-list/user-list.component';
import { FormFillingComponent } from './form-filling/form-filling.component';

@Component({
  selector: 'app-root',
  imports: [FormsModule,UserListComponent , FormFillingComponent ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  standalone :true
})

export class AppComponent {
  title = 'formDemo';
  #formdata="ngForm" 
  selectedUser : User | undefined ; 

  userArray : User[] = []
  constructor( private userServices : UserserviceService){

  }
  ngOnInit(){
    this.getUserDetails();
  }
  getUserDetails = ()=>{
    debugger;
    this.userServices.getUserList().subscribe((data)=>{
      this.userArray = data;
      console.log("arrayList" , this.userArray)
    })
  }
  AddUser =  (formdata : User)=>{
    if(!this.selectedUser){
      this.userServices.addUser(formdata).subscribe((data)=>{
        console.log("new data added" , formdata);
        this.userArray.push(formdata);
        this.getUserDetails();
      })
    }
    else{
      const prevdata = {...formdata , id : this.selectedUser.id}
      console.log("updating user" , formdata);
      this.userServices.updateUser(prevdata).subscribe((data)=>{
        console.log("after update" , data);
        this.getUserDetails();
      })
    }
  }
  onDelete = (formdata : User)=>{
    console.log("delting",formdata);
    console.log("user" ,formdata);
    this.userServices.deleteUser(formdata).subscribe((data)=>{
      console.log("user is deleted" , data);
      this.getUserDetails();
    })
  }
  onSelected = (formdata:User)=>{
    this.userServices.selectedUser(formdata).subscribe((data)=>{
      console.log("selecteduser", data);
      this.selectedUser = data;
    })


  }
}
