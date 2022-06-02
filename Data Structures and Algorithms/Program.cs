using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("-----------------Data Sructures Algorithm Programs------------------------");
                Console.WriteLine("--------------------------------------------------------------------------\n");
                Console.WriteLine("1.Permutation Using Recursion\n2.InsertionSort\n3.BubbleSort\n4.MergeSort\n5.Anagram\n6.PrimeNumbers\n");
                Console.WriteLine("Enter Your Option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.Write("Enter the string : ");
                        String inputString = Console.ReadLine();
                        String answer = "";
                        Console.Write("\nAll possible strings are : ");
                        PermutationOfString.permutation(inputString, answer);
                        break;

                    case 2:
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.Insertion_Sort();
                        break;

                    case 3:
                        BubbleSort sort = new BubbleSort();
                        sort.Bubble_Sort();
                        break;

                    case 4:
                        MergeSort mergeSort = new MergeSort();
                        mergeSort.Merge_sort();
                        break;

                    case 5:
                        Anagram anagram = new Anagram();
                        anagram.Detect_Anagram();
                        break;

                    case 6:
                        PrimeNumbers prime = new PrimeNumbers();
                        prime.Check_Prime();
                        break;
                    
                    default:
                        Console.WriteLine("-------Enter the valid option---");
                        break;
                }
                Console.WriteLine("\nDo you want to continue");
                flag = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}