import { Component } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { DataService } from '../../services/data.service';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  imports: [CommonModule , FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  email = '' ;
  password  = '';
  errorMsg  = ''

  constructor(
    private auth :AuthService,
    private data : DataService , 
    private router :Router
  ){}

login(){
  const user = this.data.userInfo.find((elem)=> elem.email  === this.email && elem.password === this.password);
  if(user){
    this.auth.login(user);
    this.router.navigate([`/dashboard/${user.role.toLowerCase()}`])
  }
  else{
    this.errorMsg = 'invalid credential'
  }

}  


}
