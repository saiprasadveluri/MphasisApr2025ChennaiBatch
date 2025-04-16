import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-my-div',
  templateUrl: './my-div.component.html',
  styleUrls: ['./my-div.component.css']
})
export class MyDivComponent {
@Input()TblData:any;
}
