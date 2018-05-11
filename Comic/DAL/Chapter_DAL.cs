using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class Chapter_DAL
    {
        public static List<Chapter_DTO> LoadChapter()
        {
            string sChuoiTruyVan = string.Format("select * From [dbo].[chapter]");
            DataTable dt = DataProvider.Instance.TruyVanDataReader(sChuoiTruyVan);
            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lệ và có giá trị
            {
                List<Chapter_DTO> lstChapterDTO = new List<Chapter_DTO>();
                Chapter_DTO chapterDTO;
                for (int i = 0; i < dt.Rows.Count; i++) //Duyệt datatable và đưa vào list đối tượng TRINHDO_DTO
                {
                    chapterDTO = new Chapter_DTO();
                    chapterDTO.chapter_id = Convert.ToInt32(dt.Rows[i]["chapter_id"]);
                    chapterDTO.chapter_date = dt.Rows[i]["chapter_date"].ToString();
                    chapterDTO.chapter_link = dt.Rows[i]["chapter_link"].ToString();
                    chapterDTO.chapter_name= dt.Rows[i]["chapter_name"].ToString();
                    chapterDTO.store_id = Convert.ToInt32(dt.Rows[i]["store_id"]);
                    //add 1 đối tượng trình độ vào vào lstTrinhDoDTO
                    lstChapterDTO.Add(chapterDTO);
                }
                return lstChapterDTO;
            }
            return null;
        }
    }
}
