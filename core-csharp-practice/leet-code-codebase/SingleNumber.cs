
class Solution {
    public int singleNumber(int[] n) {
        int re=0;
        for(int i=0; i<n.length; i++) {
            re = re^n[i];
        }
        return re;
    }
}
