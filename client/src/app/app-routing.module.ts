import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BooksComponent } from './books/books.component';
import { BorrowerComponent } from './borrower/borrower.component';
import { LendingsComponent } from './lendings/lendings.component';
import { AboutComponent } from './about/about.component';
import { GeneralInformationComponent } from './general-information/general-information.component';
import { RulesAndProceduresComponent } from './rules-and-procedures/rules-and-procedures.component';
import { ContactInformationComponent } from './contact-information/contact-information.component';
import { BookComponent } from './book/book.component';
import { Error404Component } from './error404/error404.component';
import { BorrowerFormComponent } from './borrower-form/borrower-form.component';
import { ManagementComponent } from './management/management.component';
import { LendingFormComponent } from './form/lending-form/lending-form.component';
import { BookFormComponent } from './book-form/book-form.component';

const routes: Routes = [{
  path: 'books',
  component: BooksComponent
},
{
  path: 'borrower',
  component: BorrowerComponent
},
{
  path: 'lendings',
  component: LendingsComponent
},
{
  path: 'management',
  component:ManagementComponent,
  children: [
    {
      path: "borrowerForms",
      component:BorrowerFormComponent
    },
    {
      path: "lendingForms",
      component: LendingFormComponent
    },
    {
      path: "bookForms",
      component:BookFormComponent
    }
  ]
},

{
  path: "about",
  component: AboutComponent,
  children: [
    {
      path: "general_information",
      component: GeneralInformationComponent
    },
    {
      path: "rules_and_procedures",
      component: RulesAndProceduresComponent
    },
    {
      path: "contact_information",
      component: ContactInformationComponent
    },
    {
      path: '',
      redirectTo: 'general_information',
      pathMatch: 'full'
    }
  ]
},
{
   path:"bookDetails/:id",
   component:BookComponent
},
{
  path:"books/:name1",
  component:BooksComponent
},

{
  path: '',
  redirectTo: '/books',
  pathMatch: 'full'
},
{
  path:'borrowerForms',
  component:BorrowerFormComponent
},
{
  path: '**',
  component: Error404Component
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
