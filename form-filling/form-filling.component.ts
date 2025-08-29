import { Component, Input } from '@angular/core';
import { User } from '../interface';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-form-filling',
  imports: [FormsModule],
  templateUrl: './form-filling.component.html',
  styleUrl: './form-filling.component.css'
})
export class FormFillingComponent {

  @Input() users:User | undefined  = {
    username : '' , 
    email : '' , 
    password  : '',
    id : ''
  }
  @Input() addFn!:(user: User)=>void 


}
