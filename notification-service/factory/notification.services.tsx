import { Emailnotification } from "../classes/emailnotification";
import { Smsnotification } from "../classes/smsnotification";
import { Whataapnotification } from "../classes/whataapnotification";

export function smsNotificationFactory(notifyType : string ) {
    return notifyType == 'sms' ? new Smsnotification() : null;
  }
  
  export function emailNotificationFactory(notifyType : string ) {
    return notifyType == 'email' ? new Emailnotification() : null;
  }
  
  export function whatsappNotificationFactory(notifyType : string ) {
    return notifyType == 'whataap' ? new Whataapnotification() : null;
  }
  
