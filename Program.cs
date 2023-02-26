// See https://aka.ms/new-console-template for more information

using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using Calculator;

CalcIMC calc = new CalcIMC();
bool value = false;
do
{
    Console.WriteLine("############ CÁLCULO DO IMC ############");

    Console.WriteLine("Digite sua altura: ");
    decimal h = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite seu peso: ");
    decimal p = Convert.ToDecimal(Console.ReadLine());

    calc.calcimc(p, h);

    Console.WriteLine("Enter yes or no: ");
    var inputString = Console.ReadLine();
    if (String.IsNullOrEmpty(inputString))
    {
        continue;
    }
    if (string.Equals(inputString, "yes"))
    {
        value = true;
    }
    Console.Clear();
} while (!value);