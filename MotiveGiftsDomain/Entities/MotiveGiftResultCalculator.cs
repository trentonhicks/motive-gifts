namespace MotiveGiftsDomain.Entities;

public class MotiveGiftResultCalculator
{
    public static Dictionary<MotiveGift, MotiveGiftResult> Calculate(Dictionary<MotiveGift, MotiveGiftAnswers> answersByMotiveGift)
    {
        var results = new Dictionary<MotiveGift, MotiveGiftResult>();

        foreach (var kvp in answersByMotiveGift)
        {
            var motiveGift = kvp.Key;
            var answers = kvp.Value;

            int strengthScore = answers.Strengths.Values.Sum(a => (int)a);
            int weaknessScore = answers.Weaknesses.Values.Sum(a => (int)a);

            results[motiveGift] = new MotiveGiftResult(motiveGift, strengthScore, weaknessScore);
        }

        return results;
    }
}
