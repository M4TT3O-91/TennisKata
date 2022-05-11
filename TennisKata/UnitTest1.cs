using NUnit.Framework;

/* La partita viene vinta da chi:
 * - Ha almeno 4 punti e almeno due in più dell'altro giocatore
 * - una partita vinta viene chiamata LOVE
 * - 2 partite vinte vengono chiamate Fifteen
 * - 3 partite vinte vengono chiamate Thirty
 * - 4 partite vinte Fourty
 * - SE ogni giocatore possiede 3 vincite la partita è DEUCE*/

namespace TennisKata
{
    public class Tests
    {
        private SetResult _setResult;
        [SetUp]
        public void Setup()
        {
            _setResult = new SetResult();
        }

        [TestCase(1, 0, "Love for player 1")]
        [TestCase(2, 0, "Fifteen for player 1")]
        [TestCase(3, 0, "Thirty  for player 1")]
        [TestCase(4, 0, "Win for player 1")]
        public void Correct_State_For_Player1(int scorePlayer1, int scorePlayer2, string result)
        {
            _setResult.ScorePlayer1 = scorePlayer1;
            _setResult.ScorePlayer2 = scorePlayer2;

            Assert.AreEqual(result, _setResult);
        }


        [TestCase(0, 1, "Love for player 2")]
        [TestCase(0, 2, "Fifteen for player 2")]
        [TestCase(0, 3, "Thirty player 2")]
        [TestCase(0, 4, "Win for player 2")]
        public void Correct_State_For_Player2(int scorePlayer1, int scorePlayer2, string result)
        {
            _setResult.ScorePlayer1 = scorePlayer1;
            _setResult.ScorePlayer2 = scorePlayer2;

            Assert.AreEqual(result, _setResult); ;
        }

        [TestCase(0, 0, "")]
        [TestCase(1, 1, "Love - Love")]
        [TestCase(2, 2, "Fifteen - Fifteen")]
        [TestCase(3, 3, "Thirty - Thirty")]
        public void Same_Result_For_All_Player(int scorePlayer1, int scorePlayer2, string result)
        {
            _setResult.ScorePlayer1 = scorePlayer1;
            _setResult.ScorePlayer2 = scorePlayer2;

            Assert.AreEqual(result, _setResult); ;
        }

        [TestCase(1, 2, "Love - Fifteen")]
        [TestCase(2, 1, "Fifteen - Love")]
        [TestCase(1, 3, "Love - Thirty")]
        [TestCase(3, 1, "Thirty - Love")]
        [TestCase(2, 3, "Fifteen - Thirty")]
        [TestCase(3, 2, "Thirty - Fifteen")]
        public void Different_Result_Before_Win(int scorePlayer1, int scorePlayer2, string result)
        {
            _setResult.ScorePlayer1 = scorePlayer1;
            _setResult.ScorePlayer2 = scorePlayer2;

            Assert.AreEqual(result, _setResult); ;
        }

        [TestCase(4, 1, "Win for player1")]
        [TestCase(1, 4, "Win for player2")]
        [TestCase(4, 2, "Win for player1")]
        [TestCase(2, 4, "Win for player2")]
        [TestCase(5, 3, "Win for player1")]
        [TestCase(3, 5, "Win for player2")]
        public void Winner_Looser_Match(int scorePlayer1, int scorePlayer2, string result)
        {
            _setResult.ScorePlayer1 = scorePlayer1;
            _setResult.ScorePlayer2 = scorePlayer2;

            Assert.AreEqual(result, _setResult); ;
        }

        [TestCase(4, 4, "Deuce")]
        public void Same_Result_For_All_Player_After_Third_Set(int scorePlayer1, int scorePlayer2, string result)
        {
            _setResult.ScorePlayer1 = scorePlayer1;
            _setResult.ScorePlayer2 = scorePlayer2;

            Assert.AreEqual(result, _setResult); ;
        }

        [TestCase(4, 3, "Advantage player1")]
        [TestCase(3, 4, "Advantage player2")]
        [TestCase(5, 4, "Advantage player1")]
        [TestCase(4, 5, "Advantage player2")]
        [TestCase(9, 8, "Advantage player1")]
        [TestCase(8, 9, "Advantage player2")]
        public void Advantage_Results_Test(int scorePlayer1, int scorePlayer2, string result)
        {
            _setResult.ScorePlayer1 = scorePlayer1;
            _setResult.ScorePlayer2 = scorePlayer2;

            Assert.AreEqual(result, _setResult); ;
        }
    }
}