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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        // array already given - arr
        // type of bird represented by NUM ID - freq
        // find most frequently sighted type by NUM ID -mostFreqsight
        // compare each element to each element! for loop. for(x = 0; x < arr; x++)
        // return an integer of most frequent bird id.
        // b = base
        arr.Sort();
        int freq = arr[0];
        int mostFreqSight = 1;
        int count = 0;
        
        /* 6
        1 4 4 4 5 3
        */
        
        // parent for loop
        for(int b = 0; b < arr.Count; b += count)
        {   //nested for loop
            count = 0;
            for(int z = 0; z < arr.Count; z++)
            {   //comparison
                if(arr[b] == arr[z]) // arr[b]=0 arr[z]=0 [1=1=true/increment]
                {
                    count++;
                }
                if(mostFreqSight < count)
                {
                    freq = arr[b];
                    mostFreqSight++;
                }
            }   
        }
        
        return freq;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
