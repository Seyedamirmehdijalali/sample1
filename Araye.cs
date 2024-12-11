using System;

public class Araye
{
    public int[] x;

    public Araye()
    {
        x = new int[] { 6, 4, 1, 7, 2 };
    }

    private void swap(int[] x, int j)
    {
        int temp = x[j];
        x[j] = x[j + 1];
        x[j + 1] = temp;
    }

    private int[] Sort()
    {
        for (int i = 0; i < x.Length - 1; i++)
        {
            for (int j = 0; j < x.Length - i - 1; j++)
            {
                if (x[j] > x[j + 1])
                {
                    swap(x, j);
                }
            }
        }
        return x;
    }

    public void Print()
    {
        int[] sortedArray = Sort();
        Console.WriteLine(string.Join(", ", sortedArray));
    }
}
