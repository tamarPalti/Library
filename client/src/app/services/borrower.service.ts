import { Injectable } from '@angular/core';
import { Borrower } from '../class/borrower';
import{HttpClient}from '@angular/common/http';
import {Observable}from 'rxjs/internal/Observable';
@Injectable({
  providedIn: 'root'
})
export class BorrowerService {
  BorrowerLIst:Borrower[]=[];
  i: number = 0;
  api='https://localhost:44349/api';
  constructor(private http:HttpClient) { 
    // this.BorrowerLIst.push(new Borrower(1234,"12345",1,"tamar ruti","palti","0548472584","tamar.palti211@gmail.com"));
    // this.BorrowerLIst.push(new Borrower(1235,"12346",2,"hila","gamliel","0548475584","h3193202@gmail.com"));
    // this.BorrowerLIst.push(new Borrower(1236,"12347",3,"ruti","choen","0544472584",""));

    this.getAll().subscribe(borrower=> this.BorrowerLIst=borrower);
  } 
  getAll():Observable<Borrower[]>{
    return this.http.get<Borrower[]>(this.api+"/Borrower/");
  }
  addBorrower(broower:Borrower):Observable<any>
  {
     return this.http.post<Borrower>(this.api+"/Borrower",broower);
  }
   getborrower(id:number) {
    return this.http.get<Borrower>(this.api+"/Borrower/"+id);
  }

  
 
}
