using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BorrowerBLL
    {
        private readonly Library library;
        public BorrowerBLL(Library l)
        {
            library = l;
        }
        public BorrowerDTO GetBorrowerDTO(int id)
        {
            Borrower borrower = library.Borrower.Find(id);
            return cast.BorrowerCast.GetBorrowerDTO(borrower);
        }
        public List<BorrowerDTO> GetBorrowerDTO()
        {
            List<BorrowerDTO> borrowerDTO = new List<BorrowerDTO>();
            library.Borrower.ToList().ForEach(b => borrowerDTO.Add(cast.BorrowerCast.GetBorrowerDTO(b)));
            return borrowerDTO;
        }
    }
}
