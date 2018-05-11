using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User_DAL
    {
        public static bool ThemUser(User_DTO userDTO)
        {
            string sChuoiTruyVan = "EXEC dbo.InsertProFile @fullName , @address , @birthDay , @avatar , @nickname , @username , @sex";
            bool ketQua = DataProvider.Instance.SelectExecuteNonQuery(sChuoiTruyVan, new object[] { userDTO.fullName, userDTO.address, userDTO.birthDay, userDTO.avatar, userDTO.nickName, userDTO.userName,userDTO.sex});
            return ketQua;
        }
        public static bool SuaUser(User_DTO userDTO)
        {
            string sChuoiTruyVan = "EXEC dbo.UpdateProfile @fullName , @address , @birthDay , @avatar , @nickname , @username , @sex";
            bool ketQua = DataProvider.Instance.SelectExecuteNonQuery(sChuoiTruyVan, new object[] { userDTO.fullName, userDTO.address, userDTO.birthDay, userDTO.avatar, userDTO.nickName, userDTO.userName, userDTO.sex });
            return ketQua;
        }
    }
}
