import { Component, OnInit } from '@angular/core';
import { Category } from '../class/category';
import { CategoryService } from '../services/category.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {
 
  constructor(private CategoryService:CategoryService,private router:Router) { }
  categoryList:Category[]=null;

  ngOnInit() {
    this.CategoryService.getAll().subscribe(category=> this.categoryList=category);

  }
  onClick(n:string)
  {
    this.router.navigate(['books',{name1:n}]);
  }
}
