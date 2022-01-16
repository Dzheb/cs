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
//
// string s = "Always-Look-on-the-Bright-Side-of-Life";
// int k = 5;
// {

//   //alphabet symbols
//   const string alfabetLower = "abcdefghijklmnopqrstuvwxyz";
//   const string alfabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

//   //to add small letters in alphabet

//   var letterQty = alfabetLower.Length;
//   var retVal = "";
//   for (int i = 0; i < s.Length; i++)
//   {
//     var c = s[i];
//     var indexLower = alfabetLower.IndexOf(c);
//     var indexUpper = alfabetUpper.IndexOf(c);

//     if (indexUpper < 0 && indexLower < 0)
//     {
//       //if index not found add like it is
//       retVal += c.ToString();
//     }


//     if (indexLower >= 0 && indexUpper < 0)
//     {
//       var codeIndex = (letterQty + indexLower + k) % letterQty;
//       retVal += alfabetLower[codeIndex];
//     }

//     if (indexUpper >= 0 && indexLower < 0)
//     {
//       var codeIndex = (letterQty + indexUpper + k) % letterQty;
//       retVal += alfabetUpper[codeIndex];


//     }

//   }

//   Console.WriteLine(retVal);
//   //return retVal; 
// }
//


// class Result
// {

//   /*
//    * Complete the 'timeConversion' function below.
//    *
//    * The function is expected to return a STRING.
//    * The function accepts STRING s as parameter.
//    */

//   public static string timeConversion(string s)
//   {
//     DateTime myDate = Convert.ToDateTime(s);
//     return myDate.ToString("HH:mm:ss");

//   }

// }

// class Solution
// {
//   public static void Main(string[] args)
//   {
//     //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
//     string numbers = string.Empty;
//     System.Console.WriteLine("Размер массива N");
//     int n = Convert.ToInt16(Console.ReadLine());
//     System.Console.WriteLine("Введите числа через запятую '1,-2,3,...");
//     numbers = numbers + Console.ReadLine();
//     string[] num = numbers.Split(' ');
//     int[] arr = new int[n];
//     for (int i = 0; i < arr.Length; i++)
//     {
//       arr[i] = Convert.ToInt16(num[i]);
//     }
//     Array.Sort(arr);
//     PrintArray(arr);
//     Console.WriteLine(" ");

//     Console.WriteLine(arr[(int)arr.Length / 2]);

//     void PrintArray(int[] array)
//     {
//       int count = array.Length;
//       for (int i = 0; i < count; i++)
//       {
//         Console.Write($"{array[i]} ");
//       }
//     }


//     string s = Console.ReadLine();

//     string result = Result.timeConversion(s);
//     System.Console.WriteLine(result);

//     //  textWriter.WriteLine(result);

//     // textWriter.Flush();
//     // textWriter.Close();
//   }
// }


// class Result
// {

//   /*
//    * Complete the 'plusMinus' function below.
//    *
//    * The function accepts INTEGER_ARRAY arr as parameter.
//    */

//   public static void plusMinus(List<int> arr)
//   {
//     double neg = 0;
//     double pos = 0;
//     double zero = 0;
//     for (int i = 0; i < arr.Count; i++)
//     {
//       if (arr[i] > 0) pos++;
//       if (arr[i] < 0) neg++;
//       if (arr[i] == 0) zero++;
//     }
//     Console.WriteLine(String.Format("{0:F6}", (double)(pos / arr.Count)));
//     Console.WriteLine(String.Format("{0:F6}", (double)(neg / arr.Count)));
//     Console.WriteLine(String.Format("{0:F6}", (double)(zero / arr.Count)));

//   }

// }

// class Solution
// {
//   public static void Main(string[] args)
//   {
//     int n = Convert.ToInt32(Console.ReadLine().Trim());

//     List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//     Result.plusMinus(arr);
//   }
// }

// class Result
// {

//   /*
//    * Complete the 'miniMaxSum' function below.
//    *
//    * The function accepts INTEGER_ARRAY arr as parameter.
//    */

//   public static void miniMaxSum(List<int> arr)
//   {
//     arr.Sort();

//     long minSum = 0;
//     long maxSum = 0;
//     for (int i = 0; i < arr.Count - 1; i++)
//     {
//       minSum = minSum + arr[i];
//     }
//     for (int i = 1; i < arr.Count; i++)
//     {
//       maxSum = maxSum + arr[i];

//     }

//     Console.WriteLine($"{minSum} {maxSum}");
//   }

// }

// class Solution
// {
//   public static void Main(string[] args)
//   {

//     List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//     Result.miniMaxSum(arr);
//   }
// }

// int result = -2;
// string text = "ddbd";
// char[] obrtext = text.ToCharArray();
// Array.Reverse(obrtext);
// string finaltext = new string(obrtext);
// if (text == finaltext)
// {
//   result = -1;
// }
// if (text != finaltext)
// {
//   string tmptext = text;
//   for (int i = 0; i < text.Length; i++)
//   {
//     tmptext = text.Remove(i, 1);
//     obrtext = tmptext.ToCharArray();
//     Array.Reverse(obrtext);
//     finaltext = new string(obrtext);

//     if (tmptext == finaltext)
//     {
//       Console.WriteLine(tmptext);
//       Console.WriteLine(finaltext);
//       Console.WriteLine(i);
//       result = i;
//       break;
//     }

//   }
// }

// Console.WriteLine(text);
// Console.WriteLine(obrtext);
// Console.WriteLine(result);
// результатом будет "Строка s1 перед строкой s2"

//Zigzag sequence  C++
//
// void findZigZagSequence(vector < int > a, int n){
//     sort(a.begin(), a.end());
//     int mid = (n)/2;
//     swap(a[mid], a[n-1]);

//     int st = mid + 1;
//     int ed = n - 2;
//     while(st <= ed){
//         swap(a[st], a[ed]);
//         st = st + 1;
//         ed = ed - 1;
//     }
//     for(int i = 0; i < n; i++){
//         if(i > 0) cout << " ";
//         cout << a[i];
//     }
//     cout << endl;
// }


// Enter 2 string and split to odd and even char substrings
// using System;
// using System.Collections.Generic;
// using System.IO;
// class Solution {
//     static void Main(String[] args) {
//         int T = Convert.ToInt16(Console.ReadLine());

//         for(int j = 0;j < T; j++)
//         {
//             string sLine = Console.ReadLine();
//              string s1LineOut = string.Empty;
//             string s2LineOut = string.Empty;
//         for(int i = 0;i < sLine.Length;i++)
//         {
//             if( i % 2 == 0) s1LineOut = s1LineOut + sLine[i];
//             if( i % 2 != 0) s2LineOut = s2LineOut + sLine[i];
//         }

//         Console.WriteLine($"{s1LineOut} {s2LineOut}");
//         }
//         /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
//     }
// }
// LinkedList<int> numbers = new LinkedList<int>();

// numbers.AddLast(1); // вставляем узел со значением 1 на последнее место
//                     // так как в списке нет узлов, то последнее будет также и первым
// numbers.AddFirst(2); // вставляем узел со значением 2 на первое место
// numbers.AddAfter(numbers.Last, 3); // вставляем после последнего узла новый узел со значением 3
//                                    // теперь у нас список имеет следующую последовательность: 2, 1, 3
// numbers.AddAfter(numbers.Last, 7);
// numbers.AddBefore(numbers.Last, 3);
// foreach (int i in numbers)
// {
//   Console.WriteLine(i);
// }

// List<List<int>> keyTimes = new List<List<int>>();
// keyTimes = (0, 2), (1, 5), (0, 9), (2, 15);

// int[][] arr = new int[keyTimes.size()][2];
// int[][] arr = new int[keyTimes.size()][2];
// Console.WriteLine(keyTimes.size());

//
//Merge two sorted linked lists
// //
// class Solution {

//     class SinglyLinkedListNode {
//         public int data;
//         public SinglyLinkedListNode next;

//         public SinglyLinkedListNode(int nodeData) {
//             this.data = nodeData;
//             this.next = null;
//         }
//     }

//     class SinglyLinkedList {
//         public SinglyLinkedListNode head;
//         public SinglyLinkedListNode tail;

//         public SinglyLinkedList() {
//             this.head = null;
//             this.tail = null;
//         }

//         public void InsertNode(int nodeData) {
//             SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

//             if (this.head == null) {
//                 this.head = node;
//             } else {
//                 this.tail.next = node;
//             }

//             this.tail = node;
//         }
//     }

//     static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter) {
//         while (node != null) {
//             textWriter.Write(node.data);

//             node = node.next;

//             if (node != null) {
//                 textWriter.Write(sep);
//             }
//         }
//     }

//     // Complete the mergeLists function below.

//     /*
//      * For your reference:
//      *
//      * SinglyLinkedListNode {
//      *     int data;
//      *     SinglyLinkedListNode next;
//      * }
//      *
//      */
//     static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
//     {
// // Base cases
//     if (head1 == null)
//         return head2;
//     if (head2 == null)
//         return head1;

//     // Pick either a or b, and recur
//     if (head1.data < head2.data)
//     {
//         head1.next = mergeLists(head1.next, head2);
//         return head1;
//     }
//     else
//     {
//         head2.next = mergeLists(head1, head2.next);
//         return head2;
//     }
// }



//     static void Main(string[] args) {
//         TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         int tests = Convert.ToInt32(Console.ReadLine());

//         for (int testsItr = 0; testsItr < tests; testsItr++) {
//             SinglyLinkedList llist1 = new SinglyLinkedList();

//             int llist1Count = Convert.ToInt32(Console.ReadLine());

//             for (int i = 0; i < llist1Count; i++) {
//                 int llist1Item = Convert.ToInt32(Console.ReadLine());
//                 llist1.InsertNode(llist1Item);
//             }

//           	SinglyLinkedList llist2 = new SinglyLinkedList();

//             int llist2Count = Convert.ToInt32(Console.ReadLine());

//             for (int i = 0; i < llist2Count; i++) {
//                 int llist2Item = Convert.ToInt32(Console.ReadLine());
//                 llist2.InsertNode(llist2Item);
//             }

//             SinglyLinkedListNode llist3 = mergeLists(llist1.head, llist2.head);

//             PrintSinglyLinkedList(llist3, " ", textWriter);
//             textWriter.WriteLine();
//         }

//         textWriter.Flush();
//         textWriter.Close();
//     }
// }
