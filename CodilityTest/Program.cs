using System;

namespace CodilityTest
{
    class Program
    { 
        static void Main(string[] args)
        {
            int[] A = { 1, 3, 2, 5, 6 };
            int[] B = { 1, 3, 2, 4, 6 };
            int[] C = { 13,2,6,8,9,1,3,4,5,7,11,12};
            Array.Sort(A,B);
            Array.Sort(C);
            int sM = 1;
            int sMB = 1;
            int ans = 1;
           

            for (int i = 0; sM == A[i]; i++)
            {
                sM++;
            }
            Console.WriteLine(sM);

           for(int i = 0; sMB == B[i]; i++)
            {
                sMB++;
            }
            Console.WriteLine(sMB);
            for (int i = 0; ans == C[i]; i++)
            {
                ans++;
            }
            Console.WriteLine(ans);


        }
       
    }
}
