using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika1
{
    class Program
    {
        static void Main(string[] args)
        {


            int N = 10;

            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = i + 1;
            }
            for (int i = N - 1; i >= 0; i--)
            {
                Console.Write(array[i].ToString() + " ");
            }
            Console.WriteLine();


            int razmer = 6;
            int[,] array2 = new int[razmer, razmer];
            for (int i = 0, j = 0, count = 0; i < razmer && j < razmer;)
            {
                if (j <= 1)
                {
                    array2[i, j] = 1;


                    if (i == razmer - 1)
                    {
                        i = 0;
                        j++;
                    }
                    else
                    {
                        i++;
                    }

                    continue;
                }

                if (j > 1 && count == -1)
                {
                    array2[i, j] = 1;

                    if (i == razmer - 1)
                    {
                        count = 0;
                        i = 0;
                        j++;
                    }
                    else
                    {
                        i++;
                    }
                    continue;
                }

                if (j > 1)
                {
                    count = -1 + j;
                    for (; count > 0; count--)
                    {
                        array2[i, j] = 0;
                        i++;
                    }
                    count = -1;
                }

            }
            for (int j = 0; j < razmer; j++)
            {
                Console.WriteLine();
                for (int i = 0; i < razmer; i++)
                {
                    Console.Write(array2[i, j].ToString() + " ");

                }
            }



            for (int i = 0, j = 0, count = 1, count2 = 1; ;)
            {
                for (; i < razmer - count2; i++, count++)
                {
                    array2[i, j] = count;
                }
                if (count == razmer * razmer)
                {
                    array2[i, j] = count;
                    break;
                }
                for (; j < razmer - count2; j++, count++)
                {
                    array2[i, j] = count;
                }
                for (; i >= 0 + count2; i--, count++)
                {
                    array2[i, j] = count;
                }
                count2++;
                for (; j >= 0 + count2; j--, count++)
                {
                    array2[i, j] = count;
                }
            }

            Console.WriteLine();

            for (int j = 0; j < razmer; j++)
            {
                Console.WriteLine();
                for (int i = 0; i < razmer; i++)
                {
                    Console.Write(array2[i, j].ToString() + " ");

                }
            }
            Console.WriteLine();

            int M, K;
            Console.Write("Введите кол-во строк: ");
            M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов: ");
            K = Convert.ToInt32(Console.ReadLine());
            int[][] array3 = new int[K][];
            for (int j = 0; j < K; j++)
            {
                array3[j] = new int[M];
            }

            for (int i = 0, j = 0, count = 1, count2 = 1; ;)
            {
                for (; j < M - count2; j++, count++)
                {
                    if (count > M * K)
                    {
                        break;
                    }
                    array3[i][j] = count;
                }
                if (count == M * K)
                {
                    array3[i][j] = count;
                    break;
                }
                for (; i < K - count2; i++, count++)
                {
                    if (count > M * K)
                    {
                        break;
                    }
                    array3[i][j] = count;
                }
                for (; j >= 0 + count2; j--, count++)
                {
                    if (count > M * K)
                    {
                        break;
                    }
                    array3[i][j] = count;
                }
                count2++;
                for (; i >= 0 + count2; i--, count++)
                {
                    if (count > M * K)
                    {
                        break;
                    }
                    array3[i][j] = count;
                }
                if (count > M * K)
                {
                    break;
                }
            }

            Console.WriteLine();

            for (int j = 0; j < M; j++)
            {
                Console.WriteLine();
                for (int i = 0; i < K; i++)
                {
                    Console.Write(array3[i][j].ToString() + " ");

                }
            }


        }
    }
}
