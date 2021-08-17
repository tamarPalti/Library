export class Lendings {
    constructor(id?:number, bookId?:number ,bookTitle? :string,borrowerFirstName?:string,borrowerLastName?:string,
      borrowerid?:number, landingDate?:Date,returnDate? :Date)               
    {
       this.id=id;
      this.bookId=bookId;
       this.bookTitle =bookTitle ;
       this.borrowerFirstName=borrowerFirstName;
       this.borrowerLastName=borrowerLastName;
      this.borrowerid=borrowerid;
       this.landingDate=landingDate;
       this.returnDate =returnDate ;
    }
id:number;
borrowerid:number;
borrowerFirstName:string;
borrowerLastName:string;
bookId:number;
bookTitle :string;
landingDate:Date;
returnDate :Date;
}

