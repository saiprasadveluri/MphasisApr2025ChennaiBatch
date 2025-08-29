import { Injectable } from "@angular/core";
import { NotificationService } from "../service/notification.service";


@Injectable({
    providedIn : 'root'
})
export class Smsnotification extends NotificationService{
    override sendNotification(msg: string): string  {
          return `Your substring to  : ${msg}`
       
    }
}
