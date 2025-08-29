import { Component, NgModule, OnInit } from '@angular/core';
import { DataService } from '../../../services/data.service';
import { ActivatedRoute, Router } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { User } from '../../../interface';



@Component({
  selector: 'app-edit-user',
  imports: [FormsModule],
  templateUrl: './edit-user.component.html',
  styleUrls: ['./edit-user.component.css']
})
export class EditUserComponent implements OnInit {
  user : User = {}
  constructor(private dataservice: DataService, private route: ActivatedRoute, private router: Router) {}

  ngOnInit() {
 
    const id = this.route.snapshot.paramMap.get('id');
    if(!id) return
    console.log('id of user to be edited' , id);
    this.dataservice.selectedUser(id).subscribe((data)=>{
      console.log("selected User for editing" , data);
      this.user = data;
      
    })
    
  }

  saveUser() {
    this.router.navigate(['/dashboard/admin/user-list']);
  }

}
