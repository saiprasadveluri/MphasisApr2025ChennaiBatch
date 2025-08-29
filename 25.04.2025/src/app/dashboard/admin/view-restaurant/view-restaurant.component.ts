import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { DataService } from '../../../services/data.service';
import { Restro } from '../../../interface';

@Component({
  selector: 'app-view-restaurant',
  imports: [NgFor],
  templateUrl: './view-restaurant.component.html',
  styleUrl: './view-restaurant.component.css'
})
export class ViewRestaurantComponent {
  restaurantInfo : Restro[] =  []
  constructor(private dataServices : DataService){}

  ngOnInit(){
    this.getAllRestaurant();
  }
  getAllRestaurant(){
    this.dataServices.getAllRestauro().subscribe((data)=>{
      console.log('all restro details' , data);
      this.restaurantInfo = data;

    })
  }


}
