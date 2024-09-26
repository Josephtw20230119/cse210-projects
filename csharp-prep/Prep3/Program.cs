using System; 

class Program
{
    static void Main(string[] args)
    {
        // declare variable
        int magic_number,guess_number;
        string message;
        bool isContinue = true;
        int count = 0;
        string Answer = "Yes";
        bool isPlayAgain = true;
        
        while (isPlayAgain == true) {
            Console.Write("vWhat is the magic number ? ");
            magic_number = int.Parse(Console.ReadLine());
            while (isContinue == true) {

                Console.Write("vWhat is your guess ? ");
                guess_number = int.Parse(Console.ReadLine());
                if (guess_number == magic_number) {
                    message = "You guessed it";
                    isContinue = false;
                } 
                else if (guess_number > magic_number) {
                    message = "Lower";
                }
                else if (guess_number < magic_number) {
                    message = "Heigher";
                }
                else {
                    message = "none";
                }  
                // display message
                Console.WriteLine(message);
                count = count +1;
                //Console.WriteLine();  
            
            }
            Console.WriteLine($"You have guessed {count} times");
            Console.WriteLine($"Do you want to play the game again ? (Yes/No) ");
            Answer = Console.ReadLine();
            
            if (Answer.ToUpper() == "YES") {
                isPlayAgain = true;
                isContinue = true;
                
            }
            else {
                isPlayAgain = false;
            } 
            count = 0;
            
        }   
    }
}




