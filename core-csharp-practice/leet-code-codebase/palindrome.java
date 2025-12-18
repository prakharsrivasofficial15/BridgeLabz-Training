class Solution {
    public boolean palindrome(int x) {
        // Negative numbers and numbers ending with zero (except zero itself) are not palindromes
        if (x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }

        int reversedHalf = 0;
        while (x > reversedHalf) {
            int last = x % 10;
            reversedHalf = reversedHalf * 10 + last;
            x = x / 10;
        }

        // When the length is odd, we can get rid of the middle digit by reversedHalf/10
        return x == reversedHalf || x == reversedHalf / 10;
    }
}
