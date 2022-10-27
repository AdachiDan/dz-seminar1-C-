// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number");
int N = int.Parse(Console.ReadLine()!);
int M = N * (-1);

if (N<0)

{
    int temp = N;
    N = M;
    M = temp;
}
   while (M<=N)
   {
    Console.Write(M + " ");
    M++;
   }
//if (N<0)
//   while (N<=M)
//   {
//    Console.Write(N + " ");
//    N++;
//  }

