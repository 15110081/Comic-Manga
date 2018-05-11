using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class User_BUL
    {
        public static bool ThemUser(User_DTO userDTO)
        {
            bool ketQua = User_DAL.ThemUser(userDTO);
            return ketQua;
        }
        public static bool UpdateUser(User_DTO user)
        {
            bool kq = User_DAL.SuaUser(user);
            return kq;
        }
    }
}
