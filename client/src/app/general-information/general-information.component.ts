import { Component, OnInit } from '@angular/core';
import { BorrowerService } from '../services/borrower.service';
import { BookService } from '../services/book.service';

@Component({
  selector: 'app-general-information',
  templateUrl: './general-information.component.html',
  styleUrls: ['./general-information.component.css']
})
export class GeneralInformationComponent implements OnInit {

  constructor(private borrowerService:BorrowerService,private bookService:BookService ) { }
  countB:number;
  countBook:number;
  ngOnInit(): void {
    this.borrowerService.getAll().subscribe(borrwer=>this.countB=borrwer.length);
    this.bookService.getAll().subscribe(book=>this.countBook=book.length);
   
  }

}
