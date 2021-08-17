import { Component, OnInit } from '@angular/core';
import { Book } from '../class/book';
import { BookService } from '../services/book.service';
import { ActivatedRoute } from '@angular/router';
import { CategoryService } from '../services/category.service';
import { Category } from '../class/category';
@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent  {
 
  constructor(private bookService:BookService,private ActivatedRoute:ActivatedRoute,private CategoryService:CategoryService) { }
  BookDetails:Book=null;
  ngOnInit(): void {
    this.ActivatedRoute.params.subscribe(params=>
      this.bookService.getBook(params.id).subscribe(books=> this.BookDetails=books));
  }
  getCategory(id:number){
    let c:Category[]=[];
    this.CategoryService.getAll().subscribe(caterories=> c=caterories);
    return c.find((c)=>{return c.id==id});
  }
}
