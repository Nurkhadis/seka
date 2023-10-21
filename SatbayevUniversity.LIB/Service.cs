using Satbayev.DAL_university;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatbayevUniversity.LIB
{
    public class Service
    {
        public string AddQuestion(QuestionTamplate question) 
        {
            Repository repository = new Repository("");
            bool result = repository.CreateQuestions(question);

            if (result == true)
            {
                return "Вопрос упешно создан";
            }
            else
            {
                return "Ошибка";
             }
        }
        public List<QuestionTamplate> GetAllQuestions() 
        {
            Repository repository=new Repository("");  
            List<QuestionTamplate> list = new List<QuestionTamplate>();
            return list;
        }
    }
}
