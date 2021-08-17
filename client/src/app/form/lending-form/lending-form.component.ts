import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { BookService } from 'src/app/services/book.service';
import { BorrowerService } from 'src/app/services/borrower.service';
import { Book } from 'src/app/class/book';
import { Borrower } from 'src/app/class/borrower';
import { identifierModuleUrl, leadingComment } from '@angular/compiler';
import { Lendings } from 'src/app/class/lendings';
import { LendingsService } from 'src/app/services/lendings.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-lending-form',
  templateUrl: './lending-form.component.html',
  styleUrls: ['./lending-form.component.css']
})
export class LendingFormComponent implements OnInit {
  form = this.fb.group(
    {
      idborrower: ['', Validators.required],
      id: ["", Validators.required]
    }
  );
  constructor(private bookService: BookService, private borrowerService: BorrowerService, private fb: FormBuilder, private lendingService: LendingsService, private router: Router) { }
  BookList: Book[];
  BorrowerLIst: Borrower[];
  Borrower: Borrower;
  Book: Book;
  lending: Lendings;
  ngOnInit(): void {
     this.bookService.getAll().subscribe(books=> this.BookList=books);
     this.borrowerService.getAll().subscribe(borrower=>this.BorrowerLIst=borrower);
  }
  save(): void {
  //  this.borrowerService.getborrower(this.form.value.idborrower).subscribe(borrower=> this.Borrower=borrower);;
  //  this.bookService.getBook(parseInt(this.form.value.id)).subscribe(books=> this.Book=books);
    // this.lending = new Lendings(0, this.Borrower.id,this.Book.title, this.Borrower.firstName, this.Borrower.lastName, this.form.value.id,  new Date(), null);
    // this.lending.id=0;
    this.lending=new Lendings();
    this.lending.bookId=this.form.value.id;
    this.lending.borrowerid=this.form.value.idborrower;
    this.lending.landingDate=new Date();
    this.lending.returnDate=new Date("2002-02-02");
    this.lendingService.add(this.lending).subscribe(p=>{this.router.navigate(['lendings']);});
    
  }
  printFormGroup():void{
    console.log(this.form)
  }
}

