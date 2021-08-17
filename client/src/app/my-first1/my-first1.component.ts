import { Component, OnInit } from '@angular/core';

@Component({
  selector: ' app-my-first1',
  templateUrl: './my-first1.component.html',
  styleUrls: ['./my-first1.component.css']
})
export class MyFirst1Component {

  constructor() { }

  ngOnInit(): void {
  }
  isAdded: boolean = true;
  ClassList: string = "info border";
  classArr: string[] = [];

  classListFunc(): string {
      return "border big-text";
  }

  addBorder(): void {
      this.classArr.push("border")
  }

  bigText(): void {
      this.classArr.push("big-text")
  }

  getColor():string{
return "green";
  }
  classObj: any = { "danger": 9 > 10, "big-text": this.isAdded };

  styleObj:any = { "background-color": "purple", "font-size.px": 18 };
  styleObj2:any = { "background-color":10>2? "purple":this.getColor, "font-size.px": 4*5 };

}
