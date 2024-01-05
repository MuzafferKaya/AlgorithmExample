Algorithms algorithms = new Algorithms();

int[] arr = algorithms.GenerateRandom(10);
arr = algorithms.SelectionSort(arr);

for (int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]}, ");

class Algorithms
{
    public int[] GenerateRandom(int count)
    {
        Random random = new Random();
        int[] n = new int[count];

        for (int i = 0; i < n.Length; i++)
        {
            n[i] = random.Next(1, 99);
        }

        return n;
    }
    public int[] SelectionSort(int[] n)
    {
        for (int i = 0; i < n.Length - 1; i++)
        {
            int min = i;
            for(int j = i + 1; j < n.Length; j++)
                if (n[min] > n[j])
                    min = j;

            int temp = n[i];
            n[i] = n[min];
            n[min] = temp;
        }

        return n;
    }
    public int[] BubblenSort(int[] n)
    {
        for (int i = 0; i < n.Length - 1; i++)
        {
            for (int j = 0; j < n.Length - i - 1; j++)
            {
                if (n[j] > n[j + 1])
                {
                    int temp = n[j];
                    n[j] = n[j + 1];
                    n[j + 1] = temp;
                }
            }
        }

        return n;
    }    
    public int[] InsertionSorting(int[] n)
    {
        for (int i = 1; i < n.Length; i++)
        {
            int temp = n[i];
            int j = i - 1;

            while (j >= 0 && n[j] > temp)
            {
                n[j + 1] = n[j];
                j--;
            }
            n[j + 1] = temp;
        }

        return n;
    }
    public int BinarySerach(int[] n, int target)
    {
        int low = 0;
        int high = n.Length - 1;

        while (low <= high)
        {
            int middle = low + (high - low) / 2;
            int value = n[middle];

            if (value < target) low = middle + 1;
            else if (value > target) high = middle - 1;
            else return middle;
        }

        return -1;
    }
}
