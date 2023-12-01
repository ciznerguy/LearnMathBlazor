namespace BlazorApp2.Utilities
{
    public class OneGameLogic
    {
        private int number1;
        private int number2;
        private char op=' ';
        private int answer;
        private int correctAnswer;

        public OneGameLogic(int gameKind)
        {
            Random random = new();
           
          
            if (gameKind == 0)
            {
                op = '+';               
                number1 = random.Next(1, 11);
                number2 = random.Next(1, 11);
                this.correctAnswer = number1 + number2;
            }
           
            if (gameKind == 1)
            {
                while (number1 < number2 || number1==number2) 
                {
                    op = '-';
                    number1 = random.Next(1, 11);
                    number2 = random.Next(1, 11);
                    this.correctAnswer = number1 - number2;
                }
       
            }
            
      



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

        public string GetOp()
        {
            switch (op)
            {
                case '+':
                    return "+";
                case '-':
                    return "-";
                
                default:
                    return string.Empty;
            }
        }

        public void SetOp(char value)
        {
            op = value;
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