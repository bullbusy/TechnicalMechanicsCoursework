// Decompiled with JetBrains decompiler
// Type: Program
// Assembly: kursach_calculate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42F045E3-CB35-4D03-BA75-CC6F9C6E6008
// Assembly location: C:\Users\Nazar\Documents\TelegramDownloads\kursach_calculate.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class Program
{
  public static void Main()
  {
    string[] strArray1 = new string[21]
    {
      "Булавко",
      "Гиренко",
      "Гладун",
      "Гнiденко",
      "Даценко",
      "Iващенко",
      "Карамишев",
      "Кожемякiн",
      "Кубрак",
      "Лiкаренко",
      "Марциненко",
      "Матюк",
      "Миколенко",
      "Нагога",
      "Опанасенко",
      "Оразметова",
      "Поприго",
      "Сариєв",
      "Семенов",
      "Смольянiнов",
      "Хондусь"
    };
    string str1 = (string) null;
    Console.WriteLine("Вибери номер, який вiдповiдає твоєму прiзвищу:");
    for (int index = 0; index < strArray1.Length; ++index)
      Console.WriteLine("{0} - {1}", (object) (index + 1), (object) strArray1[index]);
    Console.WriteLine();
    Stopwatch stopwatch = new Stopwatch();
    int int32 = Convert.ToInt32(Console.ReadLine());
    stopwatch.Start();
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    double num4 = 0.0;
    int num5 = 0;
    double num6 = 0.0;
    double num7 = 0.0;
    double num8 = 0.0;
    int num9 = 0;
    string str2 = "";
    int[] numArray1 = new int[5]{ 25, 35, 50, 65, 75 };
    int[] numArray2 = new int[5]{ 15, 25, 35, 45, 55 };
    int[] numArray3 = new int[5]{ 100, 110, 100, 120, 100 };
    double[] numArray4 = new double[5]
    {
      0.314,
      0.314,
      0.314,
      0.628,
      0.628
    };
    int[] numArray5 = new int[5]{ 20, 80, 40, 40, 60 };
    double[] numArray6 = new double[5]
    {
      1.5,
      2.5,
      3.5,
      4.5,
      6.5
    };
    double[] numArray7 = new double[5]
    {
      0.6,
      0.7,
      0.8,
      0.7,
      0.6
    };
    int[] numArray8 = new int[5]{ 2, 4, 5, 8, 10 };
    int[] numArray9 = new int[5]
    {
      12000,
      15000,
      20000,
      25000,
      30000
    };
    string[] strArray2 = new string[5]
    {
      "ДПР-6",
      "ДПР-6",
      "ДПР-7",
      "ДПР-7",
      "ДПР-7"
    };
    if (int32 == 1)
    {
      num1 = numArray1[0];
      num2 = numArray2[0];
      num3 = numArray3[0];
      num4 = numArray4[0];
      num5 = numArray5[0];
      num6 = numArray6[0];
      num7 = (double) numArray8[0];
      num8 = numArray7[0];
      num9 = numArray9[0];
      str2 = strArray2[0];
      str1 = strArray1[0];
    }
    if (int32 == 2)
    {
      num1 = numArray1[0];
      num2 = numArray2[1];
      num3 = numArray3[1];
      num4 = numArray4[1];
      num5 = numArray5[1];
      num6 = numArray6[1];
      num7 = (double) numArray8[1];
      num8 = numArray7[1];
      num9 = numArray9[1];
      str2 = strArray2[1];
      str1 = strArray1[1];
    }
    if (int32 == 3)
    {
      num1 = numArray1[0];
      num2 = numArray2[2];
      num3 = numArray3[2];
      num4 = numArray4[2];
      num5 = numArray5[2];
      num6 = numArray6[2];
      num7 = (double) numArray8[2];
      num8 = numArray7[2];
      num9 = numArray9[2];
      str2 = strArray2[2];
      str1 = strArray1[2];
    }
    if (int32 == 4)
    {
      num1 = numArray1[0];
      num2 = numArray2[3];
      num3 = numArray3[3];
      num4 = numArray4[3];
      num5 = numArray5[3];
      num6 = numArray6[3];
      num7 = (double) numArray8[3];
      num8 = numArray7[3];
      num9 = numArray9[3];
      str2 = strArray2[3];
      str1 = strArray1[3];
    }
    if (int32 == 5)
    {
      num1 = numArray1[0];
      num2 = numArray2[4];
      num3 = numArray3[4];
      num4 = numArray4[4];
      num5 = numArray5[4];
      num6 = numArray6[4];
      num7 = (double) numArray8[4];
      num8 = numArray7[4];
      num9 = numArray9[4];
      str2 = strArray2[4];
      str1 = strArray1[4];
    }
    if (int32 == 6)
    {
      num1 = numArray1[1];
      num2 = numArray2[0];
      num3 = numArray3[0];
      num4 = numArray4[0];
      num5 = numArray5[0];
      num6 = numArray6[0];
      num7 = (double) numArray8[0];
      num8 = numArray7[0];
      num9 = numArray9[0];
      str2 = strArray2[0];
      str1 = strArray1[5];
    }
    if (int32 == 7)
    {
      num1 = numArray1[3];
      num2 = numArray2[0];
      num3 = numArray3[0];
      num4 = numArray4[0];
      num5 = numArray5[0];
      num6 = numArray6[0];
      num7 = (double) numArray8[0];
      num8 = numArray7[0];
      num9 = numArray9[0];
      str2 = strArray2[0];
      str1 = strArray1[6];
    }
    if (int32 == 8)
    {
      num1 = numArray1[3];
      num2 = numArray2[2];
      num3 = numArray3[2];
      num4 = numArray4[2];
      num5 = numArray5[2];
      num6 = numArray6[2];
      num7 = (double) numArray8[2];
      num8 = numArray7[2];
      num9 = numArray9[2];
      str2 = strArray2[2];
      str1 = strArray1[7];
    }
    if (int32 == 9)
    {
      num1 = numArray1[3];
      num2 = numArray2[1];
      num3 = numArray3[1];
      num4 = numArray4[1];
      num5 = numArray5[1];
      num6 = numArray6[1];
      num7 = (double) numArray8[1];
      num8 = numArray7[1];
      num9 = numArray9[1];
      str2 = strArray2[1];
      str1 = strArray1[8];
    }
    if (int32 == 10)
    {
      num1 = numArray1[3];
      num2 = numArray2[3];
      num3 = numArray3[3];
      num4 = numArray4[3];
      num5 = numArray5[3];
      num6 = numArray6[3];
      num7 = (double) numArray8[3];
      num8 = numArray7[3];
      num9 = numArray9[3];
      str2 = strArray2[3];
      str1 = strArray1[9];
    }
    if (int32 == 11)
    {
      num1 = numArray1[4];
      num2 = numArray2[1];
      num3 = numArray3[1];
      num4 = numArray4[1];
      num5 = numArray5[1];
      num6 = numArray6[1];
      num7 = (double) numArray8[1];
      num8 = numArray7[1];
      num9 = numArray9[1];
      str2 = strArray2[1];
      str1 = strArray1[10];
    }
    if (int32 == 12)
    {
      num1 = numArray1[1];
      num2 = numArray2[2];
      num3 = numArray3[2];
      num4 = numArray4[2];
      num5 = numArray5[2];
      num6 = numArray6[2];
      num7 = (double) numArray8[2];
      num8 = numArray7[2];
      num9 = numArray9[2];
      str2 = strArray2[2];
      str1 = strArray1[11];
    }
    if (int32 == 13)
    {
      num1 = numArray1[1];
      num2 = numArray2[3];
      num3 = numArray3[3];
      num4 = numArray4[3];
      num5 = numArray5[3];
      num6 = numArray6[3];
      num7 = (double) numArray8[3];
      num8 = numArray7[3];
      num9 = numArray9[3];
      str2 = strArray2[3];
      str1 = strArray1[12];
    }
    if (int32 == 14)
    {
      num1 = numArray1[1];
      num2 = numArray2[4];
      num3 = numArray3[4];
      num4 = numArray4[4];
      num5 = numArray5[4];
      num6 = numArray6[4];
      num7 = (double) numArray8[4];
      num8 = numArray7[4];
      num9 = numArray9[4];
      str2 = strArray2[4];
      str1 = strArray1[13];
    }
    if (int32 == 15)
    {
      num1 = numArray1[4];
      num2 = numArray2[1];
      num3 = numArray3[1];
      num4 = numArray4[1];
      num5 = numArray5[1];
      num6 = numArray6[1];
      num7 = (double) numArray8[1];
      num8 = numArray7[1];
      num9 = numArray9[1];
      str2 = strArray2[1];
      str1 = strArray1[14];
    }
    if (int32 == 16)
    {
      num1 = numArray1[2];
      num2 = numArray2[0];
      num3 = numArray3[0];
      num4 = numArray4[0];
      num5 = numArray5[0];
      num6 = numArray6[0];
      num7 = (double) numArray8[0];
      num8 = numArray7[0];
      num9 = numArray9[0];
      str2 = strArray2[0];
      str1 = strArray1[15];
    }
    if (int32 == 17)
    {
      num1 = numArray1[2];
      num2 = numArray2[1];
      num3 = numArray3[1];
      num4 = numArray4[1];
      num5 = numArray5[1];
      num6 = numArray6[1];
      num7 = (double) numArray8[1];
      num8 = numArray7[1];
      num9 = numArray9[1];
      str2 = strArray2[1];
      str1 = strArray1[16];
    }
    if (int32 == 18)
    {
      num1 = numArray1[2];
      num2 = numArray2[2];
      num3 = numArray3[2];
      num4 = numArray4[2];
      num5 = numArray5[2];
      num6 = numArray6[2];
      num7 = (double) numArray8[2];
      num8 = numArray7[2];
      num9 = numArray9[2];
      str2 = strArray2[2];
      str1 = strArray1[17];
    }
    if (int32 == 19)
    {
      num1 = numArray1[4];
      num2 = numArray2[2];
      num3 = numArray3[2];
      num4 = numArray4[2];
      num5 = numArray5[2];
      num6 = numArray6[2];
      num7 = (double) numArray8[2];
      num8 = numArray7[2];
      num9 = numArray9[2];
      str2 = strArray2[2];
      str1 = strArray1[18];
    }
    if (int32 == 20)
    {
      num1 = numArray1[4];
      num2 = numArray2[3];
      num3 = numArray3[3];
      num4 = numArray4[3];
      num5 = numArray5[3];
      num6 = numArray6[3];
      num7 = (double) numArray8[3];
      num8 = numArray7[3];
      num9 = numArray9[3];
      str2 = strArray2[3];
      str1 = strArray1[19];
    }
    if (int32 == 21)
    {
      num1 = numArray1[0];
      num2 = numArray2[1];
      num3 = numArray3[2];
      num4 = numArray4[3];
      num5 = numArray5[4];
      num6 = numArray6[4];
      num7 = (double) numArray8[3];
      num8 = numArray7[2];
      num9 = numArray9[1];
      str2 = strArray2[0];
      str1 = strArray1[20];
    }
    using (new OutToFile(str1 + "_kursach_calculate.txt"))
    {
      Console.WriteLine("Хiд штоку, мм: {0}", (object) num1);
      Console.WriteLine("Швидкiсть перемiщення штоку, мм/с: {0}", (object) num2);
      Console.WriteLine("Осьове навантаження, N: {0}", (object) num3);
      Console.WriteLine("Швидкiсть обертання штокУ, rad/s: {0}", (object) num4);
      Console.WriteLine("Кут поворот шлицьового валу, rad: {0}", (object) num5);
      Console.WriteLine("Навантжувальний момент, N*m: {0}", (object) num6);
      Console.WriteLine("Перiод руху, с: {0}", (object) num7);
      Console.WriteLine("ККД: {0}", (object) num8);
      Console.WriteLine("Строк служби: {0}", (object) num9);
      Console.WriteLine("Тип двигуна: {0}", (object) str2);
      Console.WriteLine();
      double num10 = (double) num5 / num7;
      double num11 = num6 * num10 / num8;
      double num12 = (double) (30 * num5) / Math.PI;
      int num13 = 0;
      if (str2 == "ДПР-6")
        num13 = 6000;
      else if (str2 == "ДПР-7")
        num13 = 4500;
      double d = (double) num13 / num12;
      double num14 = 1.564 * Math.Log(d);
      int count1 = 0;
      if (num14 > 1.0 && num14 < 2.5)
        count1 = 2;
      if (num14 > 2.5 && num14 < 4.5)
        count1 = 4;
      if (num14 > 4.5 && num14 < 6.5)
        count1 = 6;
      double num15 = Math.Pow(1.895, (double) count1);
      Console.WriteLine("Середня кутова швидкiсть кочення: {0}", (object) num10);
      Console.WriteLine("Потужнiсть двигуна: {0}", (object) num11);
      Console.WriteLine("Загальне передаточне вiдношення: {0}", (object) d);
      Console.WriteLine("Загальне передаточне вiдношення за ступенями: {0}", (object) Math.Round(num15, 4));
      Console.WriteLine("n оптимальне: {0}", (object) num14);
      Console.WriteLine("n виходу: {0}", (object) Math.Round(num12, 4));
      Console.WriteLine("Кiлькiсть пар: {0}", (object) count1);
      Console.WriteLine();
      Console.WriteLine("\nМоменти сил на валах: ");
      double[] arr = new double[count1];
      for (int index = 0; index < arr.Length; ++index)
        arr[index] = index != 0 ? arr[index - 1] / 1.895 : num6;
      int[] array = Enumerable.Range(1, count1).Reverse<int>().ToArray<int>();
      for (int index = 0; index < count1; ++index)
        Console.WriteLine("T {0}: {1}", (object) array[index], (object) Math.Round(arr[index], 4));
      Array.Reverse((Array) arr);
      double[] thirdRoot = Program.findThirdRoot(arr);
      Console.WriteLine();
      Console.WriteLine("Модулi зчеплення: ");
      for (int index = 0; index < count1; ++index)
        Console.WriteLine("m {0}: {1}", (object) (index + 1), (object) Math.Round(thirdRoot[index], 4));
      double num16 = 18.0;
      double num17 = 34.0;
      double num18 = 1.385;
      double num19 = 0.25;
      double[] numArray10 = new double[count1];
      double[] numArray11 = new double[count1];
      for (int index = 0; index < thirdRoot.Length; ++index)
      {
        numArray10[index] = Math.Round(thirdRoot[index] * num16, 4);
        numArray11[index] = Math.Round(thirdRoot[index] * num17, 4);
      }
      Console.WriteLine();
      Console.WriteLine("Дiлильнi дiаметри для шестерней:");
      for (int index = 0; index < numArray10.Length; ++index)
        Console.WriteLine("d1 {0}: {1}", (object) (index + 1), (object) numArray10[index]);
      Console.WriteLine();
      Console.WriteLine("Дiлильнi даметри для колiс:");
      for (int index = 0; index < numArray11.Length; ++index)
        Console.WriteLine("d2 {0}: {1}", (object) (index + 1), (object) numArray11[index]);
      double[] numArray12 = new double[count1];
      Console.WriteLine();
      Console.WriteLine("\nДiлильна мiжосьова вiдстань:");
      for (int index = 0; index < numArray12.Length; ++index)
        Console.WriteLine("a {0}: {1}", (object) (index + 1), (object) (numArray12[index] = 0.5 * (numArray10[index] + numArray11[index])));
      Console.WriteLine();
      double num20 = num18 + num19;
      double num21 = 1.326 * Math.Pow(num20 / (num16 + num17) + 0.02334, 0.2243) - 0.22183;
      Console.WriteLine("x сумарне: {0}", (object) num20);
      Console.WriteLine("Кут зчеплення: {0}", (object) num21);
      Console.WriteLine();
      Console.WriteLine("Мiжосьова вiдстань:");
      double[] numArray13 = new double[count1];
      for (int index = 0; index < numArray13.Length; ++index)
        numArray13[index] = Math.Round(numArray12[index] * Math.Cos(Program.ConvertToRadians(20.0)) / Math.Cos(num21), 4);
      for (int index = 0; index < numArray13.Length; ++index)
        Console.WriteLine("a_w {0}: {1}", (object) (index + 1), (object) numArray13[index]);
      Console.WriteLine();
      Console.WriteLine("Коефiцiєнт сприймаємого змiщення:");
      double[] numArray14 = new double[count1];
      for (int index = 0; index < numArray14.Length; ++index)
        numArray14[index] = Math.Round((numArray13[index] - numArray12[index]) / thirdRoot[index], 4);
      for (int index = 0; index < numArray14.Length; ++index)
        Console.WriteLine("y {0}: {1}", (object) (index + 1), (object) numArray14[index]);
      double num22 = 1.0;
      double num23 = 0.25;
      double[] numArray15 = new double[count1];
      double[] numArray16 = new double[count1];
      double[] numArray17 = new double[count1];
      double[] numArray18 = new double[count1];
      double[] numArray19 = new double[count1];
      double[] numArray20 = new double[count1];
      for (int index = 0; index < thirdRoot.Length; ++index)
      {
        numArray15[index] = Math.Round(thirdRoot[index] * (num16 + 2.0 * (num22 + numArray14[index] - num19)), 4);
        numArray16[index] = Math.Round(thirdRoot[index] * (num16 + 2.0 * (num22 + numArray14[index] - num18)), 4);
      }
      Console.WriteLine();
      Console.WriteLine("Дiаметри вершин зубiв для шестерней:");
      for (int index = 0; index < numArray15.Length; ++index)
        Console.WriteLine("da1 {0}: {1}", (object) (index + 1), (object) numArray15[index]);
      Console.WriteLine();
      Console.WriteLine("Дiаметри вершин зубiв для колiс:");
      for (int index = 0; index < numArray16.Length; ++index)
        Console.WriteLine("da2 {0}: {1}", (object) (index + 1), (object) numArray16[index]);
      for (int index = 0; index < thirdRoot.Length; ++index)
      {
        numArray17[index] = Math.Round(thirdRoot[index] * (num16 - 2.0 * (num22 + num23 - num18)), 4);
        numArray18[index] = Math.Round(thirdRoot[index] * (num16 - 2.0 * (num22 + num23 - num19)), 4);
      }
      Console.WriteLine();
      Console.WriteLine("Дiаметри западин для шестерней:");
      for (int index = 0; index < numArray17.Length; ++index)
        Console.WriteLine("df1 {0}: {1}", (object) (index + 1), (object) numArray15[index]);
      Console.WriteLine();
      Console.WriteLine("Дiаметри западин для колiс:");
      for (int index = 0; index < numArray18.Length; ++index)
        Console.WriteLine("df2 {0}: {1}", (object) (index + 1), (object) numArray16[index]);
      for (int index = 0; index < thirdRoot.Length; ++index)
      {
        numArray19[index] = Math.Round(0.5 * (numArray15[index] - numArray17[index]), 4);
        numArray20[index] = Math.Round(0.5 * (numArray16[index] - numArray18[index]), 4);
      }
      Console.WriteLine();
      Console.WriteLine("Висота зубiв для шестерней:");
      for (int index = 0; index < numArray19.Length; ++index)
        Console.WriteLine("h1 {0}: {1}", (object) (index + 1), (object) numArray19[index]);
      Console.WriteLine();
      Console.WriteLine("Висота зубiв для колiс:");
      for (int index = 0; index < numArray20.Length; ++index)
        Console.WriteLine("h2 {0}: {1}", (object) (index + 1), (object) numArray20[index]);
      double num24 = num17 / num16;
      Console.WriteLine();
      Console.WriteLine("\nПередаточне число: {0}", (object) num24);
      double[] numArray21 = new double[count1];
      double[] numArray22 = new double[count1];
      double[] numArray23 = new double[count1];
      double[] numArray24 = new double[count1];
      for (int index = 0; index < thirdRoot.Length; ++index)
      {
        numArray21[index] = Math.Round(2.0 * numArray13[index] / (num24 + 1.0), 4);
        numArray22[index] = Math.Round(2.0 * numArray13[index] * num24 / (num24 + 1.0), 4);
      }
      Console.WriteLine();
      Console.WriteLine("Початковi дiаметри для шестерней:");
      for (int index = 0; index < numArray21.Length; ++index)
        Console.WriteLine("dw1 {0}: {1}", (object) (index + 1), (object) numArray21[index]);
      Console.WriteLine();
      Console.WriteLine("Початковi дiаметри для колiс:");
      for (int index = 0; index < numArray22.Length; ++index)
        Console.WriteLine("dw2 {0}: {1}", (object) (index + 1), (object) numArray22[index]);
      double[] numArray25 = new double[count1];
      double[] numArray26 = new double[count1];
      for (int index = 0; index < thirdRoot.Length; ++index)
      {
        numArray25[index] = Program.ConvertToRadians(numArray10[index] / (numArray15[index] * Math.Cos(Program.ConvertToRadians(20.0))));
        numArray26[index] = Program.ConvertToRadians(numArray11[index] / (numArray16[index] * Math.Cos(Program.ConvertToRadians(20.0))));
        numArray23[index] = Math.Round(Math.Acos(numArray25[index]), 6);
        numArray24[index] = Math.Round(Math.Acos(numArray26[index]), 6);
      }
      Console.WriteLine();
      Console.WriteLine("Кути профiлiв на поверхнях вершин шестерней:");
      for (int index = 0; index < numArray23.Length; ++index)
        Console.WriteLine("a_a1 {0}: {1}", (object) (index + 1), (object) numArray23[index]);
      Console.WriteLine();
      Console.WriteLine("Кути профiлiв на поверхнях вершин колiс:");
      for (int index = 0; index < numArray24.Length; ++index)
        Console.WriteLine("a_a2 {0}: {1}", (object) (index + 1), (object) numArray24[index]);
      double[] numArray27 = new double[count1];
      double[] numArray28 = new double[count1];
      for (int index = 0; index < count1; ++index)
      {
        numArray27[index] = Math.Round(numArray15[index] * (Math.PI / 2.0 + 2.0 * num18 * Math.Tan(Program.ConvertToRadians(20.0)) / num16) + Program.AngleInvolute(Program.ConvertToRadians(20.0)) - Program.AngleInvolute(Program.ConvertToRadians(numArray23[index])), 6);
        numArray28[index] = Math.Round(numArray15[index] * (Math.PI / 2.0 + 2.0 * num19 * Math.Tan(Program.ConvertToRadians(20.0)) / num17) + Program.AngleInvolute(Program.ConvertToRadians(20.0)) - Program.AngleInvolute(Program.ConvertToRadians(numArray24[index])), 6);
      }
      Console.WriteLine();
      Console.WriteLine("Товщина зубiв на поверхнях вершин шестерней:");
      for (int index = 0; index < numArray23.Length; ++index)
        Console.WriteLine("S_a1 {0}: {1}", (object) (index + 1), (object) numArray27[index]);
      Console.WriteLine();
      Console.WriteLine("Товщина зубiв на поверхнях вершин колiс:");
      for (int index = 0; index < numArray24.Length; ++index)
        Console.WriteLine("S_a2 {0}: {1}", (object) (index + 1), (object) numArray28[index]);
      double[] numArray29 = new double[count1];
      for (int index = 0; index < numArray29.Length; ++index)
        numArray29[index] = Math.Round(0.0 * (num16 * (Math.Tan(Program.ConvertToRadians(numArray23[index])) - Math.Tan(Program.ConvertToRadians(num21)))) + num17 * (Math.Tan(Program.ConvertToRadians(numArray24[index])) - Math.Tan(Program.ConvertToRadians(num21))), 6);
      double num25 = 0.0;
      for (int index = 0; index < numArray29.Length; ++index)
        num25 += numArray29[index];
      double count2 = (double) ((IEnumerable<double>) numArray29).ToList<double>().Count;
      double num26 = num25 / count2;
      Console.WriteLine();
      Console.WriteLine("\nКоефiцiєнт торцьового перекриття:{0}", (object) Math.Round(num26, 4));
      Console.WriteLine();
      Console.WriteLine("\nВизначення силових параметрiв механiзму");
      double[] numArray30 = new double[count1];
      double[] numArray31 = new double[count1];
      for (int index = 0; index < numArray30.Length; ++index)
        numArray30[index] = 2000.0 * arr[index] / numArray21[index];
      for (int index = 0; index < numArray30.Length; ++index)
        numArray31[index] = numArray30[index] * Math.Tan(Program.ConvertToRadians(num21));
      Console.WriteLine();
      Console.WriteLine("Кругове зусилля");
      for (int index = 0; index < numArray30.Length; ++index)
        Console.WriteLine("F_t {0}: {1}", (object) (index + 1), (object) Math.Round(numArray30[index], 4));
      Console.WriteLine();
      Console.WriteLine("\nРадiальне зусилля");
      for (int index = 0; index < numArray31.Length; ++index)
        Console.WriteLine("F_r {0}: {1}", (object) (index + 1), (object) Math.Round(numArray31[index], 4));
      double num27 = 6.5;
      double num28 = 15.5;
      double num29 = 22.1;
      int index1 = numArray30.Length - 1;
      double num30 = 1.2;
      double num31 = 0.4;
      double num32 = new Random().NextDouble() * (num30 - num31) + num31;
      double num33 = Program.takeNDigits(num27 * Math.Sqrt(Math.Pow(numArray30[index1], 2.0) + Math.Pow(numArray31[index1], 2.0) / num29), 3) + num32;
      double num34 = Program.takeNDigits(num28 * Math.Sqrt(Math.Pow(numArray30[index1], 2.0) + Math.Pow(numArray31[index1], 2.0) / num29), 3) + num32;
      Console.WriteLine();
      Console.WriteLine("Реакцiя мiж колесами: {0}", (object) num33);
      Console.WriteLine("Реакцiя мiж колесом та корпусом: {0}", (object) num34);
      double ndigits = Program.takeNDigits(num34 * num29, 4);
      Console.WriteLine();
      Console.WriteLine("Згинальний момент: {0}", (object) Math.Round(ndigits, 4));
      double num35 = 400.0;
      Console.WriteLine();
      Console.WriteLine("\nДiаметри валiв:");
      double[] numArray32 = new double[count1];
      for (int index2 = 0; index2 < numArray32.Length; ++index2)
        numArray32[index2] = 32.0 * arr[index2] / Math.Pow(Math.PI * num35, 0.3);
      for (int index2 = 0; index2 < numArray32.Length; ++index2)
        numArray32[index2] = numArray32[index2] >= Math.E ? numArray32[index2] + num32 : 1.34 + numArray32[index2] + num32;
      Console.WriteLine();
      for (int index2 = 0; index2 < numArray32.Length; ++index2)
        Console.WriteLine("d {0}: {1}", (object) (index2 + 1), (object) Math.Round(Program.takeNDigits(numArray32[index2], 4), 3));
      double num36 = 30000.0;
      double number = num36 * num12 * 60.0 / Math.Pow(10.0, 3.0);
      Console.WriteLine();
      Console.WriteLine("Заданий термiн служби пiдшипника: {0} годин", (object) num36);
      Console.WriteLine("Кутова швидкiсть обертання вихiдного валу (n виходу): {0}", (object) Math.Round(num12, 4));
      Console.WriteLine("Розрахункове довголiття пiдшипника: {0} годин", (object) Math.Round(Program.takeNDigits(number, 4), 3));
      double num37 = new Random().NextDouble();
      double num38 = Math.Round(0.9 + num37 * (1.0 / 10.0), 2);
      double num39 = 0.95;
      double num40 = Math.Round(0.05 + num37 * 0.05, 2);
      double num41 = number / (num38 * num39 * num40);
      Console.WriteLine();
      Console.WriteLine("Коефiцiєнт надiйностi: {0}", (object) num38);
      Console.WriteLine("Коефiцiєнт змiни матерiалу: {0}", (object) num39);
      Console.WriteLine("Коефiцiєнт умов експлуатацiї: {0}", (object) num40);
      Console.WriteLine("Базове довголiття пiдшипника: {0} годин", (object) Math.Round(Program.takeNDigits(num41, 5), 3));
      Console.WriteLine();
      double num42 = 149.18;
      Console.WriteLine("Еквiвалентне навантаження: {0}", (object) num42);
      double num43 = num42 * Math.Pow(num41, 0.3);
      Console.WriteLine();
      Console.WriteLine("Динамiчна вантажопiдйомнiсть на останньому валу: {0}", (object) num43);
    }
    stopwatch.Stop();
    Console.WriteLine(string.Format("\nПроцес iмпорту у файл закiнчено.\nОбрахунок курсачу зайняв {0} мс. А скiльки би ти рахував/рахувала це вручну?\nУ папцi з цiєю програмою повинен з'явитись текстовий файл з назвою \"[твоє_прiзвище]_kursach_calculate\"", (object) (double) stopwatch.ElapsedMilliseconds));
    Console.WriteLine("Якщо бажаєш отримати вихiдний код програми для її модифiкацiї - пиши t.me/metrologg");
    Console.ReadKey();
  }

  public static double[] findThirdRoot(double[] arr)
  {
    double[] numArray = new double[arr.Length];
    for (int index = 0; index < numArray.Length; ++index)
      numArray[index] = 0.7 * Math.Pow(arr[index], 0.3);
    return numArray;
  }

  public static double ConvertToRadians(double angle)
  {
    return angle * Math.PI / 180.0;
  }

  public static double AngleInvolute(double angle)
  {
    return Math.Tan(Program.ConvertToRadians(angle)) - Program.ConvertToRadians(angle);
  }

  private static double takeNDigits(double number, int N)
  {
    number = Math.Abs(number);
    if (number == 0.0)
      return number;
    int num = (int) Math.Floor(Math.Log10(number) + 1.0);
    return num >= N ? (double) (int) Math.Truncate(number / Math.Pow(10.0, (double) (num - N))) : number;
  }
}
