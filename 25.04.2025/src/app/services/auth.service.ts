import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  login(user:any){
    localStorage.setItem('user' ,JSON.stringify(user))

  }
  logout(){
    localStorage.removeItem('user')
  }

  getUser() : any {
    return  JSON.parse(localStorage.getItem('user') || 'null');
  }
  isLoggedIn() : boolean{
    return !!this.getUser();

  }
  hasRole(allowedRole :string[]):boolean{

    const user = this.getUser();
    return user && allowedRole.includes(user.role)

  }
}
