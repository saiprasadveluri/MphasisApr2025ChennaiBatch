import { Component } from '@angular/core';

@Component({
  selector: 'app-main-heading',
  styleUrls: ['./main-heading.component.css'],
  template:'<h3>{{headingText}}</h3>'
})
export class MainHeadingComponent {
headingText:string="List Users";
}
