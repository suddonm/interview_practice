public class Prime
{
    public bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    // Given two positive integers left and right, find the two integers num1 and num2 such that:

    // left <= num1 < num2 <= right .
    // Both num1 and num2 are prime numbers.
    // num2 - num1 is the minimum amongst all other pairs satisfying the above conditions.
    // Return the positive integer array ans = [num1, num2]. If there are multiple pairs satisfying these conditions, return the one with the smallest num1 value. If no such numbers exist, return [-1, -1].
    public int[] ClosestPrimes(int left, int right) {
        int[] aryRet = {-1, -1};
        int leftPrime = -1;
        int rightPrime = -1;
        int minDistance = int.MaxValue;

        //left = 10
        //right = 20
        // 11
        List<int> testInts = Enumerable.Range(left, right - left + 1).ToList();
        testInts = testInts.Where(w => this.IsPrime(w)).ToList();

        int lptr = 0;
        int rptr = 1;

        while (lptr < testInts.Count &&
               rptr < testInts.Count)
        {
            if (testInts[rptr] - testInts[lptr] < minDistance)
            {
                minDistance = testInts[rptr] - testInts[lptr];
                aryRet[0] = testInts[lptr];
                aryRet[1] = testInts[rptr];
            }

            lptr++;
            rptr++;
        }

        return aryRet;
    }
}