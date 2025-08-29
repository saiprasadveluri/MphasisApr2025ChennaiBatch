import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { AdminComponent } from './dashboard/admin/admin.component';


@Component({
  selector: 'app-root',
  imports: [RouterModule , RouterOutlet],
  standalone : true ,
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'East-Rest';

}
