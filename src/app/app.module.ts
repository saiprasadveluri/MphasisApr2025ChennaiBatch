import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './header/header.component';
import { VisitorListingComponent } from './visitor-listing/visitor-listing.component';
import { AddVisitorComponent } from './add-visitor/add-visitor.component';
import { NavigationComponentComponent } from './navigation-component/navigation-component.component';
import { FormsModule } from '@angular/forms';
import { MyTestComponent } from './my-test/my-test.component';
import { MyboxComponent } from './mybox/mybox.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    VisitorListingComponent,
    AddVisitorComponent,
    NavigationComponentComponent,
    MyTestComponent,
    MyboxComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
