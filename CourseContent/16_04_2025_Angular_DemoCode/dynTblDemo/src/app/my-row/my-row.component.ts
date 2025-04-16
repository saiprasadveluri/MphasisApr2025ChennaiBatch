import { Component, Input } from '@angular/core';

@Component({
  selector: '[app-my-row]',
  templateUrl: './my-row.component.html',
  styleUrls: ['./my-row.component.css']
})
export class MyRowComponent {
@Input()ArrColValues:any[]=[];
}
