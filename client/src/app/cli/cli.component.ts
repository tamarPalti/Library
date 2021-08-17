import { Component, OnInit } from '@angular/core';
import { from } from 'rxjs';
import { Form } from '@angular/forms'
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-cli',
  templateUrl: './cli.component.html',
  styleUrls: ['./cli.component.css']
})
export class CliComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  maxMark = 100;
  minMark = 0;
  oraot: string = "נא לכתוב את המבחן בשקט ולהגיש בזמן שנקבע";
  x:string=":שאלות";
  mark: number = 9;
  name: string;
  getMark(): number {
    return 10 * this.mark;
  }
  myInput:boolean;
  myInput1:boolean;
  getcolor()
  {
    if(!this.name)
    {
      return true;
    }
    else{
      return false;
    }
  }
  getcolor1(){
    if(!this.name)
    {
      return false;
    }
    else{
      return true;
    }
  }
  myPlaceholder: string = "enter your name";
  qwetion: string[] = ["1+2", "3+5", "3*5", "15/5"];
  markTest() {
    if (this.getMark() > 70)
      alert("התלמיד " +this.name + " עבר את המבחן בהצלחה ");
    else
      alert("התלמיד " +this. name + " נכשל במבחן ");
  }
  
}

