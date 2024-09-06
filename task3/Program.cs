int[] arr = new int[10];
int i = 0;
arr[0] = 1;
arr[1] = 5;
arr[2] = 4;
arr[3] = 6;
arr[4] = 9;
arr[5] = 3;
arr[6] = 2;
arr[7] = 5;
arr[8] = 4;
arr[9] = 1;

while (i < arr.Length) 
{
if (arr[i] % 2 == 0)
    Console.Write($"{arr[i]} ");
   
    i = i + 1;
}
