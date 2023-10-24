namespace arraysiniflari;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi={25,45,788,5125,66,8456};

        //Array.Sort
        Console.WriteLine("*****ArraySort******");
        Console.WriteLine("***sırasız dizi:");
        foreach(var sayi in dizi){
            Console.WriteLine(sayi);
        }
        Console.WriteLine("***sıralı dizi");
        Array.Sort(dizi);

        foreach(var sayi in dizi){
            Console.WriteLine(sayi);
        }
        //Array.Clear
        Console.WriteLine("*****ArrayClear******");
        Array.Clear(dizi, 2,2);
        foreach(var sayi in dizi)
           Console.WriteLine(sayi);

        // Array.reverse
        Console.WriteLine("*****ArrayReverse******");
        Array.Reverse(dizi);
        foreach(var sayi in dizi)   Console.WriteLine(sayi);

        // Araay.IndexOf
        Console.WriteLine("*****ArrayIndexOf******");
        Console.WriteLine(Array.IndexOf(dizi,45));
        // Resize
        Console.WriteLine("*****Resizef******");
        Array.Resize<int>( ref dizi,9);
        dizi[6]=22;
        foreach(var sayi in dizi)   Console.WriteLine(sayi);


    }
}
