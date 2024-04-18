using System.Collections.Generic;
using digiBookModel;
using digiBookDataLayer;

namespace digiBookBusiness
{
    public class Business
    {
        public List<bookss> GetAllBooks()
        {
            return Data.book();
        }
    }
}
