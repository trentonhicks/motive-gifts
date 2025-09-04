namespace MotiveGiftsDomain.Entities;

public class MotiveGiftResult
{
    public MotiveGiftResult(MotiveGift motiveGift, int strengthScore, int weaknessScore)
    {
        MotiveGift = motiveGift;
        StrengthScore = strengthScore;
        WeaknessScore = weaknessScore;
    }

    public MotiveGift MotiveGift { get; }
    public int StrengthScore { get; }
    public int WeaknessScore { get; }
}
