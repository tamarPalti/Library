import { Pipe, PipeTransform } from '@angular/core';
import { stringify } from 'querystring';

@Pipe({
  name: 'name'
})
export class NamePipe implements PipeTransform {

  transform(value:string, ...args: unknown[]): string {
      var arr: string[] =value.split(' '); 
      if(arr.length==2)
      {
           return arr[0]+" "+arr[1][0]+".";
      }
      return value;  
  }
}
