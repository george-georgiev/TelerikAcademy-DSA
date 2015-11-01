## Data Structures, Algorithms and Complexity Homework

**Problem** 1.
```
long Compute(int[] arr)
{
    long count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        int start = 0, end = arr.Length-1;
        while (start < end)
            if (arr[start] < arr[end])
                { start++; count++; }
            else 
                end--;
    }
    return count;
}
```
The complexity is **O(n^2)**, because for each element we iterate *n-1* times.<br/>
g(n) -> n\*(n-1)<br/>
g(n) -> n\*n - n

**Problem** 2.
```
long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row=0; row<matrix.GetLength(0); row++)
          if (matrix[row, 0] % 2 == 0)
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```
The complexity is **O(n*m)**, because for each of *n* rows we iterate through *m* columns.

**Problem** 3.
```
long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++) 
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1);
      return sum;
  }

  Console.WriteLine(CalcSum(matrix, 0));
  ```
The complexity is **O(n*m)**.<br/>
The complexity of the method for our Best case is *n + C*. <br/>
Because in our Worst case we recursevly call the function *(m-1)* times, *g(n)* is as follows:<br/>
g(n) -> (n + C) + (n + C)\*(m - 1)<br/>
g(n) -> n + n\*m -n<br/>
g(n) -> n\*m
