# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def __init__(self):
        self.root = None

    def binsert(self, nums, low, high):
        if low <= high:
            mid = (low + high) // 2
            self.insert(nums[mid])
            self.binsert(nums, low, mid - 1)
            self.binsert(nums, mid + 1, high)

    def insert(self, val, node=None):
        if self.root is None:
            self.root = TreeNode(val)
            return

        if node is None:
            node = self.root

        if val < node.val:
            if node.left is None:
                node.left = TreeNode(val)
            else:
                self.insert(val, node.left)
        else:
            if node.right is None:
                node.right = TreeNode(val)
            else:
                self.insert(val, node.right)

    def sortedArrayToBST(self, nums: List[int]) -> Optional['TreeNode']:
        self.binsert(nums, 0, len(nums) - 1)
        return self.root
