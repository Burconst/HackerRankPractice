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

namespace Algorithm.Strings
{
    public static class Easy 
    { 
        // Super Reduced String
        // Source: https://www.hackerrank.com/challenges/reduced-string/problem
        static string SuperReducedString(string s) 
        {
            Regex bp = new Regex (@"([a-z])\1{1}");
            var result = new StringBuilder(s);
            while(bp.IsMatch(result.ToString())) 
            {
                result.Replace(bp.Match(result.ToString()).Value, "");
            }

            return result.ToString();
        }



    } 
}