import { Pipe, PipeTransform } from '@angular/core';
import { Book } from '../class/book';

@Pipe({
  name: 'search'
})
export class SearchPipe implements PipeTransform {

  transform(value: Book[], ...args: any): Book[] {
    let arr: Book[] = [];
    let j = 0;
    if(args[0]!=null)
    {
      for (var i = 0; i < value.length; i++) {
      if (value[i].title.includes(args[0])) {
        arr[j] = value[i]
        j++;
      }
    }
    return arr;
    }
    return value;

  }
}
