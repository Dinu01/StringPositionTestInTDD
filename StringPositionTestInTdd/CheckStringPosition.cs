using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StringPositionTestInTdd
{
   public class CheckStringPosition
    {
       public string CheckPosition(string testString)
       {
           if (!string.IsNullOrEmpty(testString))
           {
               var stringContent = testString.Split(' ');
               var testWord = "this";
               var thisWordExist = stringContent.Contains(testWord);
               if (thisWordExist)
               {
                   // var checkIndex=stringContent.
                   int index = Array.IndexOf(stringContent, testWord);

                   if (index == 0)
                   {
                       return "Hi";
                   }
                   else if (index > 0 && index <= stringContent.Length - 2)
                   {
                       return "test pass";
                   }
                   else if (index == stringContent.Length - 1)
                   {
                       return "Valid";
                   }
               }
           }
           return "";
       }
    }
}
