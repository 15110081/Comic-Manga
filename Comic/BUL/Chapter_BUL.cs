using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
    public class Chapter_BUL
    {
        public static List<Chapter_DTO> LoadChapter()
        {
            return Chapter_DAL.LoadChapter();
        }
    }
}
