import { Component,Input } from '@angular/core';

@Component({
  selector: 'app-my-para',
  templateUrl: './my-para.component.html',
  styleUrls: ['./my-para.component.css']
})
export class MyParaComponent {
@Input() Content:string=''
@Input() mainHeadingValue:string=''
@Input() subHeadingValue:string=''
}
