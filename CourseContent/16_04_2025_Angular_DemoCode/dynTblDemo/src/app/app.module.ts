import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MyColumnComponent } from './my-column/my-column.component';
import { MyRowComponent } from './my-row/my-row.component';
import { MyDivComponent } from './my-div/my-div.component';

@NgModule({
  declarations: [
    AppComponent,
    MyColumnComponent,
    MyRowComponent,
    MyDivComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
