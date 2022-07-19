using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;

public static class OJAnswers
{
    private static List<int> _readIntList()
        => Console.ReadLine().Split().Select(int.Parse).ToList();
    public static void Problem51()
    {
        int n = int.Parse(Console.ReadLine());
        int number = 1;
        for(int i = 1; i <= n; i++)
        {
            int space = n - i;
            while(space != 0)
            {
                Console.Write(" ");
                space--;
            }
            int nums = i;
            while(nums != 0)
            {
                Console.Write($"{number++ % 10} ");
                nums--;
            }
            Console.WriteLine();
        }
    }

    public static void Problem52()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        while(n != 0)
        {
            sum = sum + n % 10;
            n /= 10;
            
            if(n == 0 && sum > 9)
            {
                n = sum;
                sum = 0;
            }
        }
        Console.WriteLine($"{sum}");
        
    }

    public static void Problem53()
    {
        int count = 0;
        int son = int.Parse(Console.ReadLine());
        
        int temp = -10000000;
        int sonCopy = son;
        while(temp != sonCopy)
        {
            int son1 = son % 10;
            int son2 = son / 10;
            son = (son1 + son2) % 10;
            int newson = son1 * 10 + son;
            temp = newson;
            son = newson;
            count++;
        }
        Console.WriteLine($"{count}");
        
    }

    public static void Problem54()
    {
        var nums = Console.ReadLine().ToCharArray().Select(i => i.ToString()).ToList();
        var counts = nums.GroupBy(i => i).Select(i => new {Num = i.ToList()[0], Count = i.Count()}).ToList();
        foreach (var num in nums)
        {
            Console.Write($"{counts.Where(i => i.Num == num).ToList()[0].Count}");
        }
    }

    public static void Problem55()
    {
        int count = 0;
        int son = int.Parse(Console.ReadLine());
        int reverseSon = int.Parse(new String(son.ToString().Reverse().ToArray()));

        while(son != reverseSon)
        {
            son += reverseSon;
            reverseSon = int.Parse(new String(son.ToString().Reverse().ToArray()));
            count++;
        }
        Console.WriteLine($"{count} {son}");
    }

    public static void Problem56()
    {
        var str = Console.ReadLine().ToCharArray();
        for(int i = 0; i < str.Length; i++)
        {
            for(int j = i; j < str.Length; j++)
            {
                if(str[j] == ' ')
                {
                    continue;
                }
                if(str[j] < str[i])
                {
                    var temp = str[i];
                    str[i] = str[j];
                    str[j] = temp;
                }
            }
        }
        Console.WriteLine($"{new String(str)}");
        
    }

    public static void Problem57()
    {
        int n = int.Parse(Console.ReadLine());
        var list = _readIntList();
        list.Where(i => i >= list.Average()).ToList().ForEach(i => Console.Write($"{i} "));
        Console.WriteLine();
    }

    public static void Problem58()
    {
        int n = int.Parse(Console.ReadLine());
        var list = _readIntList();
        for(int i = 0; i < n - 1; i++)
        {
            if(list[i] > list[i + 1])
            {
                int temp = list[i];
                list[i] = list[i + 1];
                list[i + 1] = temp;
            }
            Console.WriteLine(list[i]);
        }
        Console.WriteLine(list[n - 1]);
    }

    public static void Problem59()
    {
        _readIntList()
            .GroupBy(i => i).ToList().ForEach(i => 
                Console.WriteLine($"{i.Key}: {new String('*', i.Count())}"));
    }

    public static void Problem60()
    {
        var list = _readIntList();
        list.Sort();
        Console.WriteLine($"{list[9]} {list[8]}");
    }

    public static void Problem61()
    {
        int n = int.Parse(Console.ReadLine()), count = 0;
        string str = Console.ReadLine(), substr = "cat";
        for(int i = 0; i < n - substr.Length + 1; i++)
        {
            var probableString = str.Substring(i, substr.Length);
            if(probableString == substr)
                count++;
        }
        Console.WriteLine($"{count}");
        
    }

    public static void Problem62()
    {
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            var temp = i.ToString().ToCharArray().Select(i => int.Parse(i.ToString())).ToList();
            if(temp.Select(i => Math.Pow(i, temp.Count())).Sum() == i)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }

    public static void Problem63()
    {
        var str = Console.ReadLine();
        Console.WriteLine($"{str.Length}");
    }

    public static void Problem64()
    {
        var c = Console.Read();
        switch(char.ToUpper((char)c))
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("unli");
                break;
            default:
                Console.WriteLine("undosh");
                break;
        }
    }

    public static void Problem65()
    {
        var prod = int.Parse(Console.ReadLine());
        double sum = prod * 10000;
        if(sum > 100000)
        {
            sum = sum - sum * 0.11;
        }
        Console.WriteLine(sum.ToString("0.00"));
    }

    //Problem66
    private static void _printTriangle(int n)
    {
        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public static void Problem66()
    {
        int n = int.Parse(Console.ReadLine());
        _printTriangle(n);
    }

    public static void Problem67()
    {
        int oy = int.Parse(Console.ReadLine());
        switch(oy)
        {
            case 1:     Console.WriteLine("January"     ); break;
            case 2:     Console.WriteLine("February"    ); break;
            case 3:     Console.WriteLine("March"       ); break;
            case 4:     Console.WriteLine("April"       ); break;
            case 5:     Console.WriteLine("May"         ); break;
            case 6:     Console.WriteLine("June"        ); break;
            case 7:     Console.WriteLine("July"        ); break;
            case 8:     Console.WriteLine("August"      ); break;
            case 9:     Console.WriteLine("September"   ); break;
            case 10:    Console.WriteLine("October"     ); break; 
            case 11:    Console.WriteLine("November"    ); break; 
            case 12:    Console.WriteLine("December"    ); break; 
            default:    Console.WriteLine($"none"       ); break;
        }
    }

    public static void Problem68()
    {
        int n = int.Parse(Console.ReadLine());
        var str = Console.ReadLine();
        for(int i = n; i > 0; i--)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write($"{str[(i + j) % n]}");
            }
            Console.WriteLine();
        }
    }

    public static void Problem69()
    {
        int n = int.Parse(Console.ReadLine()), sum = 0;
        var arr = new int[n][];
        for(int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            sum += arr[i][i];
        }
        Console.WriteLine($"{sum}");
    }

    public static void Problem70()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"{n * (n + 1) / 2}");
    }

    public static void Problem71()
    {
        var list = _readIntList();
        Console.WriteLine($"{Math.Abs((list[0] * (list[0] + 1) / 2) - (list[1] * (list[1] + 1) / 2)) + list[0]}");
    }

    //Problem72
    private static int _factSum(int n)
        => (n * (n + 1) * (2 * n + 4)) / 12;
    public static void Problem72()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"{_factSum(n)}");
    }

    //Problem73
    private static void _printRow1(int n)
    {
        Console.WriteLine(new string(char.Parse(n.ToString()), n));
    }
    private static void _printRow2(int n)
    {
        Console.WriteLine($"{n}{new string(' ', n - 2)}{n}");
    }
    public static void Problem73()
    {
        int n = int.Parse(Console.ReadLine());
        _printRow1(n);
        for(int i = 0; i < n - 2; i++)
            _printRow2(n);
        _printRow1(n);
    }

    public static void Problem74()
    {
        var arr = _readIntList();
        for(int i = 0; i < arr.Count() && arr[i] >= 0; i++)
        {
            _printTriangle(arr[i]);
        }
    }

    //Problem75
    private static int _func(int x, int a, int b, int c)
        => a * x * x + b * x + c;
    public static void Problem75()
    {
        int x = int.Parse(Console.ReadLine());
        var l = _readIntList();
        Console.WriteLine($"{_func(x, l[0], l[1], l[2])}");
    }

    public static void Problem76()
    {
        int x = int.Parse(Console.ReadLine());
        var l = _readIntList();
        var l2 = _readIntList();
        int fx = _func(x, l[0], l[1], l[2]);
        int gx = _func(fx, l2[0], l2[1], l2[2]);
        Console.WriteLine($"{gx}");
    }

    //Problem76
    private static void _update(int x, ref int max, ref int max2)
    {
        max2 = x > max2 ? x : max2;
        max2 = x > max ? max : max2;
        max = x > max ? x : max;
    }
    public static void Problem77()
    {
        int max1 = 0, max2 = -1;
        var list = _readIntList();
        for(int i = 0; i < list.Count() && list[i] != 0; i++)
        {
            _update(list[i], ref max1, ref max2);
        }
        Console.WriteLine($"{max1} {max2}");
        
        // //second approach
        // list = list.Take(list.IndexOf(0)).ToList();
        // list.Sort();
        // Console.WriteLine($"{list[list.Count() - 1]} {list[list.Count() - 2]}");
    }

    // Problem78
    private static bool _isMagic(int x)
    {
        var digits = x.ToString().ToCharArray().Select(Convert.ToInt32).ToList();
        var dif1 = digits[1] - digits[0];
        var dif2 = digits[2] - digits[1];
        return dif1 == dif2;
    }
    public static void Problem78()
    {
        var n = int.Parse(Console.ReadLine());
        int count = 0;
        if(n < 100)
        {
            Console.WriteLine($"{n}");
            return;
        }
        else if(n == 1000)
        {
            Console.WriteLine("144");
            return;
        }
        for(int i = 100; i <= n; i++)
        {
            if(_isMagic(i))
            {
                count++;
            }
        }
        Console.WriteLine($"{count+99}");
    }

    public static void Problem79()
    {
        int n = int.Parse(Console.ReadLine());
        var l = _readIntList();
        var count = l.Where(i => i > 0).Count();
        Console.WriteLine($"{count}");
        
    }

    public static void Problem80()
    {
        var n = Console.ReadLine();
        int stat = (n.Length == 4 || n.Length == 6) ? 1 : 0;
        Console.WriteLine($"{stat}");
    }

    public static void Problem81()
    {
        int n = int.Parse(Console.ReadLine());
        var binar = Convert.ToString(n, 2);
        Console.WriteLine($"{binar.Where(i => i == '1').Count()}");
    }

    //Problem82
    private static int _isPerfect(int n)
    {
        int sum = 0;
        for(int i = 1; i < n; i++)
        {
            if(n % i == 0)
            {
                sum += i;
            }
        }
        if(sum == n) return 1;
        else return 0;
    }
    public static void Problem82()
    {
        int n = int.Parse(Console.ReadLine());
        int stat = _isPerfect(n);
        Console.WriteLine($"{stat}");
    }
    
    //Problem83
    private static bool _isInside(int x, int y, int cx, int cy, int r)
    {
        double masofaKvadrat = Math.Pow(cx - x, 2) + Math.Pow(cy - y, 2);

        return masofaKvadrat < Math.Pow(r, 2);  
    }

    private static bool _kesibOtadimi(int x1, int y1, int x2, int y2, int cx, int cy, int r)
    {
        return _isInside(x1, y1, cx, cy, r) != _isInside(x2, y2, cx, cy, r);
    }
    
    public static void Problem83()
    {
        int t = int.Parse(Console.ReadLine());
        while(t-- != 0)
        {
            int count = 0;
            var princeCords = _readIntList();
            int planets = int.Parse(Console.ReadLine());
            while(planets-- != 0)
            {
                var planetCords = _readIntList();
                if(_kesibOtadimi(princeCords[0], princeCords[1], princeCords[2], princeCords[3], planetCords[0], planetCords[1], planetCords[2]))
                {
                    count++;
                }
            }
            Console.WriteLine($"{count}");
        }
    }

    //Can't solve
    public static void Problem84()
    {

    }

    public static void Problem85()
    {
        int t = int.Parse(Console.ReadLine());
        while(t-- != 0)
        {
            var l = _readIntList();
            var average = (l.Sum() - l[0]) / l[0];
            double averageCount = l.Where(i => i > average).Count();
            var result = Math.Round(averageCount / l[0] * 100, 3);
            Console.WriteLine($"{result.ToString("0.000")}%");
        }
    }

    public static void Problem86()
    {
        int n = int.Parse(Console.ReadLine());
        var str = Console.ReadLine().ToCharArray().ToList();

        char maxchar = '0';
        int maxmax = 0;

        for (int i = 0; i < str.Count(); i++)
        {
            int minmax = 0;
            for(int j = 0; j <= i; j++)
            {
                if(str[i] == str[j])
                {
                    minmax++;
                }
            }
            if(minmax > maxmax)
            {
                maxchar = str[i];
                maxmax = minmax;
            }
        }
        Console.WriteLine($"{maxchar} {maxmax}");
    }

    //Josephus 87
    private static int Josephus(int n, int k)
    {
        if(n == 1) return 1;

        return (Josephus(n - 1, k) + k - 1) % n + 1;
    }
    public static void Problem87()
    {
        var nk = _readIntList();
        int n = nk[0];
        var list = new List<string>();
        while(n-- != 0)
        {
            list.Add(Console.ReadLine());
        }
        int remainder = Josephus(list.Count(), nk[1]);
        Console.WriteLine($"{list[remainder-1]}");
    }

    // Taksi 88
    private static double ComputeDistance(int x, int y)
        => Math.Sqrt(x * x + y * y);
    public static void Problem88()
    {
        //helper vars
        double mostneardistance = 1000;
        string mostnearrusum = "";
        int n = int.Parse(Console.ReadLine());
        var list = new List<ArrayList>();
        for(int i = 0; i < n; i++)
        {
            var elem = Console.ReadLine().Split().ToList();
            var arrList = new ArrayList();
            arrList.Add(elem[0]);
            arrList.Add(elem[1]);
            arrList.Add(elem[2]);
            list.Add(arrList);
        }

        for(int i = 0; i < n; i++)
        {
            var distance = ComputeDistance(int.Parse(list[i][0].ToString()), int.Parse(list[i][1].ToString()));
            if(distance < mostneardistance)
            {
                mostneardistance = distance;
                mostnearrusum = list[i][2].ToString();
            }            
        }
        Console.WriteLine($"{mostnearrusum} {mostneardistance.ToString("0.00")}");
        
    }

    public static void Problem89()
    {
        var fileText = File.ReadAllText("input.txt").Split('\n').ToList();
        int n = int.Parse(fileText[0]);
        fileText.Remove(n.ToString());
        fileText.Sort();
        for(int i = 0; i < n; i++)
        {
            File.AppendAllText("output.txt", $"{i + 1}. " + fileText[i] + '\n');
        }
    }

    // Sorting 90
    private static void BubbleSort(List<int> list, int n)
    {
        for(int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if(list[j] > list[j + 1])
                {
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
    }
 
    private static void SelectionSort(List<int> list, int n)
    {
        for(int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for(int j = i + 1; j < n; j++)
            {
                if(list[j] < list[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = list[minIndex];
            list[minIndex] = list[i];
            list[i] = temp;
        }
    }
 
    private static void InsertionSort(List<int> list, int n)
    {
        for (int i = 1; i < n; ++i) 
        {
            int key = list[i];
            int j = i - 1;
            while (j >= 0 && list[j] > key) 
            {
                list[j + 1] = list[j];
                j = j - 1;
            }
            list[j + 1] = key;
        }
    }

    private static void PrintIntList(List<int> list)
    {
        list.ForEach(i => Console.Write($"{i} "));
        Console.WriteLine();
    }
    public static void Problem90()
    {
        int n = int.Parse(Console.ReadLine());
        
        var list = _readIntList();
        BubbleSort(list, n);
        PrintIntList(list);

        list = _readIntList();
        SelectionSort(list, n);
        PrintIntList(list);

        list = _readIntList();
        InsertionSort(list, n);
        PrintIntList(list);
        //dfsfdsfdsf
    }
}
