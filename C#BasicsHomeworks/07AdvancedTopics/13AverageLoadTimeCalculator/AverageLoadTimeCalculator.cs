using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below. 
//Your tasks is to calculate the average load time for each URL. Print the URLs in the same order as they first appear in the input report. 
//Print the output in the format given below. Use double floating-point precision. 
class AverageLoadTimeCalculator
{
    static void Main()
    {
        string[] inputs = {
        "2014-Apr-01 02:01 http://softuni.bg 8.37725",
        "2014-Apr-01 02:05 http://www.nakov.com 11.622",
        "2014-Apr-01 02:06 http://softuni.bg 4.33",
        "2014-Apr-01 02:11 http://www.google.com 1.94",
        "2014-Apr-01 02:11 http://www.google.com 2.011",
        "2014-Apr-01 02:12 http://www.google.com 4.882",
        "2014-Apr-01 02:34 http://softuni.bg 4.885",
        "2014-Apr-01 02:36 http://www.nakov.com 10.74",
        "2014-Apr-01 02:36 http://www.nakov.com 11.75",
        "2014-Apr-01 02:38 http://softuni.bg 3.886",
        "2014-Apr-01 02:44 http://www.google.com 1.04",
        "2014-Apr-01 02:48 http://www.google.com 1.4555",
        "2014-Apr-01 02:55 http://www.google.com 1.977"
                          };
        Dictionary<string, List<double>> dic = new Dictionary<string, List<double>>();
        //Populate keys
        for (int i = 0; i < inputs.Length; i++)
        {
            string[] current = inputs[i].Split(' ');
            if (!dic.ContainsKey(current[2]))
            {
                dic.Add(current[2], new List<double>());
            }
        }
        //Populate values
        for (int i = 0; i < inputs.Length; i++)
        {
            string[] current = inputs[i].Split(' ');
            string key = current[2];
            double value = Convert.ToDouble(current[3]);
            dic[key].Add(value);
        }
        //Print
        foreach (var adress in dic.Keys)
        {
            double value = dic[adress].Average();//Get average
            Console.WriteLine("{0} -> {1}", adress, value);
        }
    }
}
