import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

const URL="http://localhost:53731/";

@Injectable({
  providedIn: 'root'
})
export class TableServiceService {

  constructor(public httpClient:HttpClient) { }

  getCategories()
  {
    return this.httpClient.get(URL+"api/category/getAllCategories")
  }
}
