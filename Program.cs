﻿

using System;


class Program
  {
    static int add(int a,int b){
    return a+b;
}
    static int sub(int a,int b){
    return a-b;
}
    static int multi(int a,int b){
    return a*b;
}
    static int rem(int a,int b){
    return a/b;
}
    static int quo(int a,int b){
    return a%b;
}
    static void Main(string[] jerry)
    {
          int a = Convert.ToInt32(Console.ReadLine());
          int b = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine(add(a,b));
          Console.WriteLine(sub(a,b));
          Console.WriteLine(multi(a,b));
          Console.WriteLine(rem(a,b));
          Console.WriteLine(quo(a,b));
    }
  }