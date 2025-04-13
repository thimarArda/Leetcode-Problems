public class Solution {
    public int MajorityElement(int[] nums) {
        int ME = nums[0];
        int count = 1;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == ME) {
                count++;
            } 
            else {
                count--;

                if (count == 0) {
                    ME = nums[i];
                    count = 1;
                }
            }
        }
        return ME;
    }
}
