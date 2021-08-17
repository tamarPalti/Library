import { Component, OnInit } from '@angular/core';
import { Book } from '../class/book';
import { BookService } from '../services/book.service';
import { ActivatedRoute, Router } from '@angular/router';
@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {
  constructor(private bookService:BookService,private ActivatedRoute:ActivatedRoute,private router:Router) { 
    this.ActivatedRoute.params.subscribe(params=>
      this.bookService.getAll(params.name1).subscribe(books=> this.BookList=books));
  }
  BookList:Book[]=[];
  ngOnInit() {
  
  }
  onClick()
  {
    this.router.navigate(['books']);
  }
  name:string;
  color:string="salmon"
}
