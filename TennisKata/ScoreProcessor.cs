namespace TennisKata
{
    public class ScoreProcessor
    {
        public Result Process(SetResult result)
        {
            if (result.ScorePlayer1 < 0 || result.ScorePlayer2 < 0) throw new NegativeScoreNotSupportedException("Errore risultato negativo");

            else if (result.ScorePlayer1 >= 4 && result.ScorePlayer2 - result.ScorePlayer1 >= 2)
                return new Result { resPalyer1 = ResultTypes.WIN, resPalyer2 = ResultTypes.LOST };
            else if (result.ScorePlayer2 >= 4 && result.ScorePlayer2 - result.ScorePlayer1 >= 2)
                return new Result { resPalyer2 = ResultTypes.WIN, resPalyer1 = ResultTypes.LOST };
            else if (result.ScorePlayer1 >= 4 && result.ScorePlayer2 >= 4 && result.ScorePlayer1 == result.ScorePlayer2)
                return new Result { resPalyer1 = ResultTypes.DEUCE, resPalyer2 = ResultTypes.DEUCE };


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

    }
}
