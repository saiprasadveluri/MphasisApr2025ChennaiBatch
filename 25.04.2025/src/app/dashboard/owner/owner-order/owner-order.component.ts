import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { order } from '../../../interface';
import { DataService } from '../../../services/data.service';

@Component({
  selector: 'app-owner-order',
  imports: [NgFor],
  templateUrl: './owner-order.component.html',
  styleUrl: './owner-order.component.css'
})
export class OwnerOrderComponent {
orderList : order[] = []
    restaurantInfo : order[] =  []
      constructor(private dataServices : DataService){}
    
      ngOnInit(){
        this.getAllOrder();
      }
      getAllOrder(){
        this.dataServices.getOrdersList().subscribe((data)=>{
          console.log('all order details' , data);
          this.orderList = data;
    
        })
      
}
}
