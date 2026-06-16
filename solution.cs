public class Solution {
    private TreeNode root = null;

    private void binsert(int[] nums, int low, int high){
        if(low <= high){
            int mid = (low + high) / 2;
            insert(nums[mid]);
            binsert(nums, low, mid - 1);
            binsert(nums, mid + 1, high);
        }
    }

    private void insert(int val){
        if(this.root == null){
            this.root = new TreeNode(val);
        }
        else{
            if(val < this.root.val){
                if(this.root.left == null){
                    this.root.left = new TreeNode(val);
                }
                else{
                    insert(val, this.root.left);
                }
            }
            else{
                if(this.root.right == null){
                    this.root.right = new TreeNode(val);
                }
                else{
                    insert(val, this.root.right);
                }
            }
        }
    }

    private void insert(int val, TreeNode root){
        if(val < root.val){
                if(root.left == null){
                    root.left = new TreeNode(val);
                }
                else{
                    insert(val, root.left);
                }
            }
            else{
                if(root.right == null){
                    root.right = new TreeNode(val);
                }
                else{
                    insert(val, root.right);
                }
            }
    }

    public TreeNode SortedArrayToBST(int[] nums) {
        binsert(nums, 0, nums.Length - 1);
        return(this.root);
    }
}
