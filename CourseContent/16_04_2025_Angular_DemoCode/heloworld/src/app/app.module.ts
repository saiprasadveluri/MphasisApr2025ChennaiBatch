import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainHeadingComponent } from './main-heading/main-heading.component';
import { SubHeadingComponent } from './sub-heading/sub-heading.component';
import { MyParaComponent } from './my-para/my-para.component';
import { MyDivComponent } from './my-div/my-div.component';
import { MyRowComponent } from './my-row/my-row.component';
import { MyColumnComponent } from './my-column/my-column.component';

@NgModule({
  declarations: [
    AppComponent,
    MainHeadingComponent,
    SubHeadingComponent,
    MyParaComponent,
    MyDivComponent,
    MyRowComponent,
    MyColumnComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
