using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.DAL_university
{
    public class QuestionTamplate 
    {
        internal object categotyId;
        internal int cotegoryId;

        public int id {  get; set; }

        public DateTime creatDate { get; set; }
        public string name { get; set; }
        public string quetions { get; set; }
        public double mark {  get; set; } 
        public string level { get; set; } 

        public string changeAuto { get; set; } 

        public DateTime ChangeDate { get; set; } 
        public  Category Category{  get; set; }
        public int CategotyId { get; set; } 
    }
}
