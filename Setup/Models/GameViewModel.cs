using Microsoft.AspNetCore.Mvc;

namespace Setup.Models
{
    public class GameViewModel 
    {
        public Game game;
        public GameViewModel(Game game)
        {
            this.game = game;
            Console.WriteLine($"{currentQuestion.Content} uit ctor van viewmodelgame");
        }
        public int RoomNumber => game.RoomNumber;
        public List<Person> Participants => game.Participants;
        public Person currentPerson => game.currentPerson;
        public List<Question> Questions => game.Questions;
        public Question currentQuestion => game.currentQuestion;
        public List<Question> playedQuestions => game.playedQuestions;
    }

}
