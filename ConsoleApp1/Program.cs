namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n=Convert.ToInt32(Console.ReadLine());
            //Digit(n);
            //string s=Console.ReadLine();
            //Sait(s);
            //int[] n= [15, 34, 65, 54, 12, 65, 7, 5];
            //SumNum(n);
            int[] arr = [13, 21, 2, 6, 5, 8];
            Index(arr);

        }
        public static void Index( int[] n)
        {
            int index = -1;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == 13)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("not found");
            }
            else
            {
                Console.WriteLine(index);
            }
            
        }




        public static void SumNum(int[] n)
        {
            int sum = 0;
            for(int i = 0;i < n.Length; i++)
            {
                for(int j = 2; j < n[i]; j++)
                {
                    if(n[i]%j == 0)
                    {
                        sum += n[i];
                        break;
                    }    
                }
            }
            Console.WriteLine(sum);
        }



        public static void Digit(int n)
        {
            int count = 1;
            while (n>9)
            {
                n /= 10;
                count++;
            }
            Console.WriteLine(count);
        }



        public static void Sait(string s)
        {
            char[] saitler = ['a', 'i', 'e', 'o', 'u'];
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                
                for (int j = 0; j < saitler.Length; j++)
                {
                    if (s[i] == saitler[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
