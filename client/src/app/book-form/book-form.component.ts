import { Component, OnInit } from '@angular/core';
import { Book } from '../class/book';
import { Category } from '../class/category';
import { CategoryService } from '../services/category.service';
import { BookService } from '../services/book.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-book-form',
  templateUrl: './book-form.component.html',
  styleUrls: ['./book-form.component.css']
})
export class BookFormComponent implements OnInit {
  categoryList: Category[];
  book:Book=new Book();
  constructor(private categotyService: CategoryService,private BookService:BookService,private router: Router) { }

  ngOnInit(): void {
     this.categotyService.getAll().subscribe(category=> this.categoryList=category);
  }
  save():void{
    this.book.id=0;
    this.book.ageCategory=parseInt(this.book.ageCategory.toString());
    this.BookService.addBook(this.book).subscribe(p=>{
      this.router.navigate(['books']);
    });
   
  }

}
