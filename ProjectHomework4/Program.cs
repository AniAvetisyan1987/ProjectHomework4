internal class Program
{
    private static void Main(string[] args)
    {
        //page 21 ex:369
        //int[] arr1 = { 2, 3, 4, 5, 6, 7, 8, 9, 12, 23, 45, 12, 23, 34, 1,45, 5, 6, 78, 67}; 
        //int[] arr2 = { 11, 22, 32, 44, 5, 6, 7, 8, 9, 12, 23, 45, 12, 23, 34, 45, 5, 6, 78, 67 };
        //int min = arr1[0];
        //for(int i = 0; i < arr1.Length; i++)
        //{
        //    if (arr1[i] < min && !arr2.Contains(arr1[i]))
        //    {
        //        min = arr1[i];
        //    }   
        //}
        //Console.WriteLine(min);

        //ex:21
        //byte a = 16;
        //byte b = 8;
        //byte c = 5;
        //byte max = 0;
        //if (a > b && a > c)
        //{
        //    max = a;
        //}
        //else if (b > a && b > c)
        //{
        //    max = b;
        //} else
        //{
        //    max = c;
        //} 
        //Console.WriteLine(max);
         
        // ex:27
            //float diff = b > a && c > b ? b / a : a / b;
            //float diff2 = b > a && c > b ? c / b : b / c;
            //bool isProgresia = diff == diff2 ? true : false;
        
       //Console.WriteLine(isProgresia);

        // ex:211
        //int[] arr3 = { -3, 5, 56, 34, 56, -21, -54, 8, -3 };
        //int sum3 = 0;
        //int count = 0;
        //for (int i = 0; i < arr3.Length; i++)
        //{
        //    if (arr3[i] > 0)
        //    {
        //        sum3 += arr3[i];
        //        count++;
        //    }
        //}
        //float medium = sum3 / count; 
        //Console.WriteLine(medium);

        // ex:211

        int[] arr4 = { 1, -2, 3, 4, -5, 17, 32, 98, -123 };
        int sum4 = 0;
        int count4 = 0;
        //for (int i = 0; i < arr4.Length; i++)
        //{
        //    if (arr4[i] > 0)
        //    {
        //        sum4 += arr4[i];
        //        count4++;
        //    }
        //}
        //Console.WriteLine(sum4/count4);

        // ex: 212

        //for (int i = 0;i < arr4.Length; i++)
        //{
        //    if (arr4[i] > 0)
        //    {
        //        sum4 += arr4[i] * arr4[i];
        //        count4++;
        //    }
        //}
        //double avr = Math.Sqrt(sum4 / count4);
        //Console.WriteLine(avr);

        // ex: 215

        //for (int i = 0; i < arr4.Length; i++)
        //{
        //    if (i > 0 && i % 2 == 0)
        //    {
        //        sum4 += arr4[i];
        //    }
        //}
        //Console.WriteLine(sum4);

        // ex: 223
        //short a = 2;
        //short b = 5;
        //for (int i = 0; i < arr4.Length; i++)
        //{
        //    if (arr4[i] >= a && arr4[i] <= b)
        //    {
        //        count4++;
        //    }
        //}
        //Console.WriteLine(count4);

        //ex: 230
        float[] arr5 = { 1.2f, 2.3f, 5.4f };
        double sum5 = 0;
        int count5 = 0;
        int k = 23;
        //for(int i = 0; i< arr5.Length; i++)
        //{
        //    if ((arr5[i] - arr5[i] % 1) % k == 0)
        //    {
        //        sum5 = Math.Pow((arr5[i] - arr5[i] % 1), 2);
        //        count5++;
        //    }

        //}
        //Console.WriteLine(Math.Sqrt(sum5/count5));

        // ex:238
        //for (int i = 0; i < arr4.Length; i++)
        //{
        //    if (arr4[i] % 3 == 0)
        //    {
        //        sum4 += arr4[i];
        //        count4++;
        //    }
        //}
        //Console.WriteLine(sum4 / count4);

        // ex:244
        //int avg5 = 1;
        //for(int i=0; i < arr4.Length; i++)
        //{
        //    if (arr4[i] % 5 == 2)
        //    {
        //       avg5 *= arr4[i];
        //    }
        //}
        //Console.WriteLine(avg5);

        // ex:249
        //for (int i=0; i<arr4.Length; i++)
        //{
        //    int num = arr4[i] - i;
        //    int modul = num > 0 ? num : num * (-1);
        //    if (modul > k)
        //    {
        //        count4++;
        //    }
        //}
        //Console.WriteLine(count4);



        // ex:250
        //double avg6 = 1;
        //for (int i = 0; i < arr4.Length; i++)
        //{
        //    if ((arr4[i] * i) % 3 == 2)
        //    {
        //        avg6 *= Math.Pow(arr4[i], 2);
        //    }
        //}
        //Console.WriteLine(avg6);

        // ex:253
        //int min = arr4[0];
        //int max = arr4[0];
        //for (int i = 0; i < arr4.Length; i++)
        //{
        //    if (arr4[i] < min)
        //    {
        //        min = arr4[i];
        //    }
        //    if (arr4[i] > max)
        //    {
        //        max = arr4[i];
        //    }
        //}
        //Console.WriteLine(min + max);

        // ex:255
        //int max = arr4[0];
        //int index = 0;
        //for (int i = 0; i < arr4.Length; i++)
        //{
        //    if (arr4[i] > max)
        //    {
        //        max = arr4[i];
        //        index = i;
        //    }
        //}
        //Console.WriteLine(max + index);



        int[] X = new int[] { 32, -56, 1, 45, 889 };
        int[] Y = new int[] { 22, 65, 112, -54, -88 };


        // ex:261

        //double avgX = Queryable.Average(X.AsQueryable()) / X.Length;
        //double avgY = Queryable.Average(Y.AsQueryable()) / Y.Length;
        //Console.WriteLine(avgX * avgY);

        // ex:267
        //int count = 0;
        //for (int i = 0; i < X.Length; i++)
        //{
        //    if (Y[i] % 7 == 0)
        //    {
        //        Console.WriteLine(Y[i]);
        //        count++;
        //    }
        //    if (X[i] % 7 == 0)
        //    {
        //        Console.WriteLine(X[i]);
        //        count++;
        //    }
        //}
        //Console.WriteLine(count);

        // ex:264
        //int count = 0;
        //for (int i = 0; i < X.Length; i++)
        //{
        //    if (Y[i] < 0)
        //    {
        //        count++;
        //    }
        //    if (X[i] < 0)
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine(count);

        // ex:269
        //int sumXY = 0;
        //for (int i = 0; i < X.Length; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        sumXY += X[i];  
        //    }
        //    else
        //    {
        //        sumXY += Y[i];
        //    }
        //}
        //Console.WriteLine(sumXY);

        // ex:270
        //double sumXY = 0;
        //for (int i = 0; i < X.Length; i++)
        //{
        //    sumXY += Math.Pow(X[i], 2);
        //    sumXY += Math.Pow(Y[i], 2);
        //}
        //Console.WriteLine(sumXY);

        char[] char1 = { 's', 'd', 'a', 'f', 'c', '1' };


        // ex:271
        //int count = 0;
        //for (int i = 0; i < char1.Length; i++)
        //{
        //    count += char1[i] == 'a' ? 1 : 0;
        //}
        //Console.WriteLine(count);

        // ex:275
        //int count = 0;
        //for (int i = 0; i < char1.Length; i++)
        //{
        //    count += char1[i] < 'k' ? 1 : 0;
        //}
        //Console.WriteLine(count);

        // ex:277
        //char[] char2 = new char[] { };
        //for (int i = 0; i < char1.Length; i++)
        //{
        //    if (char1[i] != 'd')
        //    {
        //        char2 = char2.Append(char1[i]).ToArray();
        //    }
        //}
        //Console.WriteLine(char2);

        // ex:280
        //char[] char2 = new char[] { };
        //for (int i = 0; i < char1.Length; i++)
        //{
        //    if (char1[i] == 'f')
        //    {
        //        char2 = char2.Append(char1[i]).ToArray();
        //        char2 = char2.Append('f').ToArray();
        //    }
        //    else
        //    {
        //        char2 = char2.Append(char1[i]).ToArray();
        //    }
        //}
        //Console.WriteLine(char2);


        int[] X1 = new int[] { 32, -56, 88, 1, 45, 88, 49 };

        // ex:281
        //int[] X2 = new int[] { };
        //for (int i = 0; i < X1.Length; i++)
        //{
        //    if (X1[i] > 0)
        //    {
        //        X2 = X2.Append(X1[i]).ToArray();
        //    }
        //}
        //Console.WriteLine(X2);

        // ex:289
        //int c = 15, d = 3000;
        //int[] X2 = new int[] { };
        //for (int i = 0; i < X1.Length; i++)
        //{
        //    if (Math.Pow(X1[i],2) > c && Math.Pow(X1[i], 2) < d)
        //    {
        //        X2 = X2.Append(X1[i]).ToArray();            
        //    }
        //}

        //ex:290
        //int[] X2 = new int[] { };
        //for (int i = 0; i < X1.Length; i++)
        //{
        //   if (X1[i] % 6 == 1)
        //    {
        //        X2 = X2.Append(X1[i]).ToArray();
        //    }
        //}
        //Console.WriteLine(X2);

        // ex:292
        //int[] X2 = new int[] { };
        //for (int i = 0; i < X1.Length; i++)
        //{
        //    if (X1[i] % 7 == 0)
        //    {
        //        X2 = X2.Append(X1[i]).ToArray();
        //        X1 = X1.Where((val,id) => id !=i).ToArray();
        //    }
        //}

        // ex:294
        //int[] X2 = new int[] { };
        //for (int i = 0; i < X1.Length; i++)
        //{
        //    if (i % 2 != 0)
        //    {
        //        X2 = X2.Append(X1[i]).ToArray();
        //        X1 = X1.Where((val, id) => id != i).ToArray();
        //    }
        //}

        // ex:298
        //int[] X2 = new int[] { };
        //for (int i = 0; i < X1.Length; i++)
        //{
        //    if (X1[i] % 2 == 0)
        //    {
        //        X2 = X2.Append(X1[i]).ToArray();
        //        X1 = X1.Where((val, id) => id != i).ToArray();
        //    }
        //}



        // Ex:333
        //int k1 = 50;
        //int sum = 0;
        //for (int i = 0; i< X1.Length; i++ )
        //{
        //    if (i > 0 &&
        //        i < X1.Length - 1 &&
        //        (X1[i - 1] + X1[i + 1]) < k1)
        //    {
        //        sum += X[i];
        //    }
        //}
        //Console.WriteLine(sum);

        // Ex: 334
        //int sum = 0;
        //int avg = 1;
        //int max = X1[0];
        //bool condition = false;
        //for (int i = 0; i < X1.Length; i++)
        //{
        //   if (X1[i] > max)
        //    {
        //        max = X1[i];
        //        if (i < X1.Length/2)
        //        {
        //            condition = true;
        //        }
        //    }
        //}
        //int j = 0;
        //while(j < X1.Length)
        //{
        //    if (condition)
        //    {
        //        sum += X1[j] > 0 ? X1[j] : 0;
        //    } else {
        //        avg *= X1[j] < 0 ? X1[j] : 1;
        //    }
        //    j++;
        //}
        //Console.WriteLine(sum);
        //Console.WriteLine(avg);


        // Ex:338
        //int max = X1[0];
        //int indexSum = 0;
        //for (int i = 0; i < X1.Length; i++) {
        //    if (X1[i] > max)
        //    {
        //        max = X1[i];
        //        indexSum += i;

        //    }
        //}
        //for (int i = indexSum + 1; i < X1.Length; i++)
        //{
        //    if (X1[i] == max)
        //    {
        //        indexSum += i;
        //    }
        //}

        //Console.WriteLine(indexSum);

    }
}