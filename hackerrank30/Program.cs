using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
//
//
//Day 0: Hello, World.
//
// //
// class Solution
// {
//   static void Main(String[] args)
//   {
//     // Declare a variable named 'inputString' to hold our input.
//     String inputString;

//     // Read a full line of input from stdin (cin) and save it to our variable, input_string.
//     inputString = Console.ReadLine();

//     // Print a string literal saying "Hello, World." to stdout using cout.
//     Console.WriteLine("Hello, World.");

//     // TODO: Write a line of code here that prints the contents of input_string to stdout.
//     Console.WriteLine(inputString);
//   }
// }
//
//Day 1: Data Types
// //
// class Solution
// {
//   static void Main(String[] args)
//   {
//     int i = 4;
//     double d = 4.0;
//     string s = "HackerRank ";


//     // Declare second integer, double, and String variables.
//     int iSec;
//     double dSec;
//     string sSec;
//     // Read and save an integer, double, and String to your variables.
//     iSec = Convert.ToInt16(Console.ReadLine());
//     dSec = Convert.ToDouble(Console.ReadLine());
//     sSec = Console.ReadLine();

//     // Print the sum of both integer variables on a new line.
//     Console.WriteLine(i + iSec);

//     // Print the sum of the double variables on a new line.
//     Console.WriteLine(String.Format("{0:f1}", d + dSec));
//     // Concatenate and print the String variables on a new line
//     Console.WriteLine($"{s}{sSec}");
//     // The 's' variable above should be printed first.

//   }
// }
//
//Day 2: Operators
//
// class Result
// {

//   /*
//    * Complete the 'solve' function below.
//    *
//    * The function accepts following parameters:
//    *  1. DOUBLE meal_cost
//    *  2. INTEGER tip_percent
//    *  3. INTEGER tax_percent
//    */

//   public static void solve(double meal_cost, int tip_percent, int tax_percent)
//   {
//     Console.WriteLine(Math.Round((meal_cost * (1.0 + Convert.ToDouble((tip_percent + tax_percent)) / 100.00))));
//   }

// }

// class Solution
// {
//   public static void Main(string[] args)
//   {
//     double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

//     int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

//     int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

//     Result.solve(meal_cost, tip_percent, tax_percent);
//   }
// }

//
//Day 3: Intro to Conditional Statements
//
// class Solution
// {
//   public static void Main(string[] args)
//   {
//     int N = Convert.ToInt32(Console.ReadLine().Trim());
//     if (N % 2 != 0) Console.WriteLine("Weird");
//     if (N % 2 == 0 && N >= 2 && N <= 5) Console.WriteLine("Not Weird");
//     if (N % 2 == 0 && N >= 6 && N <= 20) Console.WriteLine("Weird");
//     if (N % 2 == 0 && N > 20) Console.WriteLine("Not Weird");
//   }
// }

//
//Day 4: Class vs. Instance
//
// class Person
// {
//   public int age;
//   public Person(int initialAge)
//   {
//     // Add some more code to run some checks on initialAge
//     age = 0;
//     if (initialAge < 0)
//     {
//       Console.WriteLine("Age is not valid, setting age to 0.");
//     }
//     age = initialAge;

//   }
//   public void amIOld()
//   {

//     if (age < 13) Console.WriteLine("You are young.");
//     else if (age >= 13 && age < 18) Console.WriteLine("You are a teenager.");
//     else if (age >= 18) Console.WriteLine("You are old.");
//     // Do some computations in here and print out the correct statement to the console 
//   }

//   public void yearPasses()
//   {
//     // Increment the age of the person in here
//     age = age + 1;
//   }

//   static void Main(String[] args)
//   {
//     int T = int.Parse(Console.In.ReadLine());
//     for (int i = 0; i < T; i++)
//     {
//       int age = int.Parse(Console.In.ReadLine());
//       Person p = new Person(age);
//       p.amIOld();
//       for (int j = 0; j < 3; j++)
//       {
//         p.yearPasses();
//       }
//       p.amIOld();
//       Console.WriteLine();
//     }
//   }
// }
//
//Day 5: Loops
//
// class Solution
// {
//   public static void Main(string[] args)
//   {
//     int n = Convert.ToInt32(Console.ReadLine().Trim());
//     for (int i = 1; i <= 10; i++)
//     {
//       Console.WriteLine($"{n} x {i} = {n * i}");
//     }
//   }
// }

//
//Day 6: Let's Review
//
// class Solution
// {
//   static void Main(String[] args)
//   {
//     int T = Convert.ToInt16(Console.ReadLine());

//     for (int j = 0; j < T; j++)
//     {
//       string sLine = Console.ReadLine();
//       string s1LineOut = string.Empty;
//       string s2LineOut = string.Empty;
//       for (int i = 0; i < sLine.Length; i++)
//       {
//         if (i % 2 == 0) s1LineOut = s1LineOut + sLine[i];
//         if (i % 2 != 0) s2LineOut = s2LineOut + sLine[i];
//       }

//       Console.WriteLine($"{s1LineOut} {s2LineOut}");
//     }
//     /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
//   }
// }
//
//Day 7: Arrays
//
// class Solution
// {
//   public static void Main(string[] args)
//   {
//     int n = Convert.ToInt32(Console.ReadLine().Trim());

//     List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
//     for (int i = arr.Count - 1; i >= 0; i--)
//     {
//       Console.Write(arr[i] + " ");
//     }
//   }
// }

//
//Dictionary
//Day 8: Dictionaries and Maps
// version 1.0
// class Solution
// {
//   static void Main(String[] args)
//   {
//     int n = Convert.ToInt32(Console.ReadLine());
//     Dictionary<string, string> friends = new Dictionary<string, string>(n);
//     for (int i = 0; i < n; i++)
//     {
//       string[] inputString = Console.ReadLine().Split(new char[] { ' ' });

//       friends.Add(inputString[0], inputString[1]);
//     }
//     foreach (KeyValuePair<string, string> keyValue in friends)
//     {

//     }

//     while (true)
//     {
//       string inputKey = "";
//       inputKey = Console.ReadLine();
//       if (inputKey == null) break;
//       else
//       if (!friends.ContainsKey(inputKey)) Console.WriteLine("Not found");
//       else Console.WriteLine(inputKey + "=" + friends[inputKey]);
//     }

//     /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
//   }
// }

//
//Day 8: Dictionaries and Maps
// version 2.0
//
//
// class Solution
// {
//   static void Main(String[] args)
//   {

//     int n = Convert.ToInt32(Console.ReadLine());
//     Dictionary<string, string> people = new Dictionary<string, string>(n);
//     for (int i = 0; i < n; i++)
//     {
//       string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
//       string name = firstMultipleInput[0];
//       string phone = firstMultipleInput[1];
//       people.Add(name, phone);
//     }

//     string instr;

//     while ((instr = Console.ReadLine()) != null)
//     {
//       string phone = string.Empty;
//       // if(people.TryGetValue(instr, out phone))
//       // Console.WriteLine(instr+"="+phone);
//       // else Console.WriteLine("Not found");
//       try
//       {
//         Console.WriteLine($"{instr}={people[instr]}");
//       }
//       catch
//       {
//         Console.WriteLine("Not found");
//       }
//     }

//     /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
//   }
// }

//
//Day 9: Recursion 3
//
//
// class Result
// {

//   /*
//    * Complete the 'factorial' function below.
//    *
//    * The function is expected to return an INTEGER.
//    * The function accepts INTEGER n as parameter.
//    */

//   public static int factorial(int n)
//   {


//     return n == 0 ? 1 : n * factorial(n - 1);
//   }


// }

// class Solution
// {
//   public static void Main(string[] args)
//   {
//     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//     int n = Convert.ToInt32(Console.ReadLine().Trim());

//     int result = Result.factorial(n);

//     textWriter.WriteLine(result);

//     textWriter.Flush();
//     textWriter.Close();
//   }
// }

//
//Day 10: Binary Numbers
// //
// class Solution
// {
//   public static void Main(string[] args)
//   {
//     int n = Convert.ToInt32(Console.ReadLine().Trim());
//     string binstr = string.Empty;
//     int tempn = n;

//     while (tempn >= 1)
//     {
//       binstr = binstr + Convert.ToString(tempn % 2);
//       tempn = tempn / 2;
//     }
//     //
//     StringBuilder strrev = new StringBuilder(binstr);
//     int size = (int)(strrev.Length) / 2;
//     char buf;
//     for (int i = 0; i < size; i++)
//     {
//       buf = strrev[i];
//       strrev[i] = strrev[strrev.Length - i - 1];
//       strrev[strrev.Length - i - 1] = buf;
//     }
//     binstr = strrev.ToString();


//     string[] divBinStr = binstr.TrimEnd().Split('0');
//     int max = 0;
//     for (int i = 0; i < divBinStr.Length; i++)
//     {
//       if (max < divBinStr[i].Length) max = divBinStr[i].Length;
//     }
//     Console.WriteLine(max);

//   }
// }

//
//Day 11: 2D Arrays
//Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum.
// class Solution
// {


//     public static void Main(string[] args)
//     {

//         List<List<int>> arr = new List<List<int>>();

//         for (int i = 0; i < 6; i++)
//         {
//             arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
//         }
//         int maxhrgSum = 0;
//         int hrgSum;
//         for(int i = 0;i < arr.Count-2;i++)
//         {

//             for(int j = 0;j < arr.Count-2;j++)
//                 {
//                     hrgSum = 0;
//                     for(int k = i; k < i+3;k++)
//                     {
//                        for(int l = j; l < j+3;l++)
//                        {
//                           if (k == i || k == i+2 )
//                           {
//                               hrgSum = hrgSum + arr[k][l];

//                           }

//                           if (k == i+1 && l == j + 1)
//                            {
//                               hrgSum = hrgSum + arr[k][l];

//                           }


//                        } 
//                     }
//                     if(i == 0 && j == 0)maxhrgSum = hrgSum;
//                     if(maxhrgSum < hrgSum) maxhrgSum = hrgSum;


//                 }
//         }
//         Console.WriteLine(maxhrgSum);
//     }
// }



// string result = "GOOD SET";
// string resString = string.Empty;

// for (int i = 0; i < words.Count; i++)
// {
//   string subString = words[i];
//   for (int j = 0; j < words.Count; j++)
//   {
//     if (i != j)
//     {

//       int indexOfSubstring = words[j].IndexOf(subString);
//       if (indexOfSubstring > 0)
//       {
//         result = "BAD SET";
//         resString = words[j];
//       }
//     }
//   }
// }
// Console.WriteLine(result);
// Console.WriteLine(resString);


//
//Day 12: Inheritance
//
//Heraldo Memelli 8135627
//2
//100 80
// class Person
// {
//   protected string firstName;
//   protected string lastName;
//   protected int id;

//   public Person() { }
//   public Person(string firstName, string lastName, int identification)
//   {
//     this.firstName = firstName;
//     this.lastName = lastName;
//     this.id = identification;
//   }
//   public void printPerson()
//   {
//     Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
//   }
// }

// class Student : Person
// {
//   public int[] testScores { get; set; }

//   public Student(string firstName, string lastName, int id, int[] testScores)
//       : base(firstName, lastName, id)

//   {

//     this.firstName = firstName;
//     this.lastName = lastName;
//     this.id = id;
//     this.testScores = testScores;
//   }



//   /*	
//   *   Class Constructor
//   *   
//   *   Parameters: 
//   *   firstName - A string denoting the Person's first name.
//   *   lastName - A string denoting the Person's last name.
//   *   id - An integer denoting the Person's ID number.
//   *   scores - An array of integers denoting the Person's test scores.
//   */


//   // Write your constructor here

//   /*	
//   *   Method Name: Calculate
//   *   Return: A character denoting the grade.
//   */
//   // Write your method here
//   public char Calculate()
//   {
//     int sum = 0;
//     for (int i = 0; i < testScores.Length; i++)
//     {
//       sum = sum + testScores[i];
//     }
//     sum = sum / testScores.Length;
//     if (90 <= sum && sum <= 100)
//     {
//       return 'O';
//     }
//     else if (80 <= sum && sum < 90)
//     {
//       return 'E';
//     }
//     else if (70 <= sum && sum < 80)
//     {
//       return 'A';
//     }
//     else if (55 <= sum && sum < 70)
//     {
//       return 'P';
//     }
//     else if (40 <= sum && sum < 55)
//     {
//       return 'D';
//     }
//     else if (0 <= sum && sum < 40)
//     {
//       return 'T';
//     }
//     else
//       return 'T';
//   }

// }

// class Solution
// {
//   static void Main()
//   {
//     string[] inputs = Console.ReadLine().Split();
//     string firstName = inputs[0];
//     string lastName = inputs[1];
//     int id = Convert.ToInt32(inputs[2]);
//     int numScores = Convert.ToInt32(Console.ReadLine());
//     inputs = Console.ReadLine().Split();
//     int[] scores = new int[numScores];
//     for (int i = 0; i < numScores; i++)
//     {
//       scores[i] = Convert.ToInt32(inputs[i]);
//     }

//     Student s = new Student(firstName, lastName, id, scores);
//     s.printPerson();
//     Console.WriteLine("Grade: " + s.Calculate() + "\n");
//   }
// }


//
//Day 13: Abstract Classes
// //
// abstract class Book
// {

//   protected String title;
//   protected String author;

//   public Book(String t, String a)
//   {
//     title = t;
//     author = a;
//   }
//   public abstract void display();


// }

// //Write MyBook class
// class MyBook : Book
// {
//   public int Price { get; set; }

//   public MyBook(string title, string author, int price) : base(title, author)
//   {
//     Price = price;

//   }
//   public override void display()
//   {

//     Console.WriteLine($"Title: {title} ");
//     Console.WriteLine($"Author: {author} ");
//     Console.WriteLine($"Price: {Price} ");

//   }
// }

// class Solution
// {
//   static void Main(String[] args)
//   {
//     String title = Console.ReadLine();
//     String author = Console.ReadLine();
//     Math.Abs
//     int price = Int32.Parse(Console.ReadLine());
//     Book new_novel = new MyBook(title, author, price);
//     new_novel.display();
//   }
// }

//
//
//Day 14: Scope
//
// //
// class Difference
// {
//   private int[] elements;
//   public int maximumDifference;

//   // Add your code here
//   public Difference(int[] elements)
//   {
//     this.elements = elements;
//   }
//   public void computeDifference()
//   {

//     //int result = 0;

//     for (int i = 0; i < elements.Length; i++)
//     {
//       for (int j = i; j < elements.Length; j++)
//       {

//         maximumDifference = Math.Max(maximumDifference, Math.Abs(elements[i] - elements[j]));

//       }

//     }

//     //return result;

//   }


// } // End of Difference Class

// class Solution
// {
//   static void Main(string[] args)
//   {
//     Convert.ToInt32(Console.ReadLine());

//     int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

//     Difference d = new Difference(a);

//     d.computeDifference();

//     Console.Write(d.maximumDifference);
//   }
// }



//
//
//Day 15: Linked List
//

// class Node
// {
//   public int data;
//   public Node next;
//   public Node(int d)
//   {
//     data = d;
//     next = null;
//   }

// }
// class Solution
// {

//   public static Node insert(Node head, int data)
//   {

//     //Complete this method

//     if (head == null)
//     {
//       head = new Node(data);
//       return head;
//     }

//     /* 2 & 3: Allocate the Node &
//           Put in the data*/
//     Node new_node = new Node(data);

//     /* 4. Make next of new Node as
//                 next of prev_node */
//     new_node.next = null;

//     /* 5. make next of prev_node
//                     as new_node */

//     Node last = head;
//     while (last.next != null)
//       last = last.next;

//     /* 6. Change the next of last node */
//     last.next = new_node;


//     return head;
//   }

//   public static void display(Node head)
//   {
//     Node start = head;
//     while (start != null)
//     {
//       Console.Write(start.data + " ");
//       start = start.next;
//     }
//   }
//   static void Main(String[] args)
//   {

//     Node head = null;
//     int T = Int32.Parse(Console.ReadLine());
//     while (T-- > 0)
//     {
//       int data = Int32.Parse(Console.ReadLine());
//       head = insert(head, data);
//     }
//     display(head);
//   }
// }

//
//Day 16: Exceptions - String to Integer
//

// class Solution
// {
//   public static void Main(string[] args)
//   {
//     string S = Console.ReadLine();
//     try
//     {
//       int m = Int32.Parse(S);
//       Console.WriteLine(S);
//     }
//     catch (FormatException e)
//     {
//       Console.WriteLine("Bad String");
//     }


//   }
// }

//Write your code here
//
//Day 17: More Exceptions
// //
// class Calculator
// {
//   public int power(int n, int p)
//   {
//     int Pown = n;
//     int Powp = p;
//     if (Pown < 0 || Powp < 0)
//     {
//       throw new Exception("n and p should be non-negative");
//     }
//     else
//     {
//       return Convert.ToInt32(Math.Pow(Pown, Powp));
//     }

//   }

// }

// class Solution
// {
//   static void Main(String[] args)
//   {
//     Calculator myCalculator = new Calculator();
//     int T = Int32.Parse(Console.ReadLine());
//     while (T-- > 0)
//     {
//       string[] num = Console.ReadLine().Split();
//       int n = int.Parse(num[0]);
//       int p = int.Parse(num[1]);
//       try
//       {
//         int ans = myCalculator.power(n, p);
//         Console.WriteLine(ans);
//       }
//       catch (Exception e)
//       {
//         Console.WriteLine(e.Message);

//       }
//     }

//   }
// }

//
//Day 18: Queues and Stacks
//

// class Solution
// {
//   //Write your code here
//   Queue<char> stringchars = new Queue<char>();
//   Stack<char> stringstack = new Stack<char>();

//   public void enqueueCharacter(char c)
//   {
//     stringchars.Enqueue(c);
//   }
//   public char dequeueCharacter()
//   {
//     return stringchars.Dequeue();
//   }
//   public char popCharacter()
//   {
//     return stringstack.Pop();
//   }
//   public void pushCharacter(char c)
//   {
//     stringstack.Push(c);
//   }

//   static void Main(String[] args)
//   {
//     // read the string s.
//     string s = Console.ReadLine();

//     // create the Solution class object p.
//     Solution obj = new Solution();

//     // push/enqueue all the characters of string s to stack.
//     foreach (char c in s)
//     {
//       obj.pushCharacter(c);
//       obj.enqueueCharacter(c);
//     }

//     bool isPalindrome = true;

//     // pop the top character from stack.
//     // dequeue the first character from queue.
//     // compare both the characters.
//     for (int i = 0; i < s.Length / 2; i++)
//     {
//       if (obj.popCharacter() != obj.dequeueCharacter())
//       {
//         isPalindrome = false;

//         break;
//       }
//     }

// finally print whether string s is palindrome or not.
// if (isPalindrome)
// {
//   Console.Write("The word, {0}, is a palindrome.", s);
// }
// else
// {
//   Console.Write("The word, {0}, is not a palindrome.", s);
// }
//   }
// }

//
//Day 19: Interfaces
// //
// public interface AdvancedArithmetic
// {
//   int divisorSum(int n);
// }

// public class Calculator : AdvancedArithmetic
// {
//   public int divisorSum(int n)
//   {
//     int res = 0;
//     for (int i = 1; i <= n; i++)
//     {
//       if (n % i == 0) res = res + i;
//     }
//     return res;
//   }
// }

// class Solution
// {
//   static void Main(string[] args)
//   {
//     int n = Int32.Parse(Console.ReadLine());
//     AdvancedArithmetic myCalculator = new Calculator();
//     int sum = myCalculator.divisorSum(n);
//     Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
//   }
// }

//
//
//Day 20: Sorting
//
//

// class Solution
// {
//   public static void Main(string[] args)
//   {
//     int n = Convert.ToInt32(Console.ReadLine().Trim());

//     List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
//     int numberOfSwaps = 0;
//     for (int i = 0; i < n; i++)
//     {
//       // Track number of elements swapped during a single array traversal
//       //int numberOfSwaps = 0;

//       for (int j = 0; j < n - 1; j++)
//       {
//         int temp;
//         // Swap adjacent elements if they are in decreasing order
//         if (a[j] > a[j + 1])
//         {
//           temp = a[j + 1];
//           a[j + 1] = a[j];
//           a[j] = temp;
//           numberOfSwaps++;
//         }
//       }

//       // If no elements were swapped during a traversal, array is sorted
//       if (numberOfSwaps == 0)
//       {
//         break;
//       }
//     }

//     Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
//     Console.WriteLine($"First Element: {a[0]}");
//     Console.WriteLine($"Last Element: {a[a.Count - 1]}");

//     // Write your code here
//   }
// }
//
//
//Day 21: Generics
// //
// class Printer
// {

/**
*    Name: PrintArray
*    Print each element of the generic array on a new line. Do not return anything.
*    @param A generic array
**/
// Write your code here

//   static void PrintArray<T>(T[] arr)

//   {

//     for (int i = 0; i < arr.Length; i++)
//     {
//       Console.WriteLine(arr[i]);
//     }

//   }
//   static void Main(string[] args)
//   {
//     int n = Convert.ToInt32(Console.ReadLine());
//     int[] intArray = new int[n];
//     for (int i = 0; i < n; i++)
//     {
//       intArray[i] = Convert.ToInt32(Console.ReadLine());
//     }

//     n = Convert.ToInt32(Console.ReadLine());
//     string[] stringArray = new string[n];
//     for (int i = 0; i < n; i++)
//     {
//       stringArray[i] = Console.ReadLine();
//     }

//     PrintArray<Int32>(intArray);
//     PrintArray<String>(stringArray);
//   }
// }

//
//
//Day 22: Binary Search Trees
//

//   class Node
//   {
//     public Node left, right;
//     public int data;
//     public Node(int data)
//     {
//       this.data = data;
//       left = right = null;
//     }
//   }

//   class Solution
//   {

//     static int getHeight(Node root)

//     {
//       if (root == null)
//         return -1;
//       else
//       {
//         /* compute the depth of each subtree */
//         int lDepth = getHeight(root.left);
//         int rDepth = getHeight(root.right);

//         /* use the larger one */
//         if (lDepth > rDepth)
//           return (lDepth + 1);
//         else
//           return (rDepth + 1);
//       }

//       //Write your code here

//     }

//     static Node insert(Node root, int data)
//     {
//       if (root == null)
//       {
//         return new Node(data);
//       }
//       else
//       {
//         Node cur;
//         if (data <= root.data)
//         {
//           cur = insert(root.left, data);
//           root.left = cur;
//         }
//         else
//         {
//           cur = insert(root.right, data);
//           root.right = cur;
//         }
//         return root;
//       }
//     }
//     static void Main(String[] args)
//     {
//       Node root = null;
//       int T = Int32.Parse(Console.ReadLine());
//       while (T-- > 0)
//       {
//         int data = Int32.Parse(Console.ReadLine());
//         root = insert(root, data);
//       }
//       int height = getHeight(root);
//       Console.WriteLine($"B-tree height equals to : {height}");
//       Queue<Node> q = new Queue<Node>();
//       q.Enqueue(root);

//       Console.WriteLine($"Number of nodes : {q.Count}");
//       q.Enqueue(root.left);
//       Console.WriteLine($"Number of nodes : {q.Count}");

//     }
//   }
// }
//
//
//Day 23: BST Level-Order Traversal
// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// class Node
// {
//   public Node left, right;
//   public int data;
//   public Node(int data)
//   {
//     this.data = data;
//     left = right = null;
//   }
// }
// class Solution
// {

//   static void levelOrder(Node node)
//   {

//     // Base Case
//     if (node == null)
//       //return 0;
//       Console.WriteLine("No data");

//     // Create an empty queue
//     // for level order traversal
//     Queue<Node> q = new Queue<Node>();

//     // Enqueue Root and initialize height
//     q.Enqueue(node);
//     int height = 0;
//     string nodesdata = string.Empty;

//     while (1 == 1)
//     {
//       // nodeCount (queue size) indicates
//       // number of nodes at current level.
//       int nodeCount = q.Count;

//       if (nodeCount == 0)
//         //return height;
//         break;
//       height++;

//       // Dequeue all nodes of current
//       // level and Enqueue all
//       // nodes of next level
//       while (nodeCount > 0)
//       {
//         Node newnode = q.Peek();
//         q.Dequeue();
//         if (newnode.left != null)
//           q.Enqueue(newnode.left);
//         if (newnode.right != null)
//           q.Enqueue(newnode.right);
//         nodesdata = nodesdata + newnode.data + " ";
//         nodeCount--;
//       }

//       Console.WriteLine(nodesdata);
//       Console.WriteLine($"Level Nodes {height}");

//     }
//     //Write your code here
//   }

//   static Node insert(Node root, int data)
//   {
//     if (root == null)
//     {
//       return new Node(data);
//     }
//     else
//     {
//       Node cur;
//       if (data <= root.data)
//       {
//         cur = insert(root.left, data);
//         root.left = cur;
//       }
//       else
//       {
//         cur = insert(root.right, data);
//         root.right = cur;
//       }
//       return root;
//     }
//   }
//   static void Main(String[] args)
//   {
//     Node root = null;
//     // int T = Int32.Parse(Console.ReadLine());
//     int T = 10000;
//     while (T-- > 0)
//     {
//       //int data = Int32.Parse(Console.ReadLine());
//       int data = new Random().Next(0, 10000000);
//       root = insert(root, data);
//     }
//     levelOrder(root);

//   }
// }

//
//Day 24: More Linked Lists
//
// //
// class Node
// {
//   public int data;
//   public Node next;
//   public Node(int d)
//   {
//     data = d;
//     next = null;
//   }

// }
// class Solution
// {

//   public static Node removeDuplicates(Node head)
//   {
//     //Write your code here
//     if (head.next == null)
//       return head;

//     Node prev = head, s = prev.next;
//     while (s != null)
//     {

//       if (prev.data == s.data)
//       {
//         prev.next = s.next;
//         //s = s.next;
//       }
//       else
//         prev = s;
//       s = s.next;
//     }
//     return head;
//   }
//   public static Node insert(Node head, int data)
//   {
//     Node p = new Node(data);


//     if (head == null)
//       head = p;
//     else if (head.next == null)
//       head.next = p;
//     else
//     {
//       Node start = head;
//       while (start.next != null)
//         start = start.next;
//       start.next = p;

//     }
//     return head;
//   }
//   public static void display(Node head)
//   {
//     Node start = head;
//     while (start != null)
//     {
//       Console.Write(start.data + " ");
//       start = start.next;
//     }
//   }
//   static void Main(String[] args)
//   {

//     Node head = null;
//     int T = Int32.Parse(Console.ReadLine());
//     while (T-- > 0)
//     {
//       int data = Int32.Parse(Console.ReadLine());
//       head = insert(head, data);
//     }
//     head = removeDuplicates(head);
//     display(head);
//   }
// }
//
//Day 25: Running Time and Complexity
//
//
// class Solution
// {
//   static void Main(String[] args)
//   {
//     int max = Int32.Parse(Console.ReadLine());

//     for (int j = 0; j < max; j++)
//     {
//       int n = Int32.Parse(Console.ReadLine());
//       Console.WriteLine(isPrime(n));
//     }

//   }
//   static string isPrime(int number)
//   {
//     if (number <= 1)
//       return "Not prime";
//     else if (number % 2 == 0)
//     {
//       if (number == 2) return "Prime";
//       else return "Not prime";
//     }

//     long N = (long)(Math.Sqrt(number) + 0.5);

//     for (int i = 3; i <= N; i += 2)
//       if (number % i == 0)
//         return "Not prime";

//     return "Prime";
//   }

// }
//
//
//Day 26: Nested Logic
//
//
// class Solution
// {
//   static void Main(String[] args)
//   {
//     int fine = 0;
//     int[] arr1 = Console.ReadLine().TrimEnd().Split(' ').ToArray().Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();
//     int[] arr2 = Console.ReadLine().TrimEnd().Split(' ').ToArray().Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();
//     int n = 2;
//     if (arr1[n] > arr2[n]) fine = 10000;
//     else if (arr1[n] == arr2[n] && arr1[n - 1] > arr2[n - 1])
//       fine = (arr1[n - 1] - arr2[n - 1]) * 500;
//     else if (arr1[n] == arr2[n] && arr1[n - 1] == arr2[n - 1] && arr1[n - 2] > arr2[n - 2])
//       fine = (arr1[n - 2] - arr2[n - 2]) * 15;
//     Console.WriteLine(fine);
//     /* Enter your code here. Read iniput from STDIN. Print output to STDOUT. Your class should be named Solution */
//   }
// }

//
//Day 27: Testing
//in JAVA !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// //
// import java.util.*;

// public class Solution {

//     public static int minimum_index(int[] seq) {
//         if (seq.length == 0) {
//             throw new IllegalArgumentException("Cannot get the minimum value index from an empty sequence");
//         }
//         int min_idx = 0;
//         for (int i = 1; i < seq.length; ++i) {
//             if (seq[i] < seq[min_idx]) {
//                 min_idx = i;
//             }
//         }
//         return min_idx;
//     }
// //
// static class TestDataEmptyArray {
//         public static int[] get_array() {
//         int arr[]={};
//         return arr;
//         }
//     }
//     static class TestDataUniqueValues {
//         public static int[] get_array() {
//             // complete this function
//             int arr[]={1,2,3,4,5};
//         return arr;
//         }
//         public static int get_expected_result() {
//             // complete this function
//             return 0;
//         }
//     }
//     static class TestDataExactlyTwoDifferentMinimums {
//         public static int[] get_array() {
//             // complete this function
//             int arr[]={1,3,1};
//         return arr;
//         }
//         public static int get_expected_result() {
//             // complete this function
//             return 0;
//         }
//     }

// //

// 	public static void TestWithEmptyArray() {
//         try {
//             int[] seq = TestDataEmptyArray.get_array();
//             int result = minimum_index(seq);
//         } catch (IllegalArgumentException e) {
//             return;
//         }
//         throw new AssertionError("Exception wasn't thrown as expected");
//     }

//     public static void TestWithUniqueValues() {
//         int[] seq = TestDataUniqueValues.get_array();
//         if (seq.length < 2) {
//             throw new AssertionError("less than 2 elements in the array");
//         }

//         Integer[] tmp = new Integer[seq.length];
//         for (int i = 0; i < seq.length; ++i) {
//             tmp[i] = Integer.valueOf(seq[i]);
//         }
//         if (!((new LinkedHashSet<Integer>(Arrays.asList(tmp))).size() == seq.length)) {
//             throw new AssertionError("not all values are unique");
//         }

//         int expected_result = TestDataUniqueValues.get_expected_result();
//         int result = minimum_index(seq);
//         if (result != expected_result) {
//             throw new AssertionError("result is different than the expected result");
//         }
//     }

//     public static void TestWithExactlyTwoDifferentMinimums() {
//         int[] seq = TestDataExactlyTwoDifferentMinimums.get_array();
//         if (seq.length < 2) {
//             throw new AssertionError("less than 2 elements in the array");
//         }

//         int[] tmp = seq.clone();
//         Arrays.sort(tmp);
//         if (!(tmp[0] == tmp[1] && (tmp.length == 2 || tmp[1] < tmp[2]))) {
//             throw new AssertionError("there are not exactly two minimums in the array");
//         }

//         int expected_result = TestDataExactlyTwoDifferentMinimums.get_expected_result();
//         int result = minimum_index(seq);
//         if (result != expected_result) {
//             throw new AssertionError("result is different than the expected result");
//         }
//     }

//     public static void main(String[] args) {
//         TestWithEmptyArray();
//         TestWithUniqueValues();
//         TestWithExactlyTwoDifferentMinimums();
//         System.out.println("OK");
//     }
// }


//
//Day 28: RegEx, Patterns, and Intro to Databases
// //
// class Solution
// {
//   public static void Main(string[] args)
//   {

//     int N = Convert.ToInt32(Console.ReadLine().Trim());
//     List<string> list = new List<string>();
//     string pattern = ".+@gmail\\.com$";
//     Regex regex = new Regex(pattern);
//     //MatchCollection matcher = regex.Matches(email);

//     for (int NItr = 0; NItr < N; NItr++)
//     {
//       string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
//       string name = firstMultipleInput[0];
//       string email = firstMultipleInput[1];
//       if (Regex.IsMatch(email, pattern))
//       {
//         list.Add(name);
//       }
//       //Console.WriteLine(firstMultipleInput[0]);
//     }
//     list.Sort();
//     foreach (String name in list)
//     {
//       Console.WriteLine(name);
//     }

//   }
// }

//
//Day 29: Bitwise AND
// //
// class Result
// {

//   /*
//    * Complete the 'bitwiseAnd' function below.
//    *
//    * The function is expected to return an INTEGER.
//    * The function accepts following parameters:
//    *  1. INTEGER N
//    *  2. INTEGER K
//    */

//   public static int bitwiseAnd(int N, int K)
//   {
//     int max = 0;
//     int ab;

//     for (int i = 1; i <= N; i++)
//     {
//       for (int j = i + 1; j <= N; j++)
//       {
//         ab = j & i;
//         if (Convert.ToInt16(ab) > max && Convert.ToInt16(ab) < K)

//           max = ab;
//       }

//     }
//     return max;
//   }

// }

// class Solution
// {
//   public static void Main(string[] args)
//   {
//     TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//     int t = Convert.ToInt32(Console.ReadLine().Trim());

//     for (int tItr = 0; tItr < t; tItr++)
//     {
//       string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//       int count = Convert.ToInt32(firstMultipleInput[0]);

//       int lim = Convert.ToInt32(firstMultipleInput[1]);

//       int res = Result.bitwiseAnd(count, lim);

//       textWriter.WriteLine(res);
//     }

//     textWriter.Flush();
//     textWriter.Close();
//   }
// }


