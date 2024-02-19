// See https://aka.ms/new-console-template for more information
using ConAppDocker;

Console.WriteLine("****Welcome to Number System ****");
int lnum=int.Parse(Console.ReadLine());
OurNumbers.CountingNum(lnum);
Console.WriteLine("Enter table number");
int num=int.Parse(Console.ReadLine());
OurNumbers.Tables(num);
