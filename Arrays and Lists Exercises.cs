using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3___Arrays_and_Lists
{
    public class Arrays_and_Lists_Exercises
    {
        public static string Facebook()
        {
            /*
             
            var likesInput = new List<string>();
            Console.WriteLine("Enter a name of a friend.");
            var namesInput = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrEmpty(namesInput))
                {
                    break;
                }
                else
                {
                    likesInput.Add(namesInput);
                    Console.WriteLine("Enter another name of a friend who liked the post");
                    namesInput = Console.ReadLine();
                    continue;
                }
            }


            var numberOfLkes = likesInput.Count;

            for (var i = numberOfLkes; i >= 0; i++)
            {
                if (i == 0)
                {
                    return "There is no like on your post yet!";
                }
                else if (numberOfLkes == 1)
                {
                    return $"{namesInput} likes your post";
                }
                else if (numberOfLkes == 2)
                {
                    return $"{namesInput[0]} and {namesInput[1]} like your post";
                }

                else
                {
                    return $"{namesInput[0]}, {namesInput[1]} and {i - 2} others like your post";
                }
            }

            */


            /*
             
                              ######################################################################
                                             EXERCISE 1  ----  FACEBOOK LIKES PROGRAM
                              ######################################################################

                    When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

                    If no one likes your post, it doesn't display anything.
                    If only one person likes your post, it displays: [Friend's Name] likes your post.
                    If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
                    If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

                    Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
                    Depending on the number of names provided, display a message based on the above pattern.



            */
            var likesInput = new List<string> (); // Creating a list variable to store the names of friends.

            Console.WriteLine ("Enter a name of a friend.");

            var namesInput = Console.ReadLine (); // The names inputted into the console is store in the variable namesInput.

            while ( true ) // Creating a continous loop so as to take several names.
            {
                //(string.IsNullOrEmpty(namesInput)) ? break: 

                if ( string.IsNullOrEmpty (namesInput) ) // Aceessing whether the variable is empty so as to dsicontinue the line of code.
                {
                    break;
                }
                else
                {
                    likesInput.Add (namesInput); // The inputted names is added to the list variable created earlier.

                    Console.WriteLine ("Enter another name of a friend who liked the post");

                    namesInput = Console.ReadLine ();
                    continue;
                }
            }


            var numberOfLikes = likesInput.Count; // The elements in the list variable is counted and stored in another variable.

            /*
            return (numberOfLikes == 0) ? "There is no likes on your post"
                : (numberOfLikes == 1) ? likesInput[0] + " likes your post"
                : (numberOfLikes == 2) ? likesInput[0] + " and " + likesInput[1] + " like your post"
                : likesInput[0] + ", " + likesInput[1] + ($" and {numberOfLikes - 2} others like your post");
            */

            var message = "";

            if ( numberOfLikes == 0 )
                message = "There is no likes on your post";
            else if ( numberOfLikes == 1 )
                message = $"{likesInput[0]} likes your post";
            else if ( numberOfLikes == 2 )
                message = $"{likesInput[0]} and {likesInput[1]} like your post";
            else
                message = $"{likesInput[0]} , {likesInput[1]}   and {numberOfLikes - 2} others like your post";

            return message; // This display the number of likes on the facebook based on the format.


        }

        public static string NameReverse()
        {
            /*
              
            Console.WriteLine("");
            foreach (var name in namesInput)
            {
            }
            var convertToArray = namesInput.ToCharArray();
            return Convert.ToString(convertToArray);
            Array.Reverse(convertToArray);
            var reverseName = string.Join("", convertToArray);
            string reverseName = Convert.ToString(Array.Reverse(convertToArray));

            */

            /*
             
                              ######################################################################
                                         EXERCISE 2 --- NAMES REVERSAL PROGRAM
                              ######################################################################

                            Write a program and ask the user to enter their name. 
                            Use an array to reverse the name and then store the result in a new string. 
                            Display the reversed name on the console.

            */

            var namesInput = Console.ReadLine ();

            var convertToArray = namesInput.ToArray ();

            Array.Reverse (convertToArray);

            var nameReverse = string.Join ("", convertToArray);

            return $"the reverse of your name is writtten as {nameReverse}";

        }


        public static string UniqueNumbers()
        {

            /*
              //return Convert.ToString (uniqueList[i]);

            //uniqueList.Add(UniqueNums);

            //return uniqueList.Sort ();

            while ( true )
            {
                if ( uniqueList.Count != 5 )
                {
                    return "The numbers entered is not up to 5 numbers. Please re-try";
                    continue;
                }

                else
                {
                    Console.WriteLine ("Enter another number");

                    UniqueNums = Convert.ToInt32 (Console.ReadLine ());

                    uniqueList.Sort ();

                    foreach ( var i in uniqueList )
                    {
                        return $"The sorted list of unique numbers entered is {i}";
                    }

                    continue;

                    
                }

                
            }


            */

            /*
             
                              ######################################################################
                                               EXERCISE 3 ---  UNIQUE NUMBERS PROGRAM
                              ######################################################################

                    Write a program and ask the user to enter 5 numbers. 
                    If a number has been previously entered, display an error message and ask the user to re-try. 
                    Once the user successfully enters 5 unique numbers, sort them and display the result on the console
            */

            var uniqueList = new int[5]; // Creating an array variable to store the user input.

            for ( var i = 0; i < 5; i++ ) // Iterating over the array.
            {
                Console.WriteLine ($"Enter number {i + 1}");

                var UniqueNums = Convert.ToInt32 (Console.ReadLine ()); // Conversion of user input from string to integer.

                if ( Array.IndexOf (uniqueList, UniqueNums) != -1 || UniqueNums == 0 ) // Checking for repetition of inputs or emptiness in the array.
                {
                    return "Enter a unique number"; // Passing another instruction to the user to correct the inputs.
                    //i--;
                }

                else
                {
                    uniqueList[i] = UniqueNums; // Storing user inputs into the array variable.
                }

                //return Convert.ToString (uniqueList[i]);
            }

            Array.Sort (uniqueList); // The array variable is sorted in ascending order.

            foreach ( var i in uniqueList ) // Iterating over the array variable.
            {
                Console.Write ($"{i}, "); // Printing out the results of the iteration on a single line.
            }

            return "The numbers has been sorted.";


        }


        public static string NumberCollection()
        {

            /*
              
            

            */

            /*
             
                              ######################################################################
                                             EXERCISE 4  ----  NUMBER COLLECTION PROGRAM
                              ######################################################################

                    Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
                    The list of numbers may include duplicates. Display the unique numbers that the user has entered.

            */

            var listInput = new List<int> (); // Creating a list variable to store the inputs taken from the user.

            do
            {

                var anotherInput = Console.ReadLine (); // Taking user inputs.

                if ( anotherInput.ToLower () == "quit" )
                {
                    break;
                }

                else if ( string.IsNullOrEmpty (anotherInput) || string.IsNullOrWhiteSpace (anotherInput) ) // Confirming the user input.
                {
                    Console.WriteLine ("Enter unique numbers "); // Passing instruction to the user.
                }

                else
                {
                    listInput.Add (Convert.ToInt32 (anotherInput)); // The user inputs are added to the list variable.
                }


            } while ( true );

            foreach ( var i in listInput ) // Iterating over the list variable.
            {

                Console.Write ($"{i}, "); // The user input is printed out.
            }

            return "This is the collection of the unique numbers you entered";

            //return Convert.ToString(listInput);




            //return "The Unique";
        }


        public static string NumbersList()
        {

            /*
              
            

            */

            /*
             
                              ######################################################################
                                           EXERCISE 5  ----  UNIQUE NUMBERS LIST PROGRAM
                              ######################################################################

                    Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
                    If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list

            */

            //var uniqueSeries = new List<int> ();

            var nums = Console.ReadLine (); // Taking input of numbers from the user

            var seriesNum = nums.Split (','); // Splitting the numbers input into an array of an numbers.

            do
            {

                if ( seriesNum.Length < 5 || seriesNum.Length == 0 ) // Confirmation of list input
                {
                    Console.WriteLine ("An invalid list, please re-try");

                    nums = Console.ReadLine (); //Taking input if the confirmation is true

                    seriesNum = nums.Split (','); // Splitting the new input into an array of an numbers.

                    //return "You have entered an invalid list, please re-try";
                }

                else
                {
                    break;
                }

            } while ( true );  // The loop will be repeated as long as the condition is true.

            var numberArray = Array.ConvertAll (seriesNum, int.Parse); // Converting the strings input of numers into their respective int counterpart.

            Array.Sort (numberArray); // The number inputs are sorted in ascending order.


            for ( int i = 0; i < 3; i++ ) // Iterating over the first 3 elements of the sorted array.
            {
                Console.Write ($"{numberArray[i]}, "); // The result is printed out.

                //foreach ( var item in seriesNum )
                //{

                //}
            }

            return "This is the 3 smallest numbers in the list";


        }
    }
}
