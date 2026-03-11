
//1
//string word = Console.ReadLine();
//char herf = 'a';
//int x = 0;
//for (int i = 0; i < word.Length; i++)
//{
//    if (word[i] == herf)
//    {
//        x = 1;
//        break;
//    }
//}
//if (x == 1)
//{
//    Console.WriteLine("sozde a herfi var");
//}
//else
//{
//    Console.WriteLine("sozde a herfi yoxdur");
//}

//2
//string word = Console.ReadLine();
//char herf = 'a';
//int count = 0;
//for (int i = 0; i<word.Length; i++)
//{
//    if (word[i] == herf)
//    {
//        count++;
//    }
//}
//if (count > 0)
//{
//    Console.WriteLine($"sozde {count} eded a herfi var");
//}
//else
//{
//    Console.WriteLine("sozde a herfi yoxdur");
//}

//3
//int[] arr= [2, 4, 5, 7, 89, 64, 35, 23];
//int cem = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        cem += arr[i];
//    }
//}
//Console.WriteLine(cem);


//4
//string[] words = ["armud", "heyva", "qarga", "raket", "alma"];
//int say = 0;
//char herf = 'r';
//for (int i = 0; i < words.Length; i++)
//{
//   string a = words[i];
//    for (int j = 0; j < a.Length; j++)
//    {
//        if (a[j] == herf)
//        {
//            say++;
//        }
//    }
//}
//Console.WriteLine($"yazilar siyahisinda {say} eded r herfi var");

//5
//int[] ededler = [5, 4, 6];

//for (int i = 0; i < ededler.Length; i++)
//{
//    int fakt = 1;
//    for (int j = 1; j <= ededler[i]; j++)
//    {
//        fakt *= j;
//    }
//    Console.WriteLine(fakt);
//}

//6
//int[] ededler = [7, 12, 5, 8];
//int min = ededler[0];
//for (int i = 0; i < ededler.Length; i++)
//{
//    if (ededler[i] < min)
//    {
//        min = ededler[i];
//    }
//}for (int i = 0; i < ededler.Length; i++)
//{
//    if (ededler[i] != min)
//    {
//        Console.WriteLine(ededler[i]);
//    }
//}


// 1
//int[] ededler = [23, 564, 76, 3, 34, 745, 900];
//int cem = 0;
//for (int i = 0; i < ededler.Length; i++)
//{
//    if(ededler[i] >=10 && ededler[i] <= 99)
//    {
//        cem += ededler[i];
//    }
//}
//Console.WriteLine($"Siyahidaki 2 reqemli ededlerin cemi {cem}-e beraberdir");

//2
//int[] ededler = [1, 2, 3, 4, 5, 6, 7, 8, 9];
//int[] cut=new int[20];
//int[] tek=new int[20];
//for (int i = 0; i < ededler.Length; i++)
//{
//    if(ededler[i] % 2 == 0)
//    {
//        cut[i] = ededler[i];

//    }
//    else
//    {
//        tek[i] = ededler[i];

//    }

//}
//Console.WriteLine("cut ededler");
//for (int i = 0;i < cut.Length; i++)
//{
//    if (cut[i] != 0)
//    {
//        Console.Write(cut[i]);
//    }
//}
//Console.WriteLine("\ntek ededler");
//for (int i = 0;i< tek.Length; i++)
//{
//    if (tek[i] != 0)
//    {
//        Console.Write(tek[i]);
//    }
//}

//3
//int[] ededler = [4, 5, 6, 3, 65, 34, 523, 15, 2345,];
//int eded =4;
//int index = -1;
//for (int i = 0; i < ededler.Length; i++)
//{
//    if (ededler[i] == eded)
//    {
//        index = i;

//    }
//}
//Console.WriteLine(index);

//4

//string m=Console.ReadLine();
//if (m.Length%2 == 0)
//{
//    Console.Write(m[m.Length/2-1]);
//    Console.Write(m[m.Length/2]);
//}
//else
//{
//    Console.WriteLine(m[m.Length/2]);
//}

//5
//int[] ededler = [65, 74, 5, 4, 2, 9, 67, 28];
//int cutcem = 0;
//int tekcem = 0;
//for (int i = 0; i < ededler.Length; i++)
//{
//    if (i % 2 == 0)
//    {
//        cutcem += ededler[i];
//    }
//    else
//    {
//        tekcem += ededler[i];
//    }
//}
//Console.WriteLine(tekcem-cutcem);

// 

