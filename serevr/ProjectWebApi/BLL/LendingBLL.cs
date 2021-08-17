using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class LendingBLL
    {
        private readonly Library library;
        public LendingBLL(Library l)
        {
            library = l;
        }
        public LendingDTO GetLendingDTO(int id)
        {
            Lendings lendings = library.Lendings.Find(id);
            return cast.LendingCast.GetlendingDTO(lendings);
        }
        public List<LendingDTO> GetLendingDTO()
        {
            List<LendingDTO> lendingDTO = new List<LendingDTO>();
            library.Lendings.ToList().ForEach(l => lendingDTO.Add(cast.LendingCast.GetlendingDTO(l)));
            return lendingDTO;
        }
        public List<LendingDTO> GetLendingDTOByBookId(int id)
        {
            List<LendingDTO> lendingDTO = new List<LendingDTO>();
            library.Lendings.ToList().ForEach(l =>
            {
                if (l.bookId == id)
                    lendingDTO.Add(cast.LendingCast.GetlendingDTO(l));
            });
            return lendingDTO;
        }
        public List<LendingDTO> GetLendingDTOByBorrowerkId(int id)
        {
            List<LendingDTO> lendingDTO = new List<LendingDTO>();
            library.Lendings.ToList().ForEach(l =>
            {
                if (l.borrowerid == id)
                    lendingDTO.Add(cast.LendingCast.GetlendingDTO(l));
            });
            return lendingDTO;
        }
    }
}
