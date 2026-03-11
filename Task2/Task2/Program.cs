//int a = 0;
//int b = 0;
//for (int i = 1; i <= 500; i++)
//{
//    if (i % 2 == 0)
//    {
//        a += i;
//    }
//    else
//    {
//        b += i;
//    }
//}
//int c = b - a;

//if (c > 0)
//{
//    Console.WriteLine($"1-500 arasindaki ededlerin ferqi musbetdir. eded {c}");
//}
//else
//{
//    Console.WriteLine($"1-500 arasindaki ededlerin cemi menfidir. eded {c}");
//}


//int[] fib = new int [10];
//fib[0] = 0;
//fib[1] = 1;
//for (int i = 2; i <10; i++)
//{
//    fib[i] = fib[i - 1] + fib[i - 2];
//}
//for (int i = 0; i <10; i++)
//{
//    Console.WriteLine(fib[i]);
//}

//string soz = "Feyzullah";
//char[] s = new char [soz.Length];

//for (int i = 0; i < soz.Length; i++)
//{
//    s[i]= soz[soz.Length-1-i];
//    Console.Write(s[i]);
//}

// verilmis arrayde en boyuk ededin tapilmasi
//int[] arr = [22, 45, 78, 12, 89, 1, 33];
//int max = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > max)
//    {
//        max = arr[i];
//    }
//}
//Console.WriteLine(max);

//int[] arr = [22, 45, 78, 12, 89, 1, 33];
//int min=arr[0];
//for(int i=1; i < arr.Length; i++)
//{
//    if(arr[i] < min)
//    {
//        min = arr[i];
//    }
//}
//Console.WriteLine(min);

//armstrong ededi olub olmadigini yoxlayin 
//string eded = Console.ReadLine();
//int cem = 0;

//for (int i = 0; i< eded.Length; i++)
//{
//    int a = int.Parse(eded[i].ToString());
//    int result = a * a * a;
//    cem += result;
//}
//if(Convert.ToInt32(eded) == cem)
//{
//    Console.WriteLine($"{eded}- Armstrong ededidir");
//}
//else
//{
//    Console.WriteLine($"{eded}- Armstrong ededi deyil");
//}

//int eded =Convert.ToInt32(Console.ReadLine());
//int count  = 0;
//for (int i = 1; i <= eded; i++)
//{
//    if (i % 3 == 0)
//    {
//        count ++;
//    }
//}
//Console.WriteLine(count);

//int eded =Convert.ToInt32(Console.ReadLine());
//int cem = 0;
//int count = 0;
//for (int i = 1; i <= eded; i++)
//{
//    if (i%5 == 0)
//    {
//        cem += i;
//        count++;
//    }
//}
//if (count > 0)
//{
//    int edediOrta = cem / count;
//    Console.WriteLine("5-e bolunenlerin ededi ortasi: " + edediOrta);
//}
//int n=Convert.ToInt32(Console.ReadLine());
//int m=Convert.ToInt32(Console.ReadLine());
//int cem = 0;
//for(int i = n + 1; i < m; i++)
//{
//    if (i % 2 == 0)
//    {
//        cem += i;
//    }
//}
//Console.WriteLine(cem);


//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());
//int netice = 1;
//for (int i = 0; i < y; i++)
//{
//    netice *= x;
//}
//Console.WriteLine(netice);



//int n = int.Parse(Console.ReadLine());

//int cem = 0;

//for (int i = 1; i <= n; i++)
//{
//    int eded = int.Parse(Console.ReadLine());
//    cem += eded; 
//}

//Console.WriteLine($"Daxil edilen {n} sayda ədədin cəmi: {cem}");


//int n = Convert.ToInt32(Console.ReadLine());
//int m=Convert.ToInt32(Console.ReadLine());
//int cem = 0;
//for (int i = n + 1; i < m; i++)
//{
//    if (i % 10 == 0)
//    {
//        cem += i;
//    }
//}
//Console.WriteLine(cem);


//int hasil = 1;
//int eded;
//bool herHansiEdedDaxilEdilib = false;

//Console.WriteLine("Ededləri daxil edin (Dayandirmaq üçün 0 yazin):");

//while (true)
//{
//    Console.Write("Eded: ");
//    eded = Convert.ToInt32(Console.ReadLine());

//    if (eded == 0)
//    {
//        break;
//    }

//    hasil *= eded;
//    herHansiEdedDaxilEdilib = true;
//}

//if (herHansiEdedDaxilEdilib)
//        {
//    Console.WriteLine("Daxil edilmiş ededlerin hasili: " + hasil);
//}
//        else
//{
//    Console.WriteLine("Heç bir eded daxil edilmedi.");
//}


//string x = "Anar";
//bool a = true;
//while (a)
//{
//    Console.WriteLine("kodu daxil edin.");
//    string n=Console.ReadLine();
//    if (n ==x)
//    {
//        a= false;
//    }
//}
//Console.WriteLine("kodu duzgun daxil etdiniz!");

//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());
//int z = -1;
//for (int i = 1; i <= x; i++)
//{
//    if (y % i == 0)
//    {
//        z = i;
//    }
//}
//Console.WriteLine(z);

//int[] ard = [34, -9, -78, 45, 64, 75, -32];
//for (int i = 0; i < ard.Length; i++)
//{
//    if (ard[i] > 0)
//    {
//        ard[i] += 2;
//    }
//    Console.Write(ard[i] + " ");
//}


//int x=Convert.ToInt32(Console.ReadLine());
//bool a =true;
//for(int i=2; i<x-1; i++)
//{
//    if (x % i == 0)
//    {
//        Console.WriteLine("eded murekkebdir");
//        a= false;
//        break;
//    }
//}
//if (a)
//{
//    Console.WriteLine("sadedi");
//}

// verilmis n ededinin 2nin quvveti olub olmadigini yoxla 
//int n = Convert.ToInt32(Console.ReadLine());

//while (n % 2 == 0 & n > 1)
//{
//    n /= 2;
//}
//if (n == 1)
//{
//    Console.WriteLine("eded 2nin quvvetidir");
//}
//else
//{
//    Console.WriteLine("eded 2nin quvveti deyil");
//}

//string meyve=Console.ReadLine();
//double ceki = Convert.ToDouble(Console.ReadLine());
//switch (meyve.ToLower().Trim())
//{
//    case "alma":
//        Console.WriteLine($"Mehsulun qiymeti {ceki * 1.5}");
//        break;
//    case "armud":
//        Console.WriteLine($"Mehsulun qiymeti {ceki * 2}");
//        break;
//    case "heyva":
//        Console.WriteLine($"Mehsulun qiymeti {ceki * 3.5}");
//        break;
//    case "banan":
//        Console.WriteLine($"Mehsulun qiymeti {ceki * 4}");
//        break;
//    default:
//        Console.WriteLine("Bu mehsul stokda yoxdur");
//        break;
//}



