namespace MotiveGiftsDomain.Entities;

public class MotiveGiftResults
{
    public MotiveGiftResults(Guid userId, Dictionary<MotiveGift, MotiveGiftResult> results)
    {
        UserId = userId;
        Results = results;
    }

    public Guid UserId { get; }

    public Dictionary<MotiveGift, MotiveGiftResult> Results { get; }
}