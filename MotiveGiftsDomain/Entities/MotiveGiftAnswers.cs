namespace MotiveGiftsDomain.Entities;

public class MotiveGiftAnswers
{
    public MotiveGiftAnswers(Guid userId, MotiveGift motiveGift)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        MotiveGift = motiveGift;
        Strengths = [];
        Weaknesses = [];
    }

    public MotiveGiftAnswers(Guid id, Guid userId, MotiveGift motiveGift, Dictionary<int, Answer> strengths, Dictionary<int, Answer> weaknesses)
    {
        Id = id;
        UserId = userId;
        MotiveGift = motiveGift;
        Strengths = strengths;
        Weaknesses = weaknesses;
    }

    public Guid Id { get; }
    public Guid UserId { get; }
    public MotiveGift MotiveGift { get; }
    public Dictionary<int, Answer> Strengths { get; }
    public Dictionary<int, Answer> Weaknesses { get; }

    public void AddStrength(int question, Answer answer)
    {
        Strengths[question] = answer;
    }

    public void AddWeakness(int question, Answer answer)
    {
        Weaknesses[question] = answer;
    }

    public void RemoveStrength(int question)
    {
        Strengths.Remove(question);
    }

    public void RemoveWeakness(int question)
    {
        Weaknesses.Remove(question);
    }
}