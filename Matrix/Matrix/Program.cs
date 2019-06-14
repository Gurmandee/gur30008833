
/* name = gurmandeep singh
 * Question number 3
 * student id = 30008833
 * */

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[3, 3];            /* A array created with size 3X3 */

            int[,] B = new int[3, 3];            /* B array created with size 3X3 */
            Random random = new Random();
            int num;
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    num = random.Next(-10, 10); /* Random number generated for A array that ranges between -10 and 10 */
                    A[i, j] = num;
                    num = random.Next(-10, 10); /* Random number generated for B array that ranges between -10 and 10 */
                    B[i, j] = num;
                }
            }
            /* output each A array element's value */
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");

            /* output each B array element's value */
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.Write("\n");
            }

            int[,] C = new int[3, 3];            /* C array created with size 3X3 */
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            Console.Write("\nSum Matrix :\n\n");      /* output each C array element's value */
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(C[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
