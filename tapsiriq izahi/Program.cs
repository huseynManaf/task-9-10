namespace tapsiriq_izahi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task9
            //int n =int.Parse(Console.ReadLine());
            //int[] mass = new int[n];
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    Console.Write($"mass[{i}]");
            //mass[i] = int.Parse(Console.ReadLine()); 

            //}
            //int max = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (mass[max] < mass[i])
            //        max = i;
            //}
            //Console.WriteLine($"max indeks = [{max}]");
            #endregion
            {
                #region task 10
                int n = int.Parse(Console.ReadLine());
                int[] mass = new int[n];
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write($"mass[{i}]");
                    mass[i] = int.Parse(Console.ReadLine());

                }
                int min = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[min] > mass[i])
                        min = i;
                }
                Console.WriteLine($"max indeks = [{min}]");
                #endregion
            }
        }
    }
}