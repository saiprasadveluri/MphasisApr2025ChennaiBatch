import { Component } from '@angular/core';

@Component({
  selector: 'app-my-test',
  templateUrl: './my-test.component.html',
  styleUrls: ['./my-test.component.css']
})
export class MyTestComponent {
  showDiv: boolean = true;
  textDiv: boolean = false;
  
  newCricName: string = '';

  INDCricket: string[] = ['Dhoni', 'Kohli', 'Rohit', 'Rahul','Shami'];
  // ind: number = this.INDCricket.length;
  onClick() {
    this.showDiv = !this.showDiv;
  }
  AddNewEntry(){
    this.textDiv = false;
    var x = this.INDCricket.find((nm) => nm.toUpperCase() == this.newCricName.toUpperCase());
    // this.INDCricket.push(this.newCricName);
    if(x!=undefined){
      this.textDiv=true;
    }
    else{
      this.INDCricket.push(this.newCricName);
    }
  }
  RemoveItem(ind: number){
    this.INDCricket.splice(ind, 1);
  }
}
