import java.util.*;
class Solution {
    public int[] twosum(int[] nums, int target) {
        int n = nums.length;
        HashMap<Integer, Integer> hm = new HashMap<>();
        for(int i=0; i<n; i++){
            int complement= target - nums[i];
            if(hm.containsKey(complement)){
                return new int[] {hm.get(complement), i};
            }
            hm.put(nums[i], i);
        }
        return new int[] {-1, -1};
    }
}