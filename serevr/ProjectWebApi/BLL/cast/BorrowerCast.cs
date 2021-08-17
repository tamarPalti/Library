using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL.cast
{
  public  class BorrowerCast
    {
        public static BorrowerDTO GetBorrowerDTO(Borrower b)
        {
            BorrowerDTO borrowerDTO = new BorrowerDTO();
            borrowerDTO.id=b.id;
            borrowerDTO.ageCategory = b.CategoryId.Value;
            borrowerDTO.firstName = b.firstName;
            borrowerDTO.lastName = b.lastName;
            borrowerDTO.mail = b.mail;
            borrowerDTO.phoneNumber = b.phoneNumber;
            borrowerDTO.tz = b.tz;
            return borrowerDTO;
        }
        public static Borrower GetBorrower(BorrowerDTO b)
        {
            Borrower borrower = new Borrower();
            borrower.id = b.id;
            borrower.CategoryId = b.ageCategory;
            borrower.firstName = b.firstName;
            borrower.lastName = b.lastName;
            borrower.mail = b.mail;
            borrower.phoneNumber = b.phoneNumber;
            borrower.tz = b.tz;
            return borrower;
        }
    }
}
