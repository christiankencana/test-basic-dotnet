using System;

public static class DemoSorting
{

    // Binary Search
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    // 1. Bubble Sort
    public static void BubbleSortAsc(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine($"Sort Asc: {string.Join(", ", arr)}");
    }

    public static void BubbleSortDesc(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] < arr[j + 1]) // Ubah > menjadi <
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine($"Sort Desc: {string.Join(", ", arr)}");
    }

    // 2. Quick Sort
    public static void QuickSortAsc(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = PartitionAsc(arr, low, high);
            QuickSortAsc(arr, low, pi - 1);
            QuickSortAsc(arr, pi + 1, high);
        }
        
        // Print only when at the top-level call
        if (low == 0 && high == arr.Length - 1)
            Console.WriteLine($"Sort Asc: {string.Join(", ", arr)}");
    }

    private static int PartitionAsc(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;

        return i + 1;
    }

    public static void QuickSortDesc(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = PartitionDesc(arr, low, high);
            QuickSortDesc(arr, low, pi - 1);
            QuickSortDesc(arr, pi + 1, high);
        }
        
        // Print only when at the top-level call
        if (low == 0 && high == arr.Length - 1)
            Console.WriteLine($"Sort Desc: {string.Join(", ", arr)}");
    }

    private static int PartitionDesc(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] > pivot) // Ubah < menjadi >
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;

        return i + 1;
    }

    // 4. Merge Sort
    public static void MergeSortAsc(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSortAsc(arr, left, mid);
            MergeSortAsc(arr, mid + 1, right);
            MergeAsc(arr, left, mid, right);
        }
        
        // Print only when at the top-level call
        if (left == 0 && right == arr.Length - 1)
            Console.WriteLine($"Sort Asc: {string.Join(", ", arr)}");
    }

    private static void MergeAsc(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, mid + 1, R, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
                arr[k++] = L[i++];
            else
                arr[k++] = R[j++];
        }

        while (i < n1)
            arr[k++] = L[i++];

        while (j < n2)
            arr[k++] = R[j++];
    }

    public static void MergeSortDesc(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSortDesc(arr, left, mid);
            MergeSortDesc(arr, mid + 1, right);
            MergeDesc(arr, left, mid, right);
        }
        
        // Print only when at the top-level call
        if (left == 0 && right == arr.Length - 1)
            Console.WriteLine($"Sort Desc: {string.Join(", ", arr)}");
    }

    private static void MergeDesc(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, mid + 1, R, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
        {
            if (L[i] >= R[j]) // Ubah <= menjadi >=
                arr[k++] = L[i++];
            else
                arr[k++] = R[j++];
        }

        while (i < n1)
            arr[k++] = L[i++];

        while (j < n2)
            arr[k++] = R[j++];
    }

    // 5. Insertion Sort
    public static void InsertionSortAsc(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
        
        Console.WriteLine($"Sort Asc: {string.Join(", ", arr)}");
    }

    public static void InsertionSortDesc(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] < key) // Ubah > menjadi <
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
        
        Console.WriteLine($"Sort Desc: {string.Join(", ", arr)}");
    }

    // 6. Selection Sort
    public static void SelectionSortAsc(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIdx])
                    minIdx = j;
            }

            int temp = arr[minIdx];
            arr[minIdx] = arr[i];
            arr[i] = temp;
        }
        
        Console.WriteLine($"Sort Asc: {string.Join(", ", arr)}");
    }

    public static void SelectionSortDesc(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int maxIdx = i; // Cari maksimum, bukan minimum
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] > arr[maxIdx]) // Ubah < menjadi >
                    maxIdx = j;
            }

            int temp = arr[maxIdx];
            arr[maxIdx] = arr[i];
            arr[i] = temp;
        }
        
        Console.WriteLine($"Sort Desc: {string.Join(", ", arr)}");
    }
}