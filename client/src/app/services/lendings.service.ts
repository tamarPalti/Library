import { Injectable } from '@angular/core';
import { Lendings } from '../class/lendings';
// import { timingSafeEqual } from 'crypto';
import{HttpClient}from '@angular/common/http';
import {Observable}from 'rxjs/internal/Observable';
@Injectable({
  providedIn: 'root'
})
export class LendingsService {
  lendingsList:Lendings[]=[];
  api='https://localhost:44349/api';
  constructor(private http:HttpClient) { 
   
  }
  getAll()
  {
    return this.http.get<Lendings[]>(this.api+"/Lending");
  }
  add(l:Lendings):Observable<any>
  {
    return this.http.post<Lendings>(this.api+"/Lending",l);
  }

 
}
