namespace Shared.DbModels
{
    public class QuizModel
    {
        public int QuizModelId { get; set; }
        public string? QuizName { get; set; }
        public List<QuestionModel> Questions { get; set; } = new List<QuestionModel>();
        //public List<MetaTagModel> MetaTags { get; set; } = new List<MetaTagModel>();
    }
}
