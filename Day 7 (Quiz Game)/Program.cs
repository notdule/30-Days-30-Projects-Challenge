static void Main(string[] args)
{
   string[] text = File.ReadAllLines("questions.txt");
   List<string> questions = new List<string>();
   List<string> answers = new List<string>();
 
   for (int i = 0; i < text.Length; i++)
   {
      if (i % 4 == 0)
         questions.Add(text[i]);
      else
         answers.Add(text[i]);
   }
 
   int questionIndex = 0;
   int answerIndex = 0;
   int score = 0;
 
   while (questionIndex < questions.Count)
   {
      Console.WriteLine("Question: " + questions[questionIndex]);
      questionIndex++;
 
      int correctAnswer = 0;
 
      for (int i = 0; i < 3; i++)
      {
         if (answers[answerIndex].StartsWith(">"))
            correctAnswer = i + 1;
 
         Console.WriteLine(i + 1 + "." + answers[answerIndex].Replace(">", ""));
 
         answerIndex++;
      }
 
      int answer = int.Parse(Console.ReadLine());
 
      if (answer == correctAnswer)
      {
         Console.WriteLine("Correct!");
         score++;
      }
      else
         Console.WriteLine("Incorrect.");
   }
 
   Console.WriteLine("End of quiz! Your score was " + score + " points!");
   Console.ReadKey();
}
