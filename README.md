# FibonacciSequence
FibonacciSequence001


In mathematics, the Fibonacci numbers are the numbers in the following integer sequence, called the Fibonacci sequence, and characterized by the fact that every number after the first two is the sum of the two preceding ones:

public static int Fibonacci(int n)
        {
            int n1 = 0, n2 = 1, result = 0;
            if (n == 0) return 0;      
            if (n == 1) return 1;      
            for (int i = 2; i <= n; i++)      // main process starts from here
            {
                result = n1 + n2;
                n1 = n2;
                n2 = result;
            }
            return result;
        }
