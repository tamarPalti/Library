import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Category } from '../class/category';
import { BorrowerService } from '../services/borrower.service';
import { CategoryService } from '../services/category.service';
//import { EventEmitter } from 'protractor';
@Component({
  selector: 'app-borrower-form',
  templateUrl: './borrower-form.component.html',
  styleUrls: ['./borrower-form.component.css']
})
export class BorrowerFormComponent implements OnInit {
  form: FormGroup = new FormGroup(
    {
      tz: new FormControl('', [Validators.required, Validators.minLength(9), Validators.maxLength(9), Validators.pattern('[0-9]*')]),
      ageCategory: new FormControl(),
      firstName: new FormControl('', [Validators.required, Validators.minLength(2)]),
      lastName: new FormControl(),
      phoneNumber: new FormControl(),
      mail: new FormControl(),
    }
  );
  categoryList: Category[];
  @Input() ifClear: boolean;
  @Output() myoutput = new EventEmitter<boolean>(false);
  constructor(private categotyService: CategoryService, private borrowerSrvice: BorrowerService, private router: Router) {
  }
  ngOnInit(): void {
    this.categotyService.getAll().subscribe(categorys => this.categoryList = categorys);
  }
  save(): void {

    this.borrowerSrvice.addBorrower(this.form.value).subscribe(res => {
      this.myoutput.emit(true);
      this.router.navigate(['borrower']);
    }

    );
   
  }
  reset(): void {

    this.form.reset();
  }

  printFormGroup(): void {
    console.log(this.form)
  }
}
