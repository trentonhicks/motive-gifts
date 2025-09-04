namespace MotiveGiftsDomain.Entities;

public class MotiveGiftQuestions
{
    public MotiveGiftQuestions(MotiveGift motiveGift, List<Question> strengths, List<Question> weaknesses)
    {
        MotiveGift = motiveGift;
        Strengths = strengths;
        Weaknesses = weaknesses;
    }

    public MotiveGift MotiveGift { get; }
    public List<Question> Strengths { get; }
    public List<Question> Weaknesses { get; }
}