import { Component, computed, Optional, Signal, signal, WritableSignal } from '@angular/core';
import { ActivatedRoute, RouterLink, RouterOutlet } from '@angular/router';
import { MaincompComponent } from './maincomp/maincomp.component';
import { CounterAppComponent } from './counter-app/counter-app.component';
import { LearningComponent } from './learning/learning.component';
import { DynamicRoutingComponent } from './dynamic-routing/dynamic-routing.component';
import { UsercomponentComponent } from './usercomponent/usercomponent.component';
import { NotificationService } from './service/notification.service';
import { Smsnotification } from './classes/smsnotification';
import { Emailnotification } from './classes/emailnotification';
import { Whataapnotification } from './classes/whataapnotification';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-root',
  standalone : true ,
  imports: [RouterOutlet , RouterLink ,FormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent {
title :string | null = '' ;
// // message : string = "";
// // receiveMessage ($event : string){
// //   this.message = $event;
// //   console.log("i am from parent" , this.message);

// // }
// datafromChild : string = "";
// parenFunction($event :string){
//   this.datafromChild = $event;
//   console.log('calling from parent component')
// }
notifiedMe : string | undefined = "email";
notification : string | undefined ; 
inputdata : string= '';
// constructor(private smsManager : Smsnotification , 
//  private emailManager : Emailnotification,
//  private whatAppManager : Whataapnotification
  
// ){

// }
constructor(
  @Optional() private smsManager: Smsnotification,
  @Optional() private emailManager: Emailnotification,
  @Optional() private whatAppManager: Whataapnotification
) {}

notify(){

  if(this.inputdata === 'sms'){
    this.notification = this.smsManager.sendNotification('SMS Notification');
  }
  else if(this.inputdata === 'email'){
    this.notification = this.emailManager.sendNotification('Email Notification');
  }
  else if(this.inputdata === 'whataap'){
   this.notification =  this.whatAppManager.sendNotification('whatApp Notification');
  }
  else{
    this.notification =  this.whatAppManager.sendNotification('whatApp Notification');
  }
}

}
