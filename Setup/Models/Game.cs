using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Setup.Models
{
    public class Game
    {
        public int RoomNumber { get; set; }
        public List<Person> Participants { get; set; }
        public Person currentPerson { get; set; }
        public List<Question> Questions { get; set; }
        public Question currentQuestion { get; set; }
        public List<Question> playedQuestions { get; set; }

        public Game(int roomNumber, List<Person> people) {
            RoomNumber = roomNumber;
            Participants = people;
            fillQuestions();
            nextQuestion();
            int personId = new Random().Next(people.Count - 1);
            currentPerson = people[personId];
            Console.WriteLine($"{currentQuestion.Content} uit constructor van Game");
        }

        public void fillQuestions()
        {
            Questions = new List<Question>();
            playedQuestions = new List<Question>();
            Questions.Add(new Question("Wie zou als eerst 1"));
            Questions.Add(new Question("Wie zou als eerst 2"));
            Questions.Add(new Question("Wie zou als eerst 3"));
            Questions.Add(new Question("Wie zou als eerst 4"));
            Questions.Add(new Question("Wie zou als eerst 5"));
            Questions.Add(new Question("Wie zou als eerst 6"));
            Questions.Add(new Question("Wie zou als eerst 7"));
              
        }
        public void nextQuestion()
        {
            if(Questions.Count > 0)
            {
                int i = new Random().Next(Questions.Count - 1);
                Question q = Questions[i];
                Questions.RemoveAt(i);
                playedQuestions.Add(q);
                currentQuestion = q;
            }
            else
            {
                currentQuestion = new Question("GEEN QUESTION");
            }
        }
    }
}
