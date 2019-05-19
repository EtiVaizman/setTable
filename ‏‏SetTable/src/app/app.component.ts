import { Component } from '@angular/core';
import { TableServiceService } from './table-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'SetTable';
  allCategories:any=[];
  constructor(public tableService:TableServiceService){

this.tableService.getCategories().subscribe(res=>{
this.allCategories=res;
});
  }

}
