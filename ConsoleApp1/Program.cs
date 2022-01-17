int[] arrayA = new int[] { 2, 4, 8, 34 };
int[] arrayB = new int[] { 2, 5, 6, 8, 12, 42, 54 };

int cLength = arrayA.Length + arrayB.Length;

int[] arrayC = new int[cLength];

int countA = arrayA.Length - 1;
int countB = arrayB.Length - 1;
int countC = countA + countB + 1;

while (countC >= 0)
{
    if (arrayA[countA] < arrayB[countB])
    {
        arrayC[countC] = arrayB[countB];
        if (countB > 0)
            countB--;
    }
    else if (arrayA[countA] > arrayB[countB])
    {
        arrayC[countC] = arrayA[countA];
        if (countA > 0)
            countA--;
    }
    else
    {
        arrayC[countC] = arrayA[countA];
        if (countA > 0)
            countA--;
        countC--;
        arrayC[countC] = arrayB[countB];
        if (countB > 0)
            countB--;
    }
    countC--;

}
for (int i = 0; i < cLength; i++)
    Console.WriteLine(arrayC[i]);