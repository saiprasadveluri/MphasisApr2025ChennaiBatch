import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export abstract class NotificationService {
  abstract sendNotification(msg : string) : void ;
  
}
