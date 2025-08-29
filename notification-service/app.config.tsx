import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';

import { routes } from './app.routes';
import { NotificationService } from './service/notification.service';
import { Smsnotification } from './classes/smsnotification';
import { Emailnotification } from './classes/emailnotification';
import { Whataapnotification } from './classes/whataapnotification';
import { EMAIL_NOTIFICATION, SMS_NOTIFICATION, WHATSAPP_NOTIFICATION } from './factory/notification.injection';
import { emailNotificationFactory, smsNotificationFactory, whatsappNotificationFactory } from './factory/notification.factory';

export const appConfig: ApplicationConfig = {
  providers: [provideZoneChangeDetection({ eventCoalescing: true }), provideRouter(routes) , 
    {
      provide: SMS_NOTIFICATION,
      useFactory: smsNotificationFactory,
     
    },
    {
      provide: EMAIL_NOTIFICATION,
      useFactory: emailNotificationFactory,
    
    },
    {
      provide: WHATSAPP_NOTIFICATION,
      useFactory: whatsappNotificationFactory,

    },

  ]
};
