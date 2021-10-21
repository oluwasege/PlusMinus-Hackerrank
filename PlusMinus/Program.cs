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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
     {
        int positive = 0, negative = 0, zero = 0,sizeOfList=arr.Count;
       
        foreach (var item in arr)
        {
            if (item < 0)
                negative++;
            else if (item > 0)
                positive++;
            else
                zero++;                   
        }
        string positiveResult = (positive / Convert.ToDecimal(sizeOfList)).ToString("N6");
        string negativeResult = (negative / Convert.ToDecimal(sizeOfList)).ToString("N6");
        string zeroResult = (zero / Convert.ToDecimal(sizeOfList)).ToString("N6");
        Console.WriteLine($"\n{positiveResult}\n{negativeResult}\n{zeroResult}");

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        #region Works
        //Console.Write("Enter the size of the Array: ");    
        //int n = Convert.ToInt32(Console.ReadLine());
        //List<int> arr=new List<int>();
        //for (int i = 0; i <n;i++)
        //{
        //    Console.Write($"Enter Value {i+1}: ");
        //    int value = Convert.ToInt32(Console.ReadLine());
        //    arr.Add(value);
        //}
        #endregion
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();


        Result.plusMinus(arr);
    }
}
