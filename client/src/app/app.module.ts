import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MyFirstComponent } from './my-first/my-first.component';
import { CliComponent } from './cli/cli.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { from } from 'rxjs';
import { MyFirst1Component } from './my-first1/my-first1.component';
import { CategoryComponent } from './category/category.component';
import { BookComponent } from './book/book.component';
import { BooksComponent } from './books/books.component';
import { BorrowerComponent } from './borrower/borrower.component';
import { NamePipe } from './Pipe/name.pipe';
import { SearchPipe } from './Pipe/search.pipe';
import { MenuComponent } from './menu/menu.component';
import { Routes, RouterModule } from '@angular/router';
import { LendingsComponent } from './lendings/lendings.component';
import { Error404Component } from './error404/error404.component';
import { AboutComponent } from './about/about.component';
import { GeneralInformationComponent } from './general-information/general-information.component';
import { RulesAndProceduresComponent } from './rules-and-procedures/rules-and-procedures.component';
import { ContactInformationComponent } from './contact-information/contact-information.component';
import { BorrowerFormComponent } from './borrower-form/borrower-form.component';
import { LendingFormComponent } from './form/lending-form/lending-form.component';
import { ManagementComponent } from './management/management.component';
import { BookFormComponent } from './book-form/book-form.component';
import { NewCategoryComponent } from './new-category/new-category.component';
import { HttpClientModule } from '@angular/common/http'


@NgModule({
  declarations: [
    AppComponent,
    MyFirstComponent,
    CliComponent,
    MyFirst1Component,
    CategoryComponent,
    BookComponent,
    BooksComponent,
    BorrowerComponent,
    NamePipe,
    SearchPipe,
    MenuComponent,
    LendingsComponent,
    Error404Component,
    AboutComponent,
    GeneralInformationComponent,
    BorrowerFormComponent,
    LendingFormComponent,
    ManagementComponent,
    BookFormComponent,
    NewCategoryComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    CommonModule,
    RouterModule,
    ReactiveFormsModule,
    HttpClientModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
