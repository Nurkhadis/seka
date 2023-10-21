using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.DAL_university
{

    public class Repository
    {
        private string Path;
        public Repository(string Path) {
            this.Path = Path;
        }


        public bool CreateQuestions(QuestionTamplate question)
        {
			try
			{
                using (var db = new LiteDatabase(""))
                {
                    var col = db.GetCollection<QuestionTamplate>("QuestionTamplate");
                    col.Insert(question);
                }
                return true; 
            }

			catch (Exception)
			{
                return false;
			}
        }
        public bool UpdateQueions(QuestionTamplate question)
        {
            try
            {
                using (var db = new LiteDatabase(""))
                {
                    var col = db.GetCollection<QuestionTamplate>("QuestionTamplate");
                    col.Update(question);
                }
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteQuestions(int questionId)
        {
            try
            {
                using (var db = new LiteDatabase(""))
                {
                    var col = db.GetCollection<QuestionTamplate>("QuestionTamplate");
                    col.Delete(questionId);
                }
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }
        public List<QuestionTamplate> GetQuestions() 
        {
            try
            {
                using (var db = new LiteDatabase(""))
                {
                    var col = db.GetCollection<QuestionTamplate>("QuestionTamplate");
                    return col.FindAll().ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<QuestionTamplate> GetCategoryByCategory(int id)
        {
            try
            {
                using (var db = new LiteDatabase(""))

                {

                    var col = db.GetCollection<QuestionTamplate>("QuestionTamplate").
                        FindAll()
                        .Where(w => w.cotegoryId == id).ToList();
                    return col.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
