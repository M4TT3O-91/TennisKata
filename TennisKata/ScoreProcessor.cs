

namespace TennisKata
{
    public class ScoreProcessor
    {
        public Result Process(SetResult result)
        {
            if(result.ScorePlayer1 < 0 || result.ScorePlayer2 < 0) throw new NegativeScoreNotSupportedException("Errore risultato negativo");

            
            return new Result();
            
        }

        private ResultTypes getResultFromScore(int score)
        {
            switch (score)
            {
                case 0: return ResultTypes.NONE;
                case 1: return ResultTypes.LOVE;
                case 2: return ResultTypes.FIFTEEN;
                case 3: return ResultTypes.THIRTY;
                case 4: return ResultTypes.FORTY;
                    default: return ResultTypes.NONE;
            }
        }

        private bool IsWinner(SetResult result)
        {
            return result.ScorePlayer1 >= 4 && result.ScorePlayer2 - result.ScorePlayer1 >= 2;
        }

        private bool IsDeuce(SetResult result)
        {
            return result.ScorePlayer1 >= 4 && result.ScorePlayer2 >= 4 && result.ScorePlayer1 == result.ScorePlayer2;
        }
    }
}
