using Microsoft.AspNetCore.Mvc;
using QuestionQuiz.Models;

namespace QuestionQuiz.Controllers
{
    public class QuestionViewController : Controller
    {
        public IActionResult Index()
        {
            QuestionListModel model = new QuestionListModel();
            model.Items=new List<int>() { 1,2,3,4 };
            return View(model);
        }

        public IActionResult UpdateUserAnswers()
        {
            return RedirectToAction("Index");
        }
        public IActionResult QuestionPane(int Qno)
        {
            QuestionInfoModel model = new QuestionInfoModel();
            model.QId = Qno;
            model.QText = "My First Question";
            model.Options = new List<QuestionOptions>()
            {
                new QuestionOptions()
                {
                    OptId=Qno,
                    OptionText="Oprtion 1 for Question "+Qno.ToString()
                },
                new QuestionOptions()
                {
                    OptId=Qno,
                    OptionText="Oprtion 2 for Question "+Qno.ToString()
                },
                new QuestionOptions()
                {
                    OptId=Qno,
                    OptionText="Oprtion 3 for Question "+Qno.ToString()
                },
                new QuestionOptions()
                {
                    OptId=Qno,
                    OptionText="Oprtion 4 for Question "+Qno.ToString()

                }
            };
            return PartialView("QuestionPane", model);
        }
    }
}
