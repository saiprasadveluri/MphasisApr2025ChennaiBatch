import { Component } from '@angular/core';
// import { VisitorEntry } from '../visitor-entry';

@Component({
  selector: 'app-visitor-listing',
  templateUrl: './visitor-listing.component.html',
  styleUrls: ['./visitor-listing.component.css']
})
export class VisitorListingComponent {
  showVisit: boolean = true;
  visitor_list: any[] = [];

}
