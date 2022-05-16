// Найти максимум из 9-ти чисел

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 7;
int b1 = 18;
int c1 = 1876;
int a2 = 8;
int b2 = 434;
int c2 = 76;
int a3 = 16;
int b3 = 77;
int c3 = 99;

//int max1 = Max (a1, b1 ,c1);
//int max2 = Max (a2, b2 ,c2);
//int max3 = Max (a3, b3 ,c3);
//int max = Max (max1, max2, max3);
// Можно записать по другому 

 int max = Max(
      Max (a1, b1, c1),
      Max (a2, b2, c2),  
      Max (a3, b3, c3));

Console.WriteLine (max);