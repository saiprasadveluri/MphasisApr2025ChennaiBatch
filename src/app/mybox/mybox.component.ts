import { Component } from '@angular/core';
import { VisitorList } from '../visitor-list';

@Component({
  selector: 'app-mybox',
  templateUrl: './mybox.component.html',
  styleUrls: ['./mybox.component.css']
})
export class MyboxComponent {
  
  visLId:string = '';
  visLName:string = '';
  visLDate:string = '';
  visLTime:string = '';
  showBox:boolean = false;
  visitor_list: VisitorList[] = [];
  addNewVisitor(){
  var temp:VisitorList= {
    visitorId: this.visLId,
    visitorName: this.visLName,
    visitorDate: this.visLDate,
    visitorTime: this.visLTime

  }
  // this.showBox = false;
  // if (this.visitor_list.length == 0){
  //   this.showBox = true;

  // }
  // else{
    this.visitor_list.push(temp);
    //}
  console.log(this.visitor_list);
}
removeVisitor(index:number){
  this.visitor_list.splice(index,1);
  
}
}
