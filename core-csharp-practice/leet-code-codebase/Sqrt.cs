class Solution{
    public int MySqrt(int x){
        int i=-1;
        int num=-1;
        while(x>=0){
            i+=2;
            x=x-i;
            num++;
        }
        return num;
    }
}
