using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class Store_BUL
    {
        public static bool InsertStore(Store_DTO storeDTO)
        {
            bool ketQua = Store_DAL.InsertStore(storeDTO);
            return ketQua;
        }
        public static bool DeleteStore(int storeDTO)
        {
            bool ketQua = Store_DAL.DeleteStore(storeDTO);
            return ketQua;
        }
        public static bool UpdateStore(Store_DTO storeDTO)
        {
            bool ketQua = Store_DAL.UpdateStore(storeDTO);
            return ketQua;
        }
    }
}
