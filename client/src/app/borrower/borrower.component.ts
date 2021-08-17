import { Component, OnInit } from '@angular/core';
import { Borrower } from '../class/borrower';
import { BorrowerService } from '../services/borrower.service';

@Component({
  selector: 'app-borrower',
  templateUrl: './borrower.component.html',
  styleUrls: ['./borrower.component.css']
})
export class BorrowerComponent implements OnInit {
 
  constructor(private borrowerService:BorrowerService) { }
  BorrowerLIst:Borrower[]=null;

  ngOnInit(): void {
    this.borrowerService.getAll().subscribe(borrower=> this.BorrowerLIst=borrower);
   
  }
  mychekbox:boolean=false;
  // GetAllBorrwer(){

  //     this.BorrowerLIst = this.borrowerService.getLocalBorrower();
  //     return this.BorrowerLIst;
  // }
  GetAllBorrwer()
  {
    this.borrowerService.getAll().subscribe(borrower=> this.BorrowerLIst=borrower);
  }

}
