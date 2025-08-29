import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-user-menu',
  imports: [NgFor],
  templateUrl: './user-menu.component.html',
  styleUrl: './user-menu.component.css'
})
export class UserMenuComponent {
  menuList =  [
    {
      id :  "1",
      rid : "1",
      dishname: "Dosa",
      dishtype: "VEG",
      price: 75.45
    },
    {
      id: "2",
      rid: "1",
      dishname: "Idli",
      dishtype: "VEG",
      price: 25
    },
    {
      id: "3",
      rid: "1",
      dishname: "Fried Rice",
      dishtype: "NON-VEG",
      price: 145.25
    }
  ]
}
