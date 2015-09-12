using System;

namespace Palindrome
{
    class Program
    {
        const int SpaceChar = '\u0020';

        static bool IsPalindrome(string s)
        {
            var increasingIndex = 0;
            var decreasingIndex = s.Length - 1;

            var forwardIndexCount = increasingIndex;
            var reverseIndexCount = decreasingIndex;

            while (forwardIndexCount <= reverseIndexCount)
            {
                var a = s[increasingIndex];
                var b = s[decreasingIndex];
                var skip = false;

                if (a == SpaceChar)
                {
                    increasingIndex++;
                    reverseIndexCount--;
                    skip = true;
                }

                if (b == SpaceChar)
                {
                    decreasingIndex--;
                    reverseIndexCount--;
                    skip = true;
                }

                if (skip)
                    continue;

                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }

                increasingIndex++;
                decreasingIndex--;

                forwardIndexCount++;
                reverseIndexCount--;
            }

            return true;
        }

        static void Check(string s, bool shouldBePalindrome)
        {
            Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
        }

        static void Main()
        {
            Check("abcba", true);
            Check("abcde", false);
            Check("Mr owl ate my  metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);

            Console.ReadLine();
        }
    }
}
