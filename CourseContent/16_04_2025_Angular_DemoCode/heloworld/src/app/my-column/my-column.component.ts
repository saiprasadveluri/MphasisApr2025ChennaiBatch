import { Component, Input } from '@angular/core';

@Component({
  selector: '[app-my-column]',
  templateUrl: './my-column.component.html',
  styleUrls: ['./my-column.component.css']
})
export class MyColumnComponent {
@Input()Fldvalue:string='';
}
