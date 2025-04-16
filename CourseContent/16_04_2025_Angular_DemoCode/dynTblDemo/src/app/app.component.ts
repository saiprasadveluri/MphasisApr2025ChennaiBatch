import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {  
  MainTblData:any[]=[['001','Sai','Hyderabad'],['002','Mary','Chennai']];//Array1 of Arrays
  MainTblData2:any[]=[['001','Sai','Hyderabad'],['002','Mary','Chennai']];//Array2 of Arrays
}
