using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    public class Solution
    {

        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            var res = from t in employees
                      group t by t.Company into g
                      select new { g.Key, Avr = (int)Math.Round(g.Average(x => x.Age)) };
            var dicRes = new SortedDictionary<string, int>();
            foreach (var elem in res) 
            {
                dicRes.Add(elem.Key, elem.Avr);
            }
            return new Dictionary<string, int>(dicRes);
        }
        
        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            var res = from t in employees
                      group t by t.Company into g
                      select new { g.Key, Count = g.Count() };
            var dicRes = new SortedDictionary<string, int>();
            foreach (var elem in res)
            {
                dicRes.Add(elem.Key, elem.Count);
            }
            return new Dictionary<string, int>(dicRes);
        }
        
        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            var res = from t in employees
                      group t by t.Company into g
                      select g;

            var dicRes = new SortedDictionary<string, Employee>();
            foreach (var elem in res)
            {
                foreach (var emp in elem.Where(x => x.Age == elem.Max(t => t.Age))) 
                {
                    dicRes.Add(elem.Key, emp);
                    break;
                }                
            }
            return new Dictionary<string, Employee>(dicRes);
        }

    }
    
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}   