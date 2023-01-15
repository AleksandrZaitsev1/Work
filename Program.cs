//System.Console.Write("-->");
//int a = Convert.ToInt32(Console.ReadLine());

//int i = -1 * a;

//while (i<= a)
//{
    //System.Console.WriteLine(i);
  //  i++;
//};
System.Console.Write("-->");
int a = Convert.ToInt32(Console.ReadLine());

if ( a < 100 || a > 999){
    System.Console.WriteLine("Ошибка");

}

else
{
    int b = a % 10;
    System.Console.WriteLine(b);
}