import { Component, OnInit } from '@angular/core';
import { LendingsService } from '../services/lendings.service';
import { Lendings } from '../class/lendings';
@Component({
  selector: 'app-lendings',
  templateUrl: './lendings.component.html',
  styleUrls: ['./lendings.component.css']
})
export class LendingsComponent implements OnInit {

  constructor(private lendingsService:LendingsService) 
  { 
     
  }
  lendingsList:Lendings[]=null;
  ngOnInit(): void {
    this.lendingsService.getAll().subscribe(lend=>this. lendingsList=lend);
  }
  today:Date=new Date();
}
