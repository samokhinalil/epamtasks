using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        public char[] array;
        public int length;

        public MyString(string str)
        {
            this.array = str.ToCharArray();
            this.length = str.Length;
        }

        public MyString(int length)
        {
            this.array = new char[length];
            this.length = length;
        }

        public static MyString operator +(MyString str1, MyString str2)
        {
            MyString result = new MyString(str1.array.Length + str2.array.Length);
            str1.array.CopyTo(result.array, 0);
            str2.array.CopyTo(result.array, str1.array.Length);
            return result;
        }

        public static MyString operator -(MyString str1, MyString str2)
        {
            MyString result = new MyString(str1.ToString().Replace(str2.ToString(), string.Empty));
            return result;
        }

        public static bool operator ==(MyString str1, MyString str2)
        {
            if (str1.array.Length != str2.array.Length)
            {
                return false;
            }

            for (int i = 0; i < str1.array.Length; i++)
            {
                if (str1.array[i] != str2.array[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(MyString str1, MyString str2)
        {
            return !(str1 == str2);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in this.array)
            {
                stringBuilder.Append(item);
            }
            return stringBuilder.ToString();
        }
    }
}
