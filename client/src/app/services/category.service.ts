import { Injectable } from '@angular/core';
import { Category } from '../class/category';
import{HttpClient}from '@angular/common/http';
import {Observable}from 'rxjs/internal/Observable';
@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  categoryList:Category[]=[];
  api='https://localhost:44349/api';
  constructor(private http:HttpClient) {
    // this.categoryList.push(new Category(0,"Babies","מפחיד","purple"));
    // this.categoryList.push(new Category(1,"Childs","מרגש","pink"));
    // this.categoryList.push(new Category(2,"Teens","מותח","skyblue"));
    // this.categoryList.push(new Category(3,"Adults","מענין","blue"));
   }
   getAll():Observable<Category[]>{
    return this.http.get<Category[]>(this.api+"/Category/");
  }
 //  getAll(){
  //    return this.categoryList;
  //  }
}
