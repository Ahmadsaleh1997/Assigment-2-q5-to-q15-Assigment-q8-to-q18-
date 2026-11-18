using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assigment_2__q5_to_q15___Assigment__q8_to_q18_
{
    internal class Program
    {
        // this part is for Assignment 2 
        class Book
        {
            public string Title { get; set; } = "";
            public int Pages { get; set; }
        }
        //-----------------------------------------------------------------------------
        // 
        static string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };


        static void Main(string[] args)
        {

            // this the rest of Assignment 2 questions from Q5 to Q10 
            #region Q5 
            // Declare an int pages = 300; then store it in a double variable without using a cast. 
            int pages = 300;
            double pagesDouble = pages; // no cast needed
            Console.WriteLine(pagesDouble);
            #endregion

            #region Q6 
            // Declare a double price = 49.99; then convert it into an int using a cast. 
            double price = 49.99;
            int priceInt = (int)price; // 49 (decimal part is cut off)
            Console.WriteLine(priceInt);
            #endregion

            #region Q7 
            // Given string pagesText = "464";, convert it into an int using the Convert class. 
            string pagesText = "464";
            int pagesFromText = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesFromText);
            #endregion

            #region Q8 
            // Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails. 
            string yearText = "2023";
            int parsedYear = int.Parse(yearText);
            Console.WriteLine(parsedYear);

            string badText = "abc";
            if (!int.TryParse(badText, out int result))
            {
                Console.WriteLine("Invalid number");
            }
            #endregion

            #region Q9 
            //Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
            int bookPages = 464;
            string bookPagesText = bookPages.ToString();
            Console.WriteLine(bookPagesText.GetType()); // System.String
            #endregion

            #region Q10 
            // Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            int copies = 100;
            object boxed = copies;        // boxing
            int unboxed = (int)boxed;     // unboxing
            Console.WriteLine(boxed);
            Console.WriteLine(unboxed);
            #endregion

            // -----------------------------------------------------------------------------------------------------------------------------------------

            //  this the rest of Assignment 3 questions from Q8 to Q18 

            #region Q8 
            //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book". 

            int page = 464;

            if (page > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion



            #region Q9 
            // Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true. Use the && operator.
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion

            #region Q10 
            // Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else. 
            string title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion

            #region Q11 
            // Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel (same rule as question 8: long if pages > 300)
            int pages1 = 464;
            string sizeLabel = pages1 > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            #endregion

            #region Q12 
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1. Clean Code. 
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            #endregion

            #region Q13 
            // Using the same books array, use a while loop to print every book title. 
            int index = 0;
            while (index < books.Length)
            {
                Console.WriteLine(books[index]);
                index++;
            }
            #endregion

            #region Q14 
            // Write a do-while loop that prints "Checking book..." exactly 3 times. 
            int counter = 0;
            do
            {
                Console.WriteLine("Checking book...");
                counter++;
            } while (counter < 3);
            #endregion

            #region Q15 
            // Using the same books array, use a foreach loop to print every book title. 
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            #endregion

            #region Q16 
            //Using the same books array, loop through it and print each title, but stop completely (break) once you reach "Refactoring".
            foreach (string book in books)
            {
                if (book == "Refactoring")
                    break;

                Console.WriteLine(book);
            }
            #endregion

            #region Q17 
            // Using the same books array, print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop). 
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                    continue;

                Console.WriteLine(book);
            }
            #endregion

            #region Q18 
            // Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty, use return to exit the method early instead of printing anything. 
            PrintFirstBook();
            #endregion
        }

        static void PrintFirstBook()
        {
            if (books.Length == 0)
            {
                return;
            }

            Console.WriteLine(books[0]);
        }
    }
}
