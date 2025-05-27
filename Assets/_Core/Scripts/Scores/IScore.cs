namespace Pong.Scores
{
    public interface IScore
    {
        public int Score { get; }
        public void AddPoints(int points);
    }
}