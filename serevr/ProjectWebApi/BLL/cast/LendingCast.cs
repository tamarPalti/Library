using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL.cast
{
    public class LendingCast
    {
        public static LendingDTO GetlendingDTO(Lendings l)
        {
            LendingDTO lendingDTO = new LendingDTO();
            lendingDTO.id = l.id;
            lendingDTO.bookId =l.bookId.Value;
            lendingDTO.bookTitle = l.book.title;
            lendingDTO.borrowerFirstName = l.borrower.firstName;
            lendingDTO.borrowerLastName = l.borrower.lastName;
            lendingDTO.borrowerid = l.borrowerid.Value;
            lendingDTO.landingDate = l.landing;
            lendingDTO.returnDate = l.returnDate;
            return lendingDTO;
        }
        public static Lendings Getlending(LendingDTO l)
        {
            Lendings lending = new Lendings();
            lending.id = l.id;
            lending.bookId = l.bookId;
            lending.borrowerid= l.borrowerid;
            lending.landing= l.landingDate;
            lending.returnDate = l.returnDate;
            return lending;
        }
    }
}
