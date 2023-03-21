namespace HW_3_2
{
    public static class Program
    { 
            public static void Show(bool value)
            {
                Console.WriteLine(value ? "Yes" : "No");
            }

            public static void Main()
            {
                Class1 class1 = new Class1();
                Class2 class2 = new Class2();
                Func<int, int, int> powDelegate = new Func<int, int, int>(class1.Pow);
                Class1.ShowDelegate showDelegate = class2.Calc(powDelegate, 5, 3);
                showDelegate(class2.Result(15));
            }
        }
    }
