using System;
using System.Collections.Generic;
using System.Linq;

namespace CyclicRotation {
    class Solution {
        public int[] solution(int[] A, int K) {

            int[] values = A;

            for (int i = 0; i < K; i++) {
                values = Swap(values);
            }

            return values;

        }

        private int[] Swap(int[] intArray) {
            int[] newArray = new int[intArray.Length];

            if (newArray.Length == 0) {
                return newArray;
            } else {
                newArray[0] = intArray[intArray.Length - 1];

                for (int i = 0; i < intArray.Length - 1; i++) {
                    newArray[i + 1] = intArray[i];
                }

                return newArray;
            }

        }
    }

    class MainClass {
        public static void Main(string[] args) {
            int[] values = { 3, 8, 9, 7, 6 };
            var k = 3;

            var sol = new Solution();

            foreach (var item in sol.solution(values, k)) {
                Console.Write(item);
            }

        }
    }
}
