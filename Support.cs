using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug_Exercise {
    class Support {
        public const int MAX = 199;
        public const int MIN = 110;
        static int seed = new Random().Next();

        public static int GetSeed() {
            return seed;
        }

        public static string GetName(string name) {
            name = ReverseString(name);
            return name;
        }

        public static int GetAge(int age) {
            return age - 100;
        }

        private static string ReverseString(string source) {
            string result = "";
            for (int ndx = source.Length - 1; ndx >= 0; ndx--) {
                result += source[ndx];
            }
            return result;
        }
        static int Test3(String input) {
            return Int32.Parse(input);
        }

        static sbyte Test4(String input) {
            return SByte.Parse(input);
        }
        static double Test5(String input) {
            return Double.Parse(input);
        }
        static ushort Test6(String input) {
            return UInt16.Parse(input);

        }
        static float Test7(String input) {
            return float.Parse(input);
        }
        static uint Test8(String input) {
            return UInt32.Parse(input);
        }
        static short Test9(String input) {
            return Int16.Parse(input);
        }
        static ulong Test10(String input) {
            return UInt64.Parse(input);
        }
    }
}

