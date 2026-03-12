namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //int number = 55;
            //Nums(number);
            //2
            //int x=Convert.ToInt32(Console.ReadLine()); 
            //int y=Convert.ToInt32(Console.ReadLine());
            //Pow(x, y);
            //3
            //int[] nums = [1, 5, 34, 65, 76, 85, 94, 25];
            //SumNums(nums);
            //4
            //int[] arrnums = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            //Max(arrnums);
            //5
            //int x= Convert.ToInt32(Console.ReadLine());
            //int y= Convert.ToInt32(Console.ReadLine());
            //BigNum(x, y);
            //6
            //string[] s=["salam", "anar", "hesen"];
            //Combine(s);
            //7
            //SumNumber(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
            //8




        }
        public static void BigNum1(int x, int y, int z)
        {
            int[] arr= {x, y, z};
            int max=arr[0];
            int min=arr[0];
            int avg=arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if ( )
                {

                }
            }
        }




        public static void SumNumber(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum+= nums[i];
            }
            Console.WriteLine(sum);
        }




        public static void Combine(string[] s)
        {
            string con = "";
            for (int i = 0; i < s.Length; i++)
            {
                con += s[i]+" ";
            }
            Console.WriteLine(con);
        }



        public static void BigNum(int x, int y)
        {
            
            if (x > y)
            {
                x *= 10;
                x += y;
                Console.WriteLine(x);
            }
            else
            {
                y *= 10;
                y += x;
                Console.WriteLine(y);
            }
        }

        public static void Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 0;i < arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max= arr[i];
                }
            }
            Console.WriteLine(max);
        }

        public static void SumNums(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 5 == 0)
                {
                    sum += nums[i];
                }
            }
            Console.WriteLine(sum);
        }

        public static void Pow(int x, int y)
        {
           double m=Math.Pow(x, y);
            Console.WriteLine(m);
        }
        public static void Nums(int n)
        {
            int count = 0;
            for (int i = 10; i <= n; i++)
            {
                if (i < 100)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
