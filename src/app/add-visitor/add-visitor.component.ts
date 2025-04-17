import { Component } from '@angular/core';
import { VisitorEntry } from '../visitor-entry';

@Component({
  selector: 'app-add-visitor',
  templateUrl: './add-visitor.component.html',
  styleUrls: ['./add-visitor.component.css']
})
export class AddVisitorComponent {
  visName:string = '';
  visId:string = '';
  visDate:string = '';
  visTime:string = '';
  numChars: number = 40;
  visitorData:VisitorEntry[] = [];
  OnUserKeyUp() {
    this.numChars = 40 - this.visName.length;
  }
  OnVisitorAdd() {
    // console.log("hello");
    // alert("Visitor Added")
    var temp:VisitorEntry={
      visitorId: this.visId,
      visitorName: this.visName,
      visitorDate: this.visDate,
      visitorTime: this.visTime
    }
    this.visitorData.push(temp)
    console.log(this.visitorData)
}
}
