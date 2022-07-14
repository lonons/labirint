using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HomeWork7
{ 
    public static class ExampleExtension
    {
        public static int CharCount(this string str, char x)
        {
            int result = 0;
            for (int i  = 0; i < str.Length; i++)
            {
                if (str[i] == x)
                    result++;
            }
            return result;
        }

    }


}
