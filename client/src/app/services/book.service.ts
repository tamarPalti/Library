import { Injectable } from '@angular/core';
import { Book } from '../class/book';
import{HttpClient}from '@angular/common/http';
import {Observable}from 'rxjs/internal/Observable';
@Injectable({
  providedIn: 'root'
})
export class BookService {
  BookList: Book[] = [];
  Books: Book[] =[];
  // categoryName: string[] = ["Babies", "Childs", "Teens", "Adults"];
  j: number = 0;
  i: number = 0;
  api='https://localhost:44349/api';
  constructor(private http:HttpClient) {
    
  }
  getAll(id?: number):Observable<Book[]> {
    if(id!=null)
    return this.http.get<Book[]>(this.api+"/Book/bookListByAge/"+id);
    else
    return this.http.get<Book[]>(this.api+"/Book/");
  }
  getBook(id: number):Observable<Book> {
    return this.http.get<Book>(this.api+"/Book/"+id);
  }
  addBook(book:Book):Observable<any>
  {
    return this.http.post<any>(this.api+"/Book",book);
  }

}
