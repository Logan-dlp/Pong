namespace Pong.Scores
{
    public interface IScore
    {
        int Score { get; }
        void AddPoints(int points);
    }
}