namespace BlazorApp2.Utilities
{
    public class OneGameLogic
    {
        private int number1;
        private int number2;
        private int answer;
        private int correctAnswer;

        public OneGameLogic(int gameKind)
        {

            if (gameKind == 0)
            {
                Console.WriteLine("hi");
            }
            Random random = new();
            number1 = random.Next(1, 11);
            number2 = random.Next(1, 11);
            this.correctAnswer = number1 + number2;



        }


        public int GetNumber1()
        {
            return number1;
        }

        public void SetNumber1(int value)
        {
            number1 = value;
        }

        public int GetNumber2()
        {
            return number2;
        }

        public void SetNumber2(int value)
        {
            number2 = value;
        }

        public int GetAnswer()
        {
            return answer;
        }

        public void SetAnswer(int value)
        {
            answer = value;
        }

        public int GetCorrectAnswer()
        {
            return correctAnswer;
        }

        public void SetCorrectAnswer(int value)
        {

            correctAnswer = value; ;
        }
        public bool CheckCorrectAnswer(int userAnswer)
        {
            return userAnswer == correctAnswer;
        }
    }

}