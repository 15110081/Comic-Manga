using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Store_DAL
    {
        public static bool UpdateStore(Store_DTO storeDTO)
        {
            string sChuoiTruyVan = "EXEC dbo.CapNhatStore @id , @name , @link , @author , @cat , @status , @update_time , @view , @content , @img , @star , @chapter_num";
            bool ketQua = DataProvider.Instance.SelectExecuteNonQuery(sChuoiTruyVan, new object[] { storeDTO.ID, storeDTO.Name, storeDTO.Link, storeDTO.Author, storeDTO.Category, storeDTO.Status, storeDTO.Date, storeDTO.View, storeDTO.Content, storeDTO.Image, storeDTO.Star, storeDTO.Chapter });
            return ketQua;
        }
        public static bool  DeleteStore(int storeDTO)
        {
            string sChuoiTruyVan = string.Format("Delete from dbo.store where store_id='{0}'",storeDTO);
            bool ketQua = DataProvider.Instance.SelectExecuteNonQuery(sChuoiTruyVan);
            return ketQua;
        }
        public static bool InsertStore(Store_DTO storeDTO)
        {
            //string sChuoiTruyVan = string.Format("INSERT INTO [dbo].[store] (store_id,store_name,store_link,store_cat,store_status,store_update,store_view,store_content,star,store_author,img,chapter_num) VALUES ('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}','{8}',N'{9}',N'{10}','{11}')", 
            //    storeDTO.ID, storeDTO.Name,storeDTO.Link, storeDTO.Category, storeDTO.Status, storeDTO.Date, storeDTO.View, storeDTO.Content, storeDTO.Star, storeDTO.Author, storeDTO.Image, storeDTO.Chapter);
            string sChuoiTruyVan = "EXEC dbo.ThemStore @id , @name , @link , @author , @cat , @status , @update_time , @view , @content , @img , @star , @chapter_num";
            bool ketQua = DataProvider.Instance.SelectExecuteNonQuery(sChuoiTruyVan, new object[]{ storeDTO.ID,storeDTO.Name,storeDTO.Link,storeDTO.Author,storeDTO.Category,storeDTO.Status,storeDTO.Date,storeDTO.View,storeDTO.Content,storeDTO.Image,storeDTO.Star,storeDTO.Chapter});
            return ketQua;
        }
    }
}
