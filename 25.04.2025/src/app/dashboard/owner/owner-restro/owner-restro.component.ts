import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { DataService } from '../../../services/data.service';
import { Restro } from '../../../interface';

@Component({
  selector: 'app-owner-restro',
  imports: [NgFor],
  templateUrl: './owner-restro.component.html',
  styleUrl: './owner-restro.component.css'
})
export class OwnerRestroComponent {

  ownerRestro: Restro[]  =  [

  ]
        constructor(private dataServices : DataService){}
      
        ngOnInit(){
          this.getAllOrder();
        }
        getAllOrder(){
          this.dataServices.getAllOwnerRestro().subscribe((data)=>{
            console.log('all owner restro details ' , data);
            this.ownerRestro = data;
      
          })
        
  }
}
