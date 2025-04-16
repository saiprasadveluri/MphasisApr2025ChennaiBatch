import { Component,Input } from '@angular/core';

@Component({
  selector: 'app-my-div',
  templateUrl: './my-div.component.html',
  styleUrls: ['./my-div.component.css']
})
export class MyDivComponent {
  @Input()TblData:any[]=[]//[['row-1-col-1','row-1-col-2','row-1-col-3'],['row-2-col-1','row-2-col-2','row-2-col-3']];
}
