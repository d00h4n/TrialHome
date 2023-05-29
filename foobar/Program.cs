﻿using foobar;
using System;

public class Program {
    public static void Main(string[] args) {

        Console.Write("Masukkan nilai bilangan Minimum: ");
        int i = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan nilai bilangan Maximum: ");
        int y = Convert.ToInt32(Console.ReadLine());
        
        Algorithm.CheckNumber(i, y);
    }
        
}