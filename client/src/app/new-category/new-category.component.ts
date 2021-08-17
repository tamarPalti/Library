import { Component, OnInit, Input } from '@angular/core';
import { Category } from '../class/category';

@Component({
  selector: 'app-new-category',
  templateUrl: './new-category.component.html',
  styleUrls: ['./new-category.component.css']
})
export class NewCategoryComponent implements OnInit {
  @Input()category:Category;
  constructor() { }

  ngOnInit(): void {
  }
}
