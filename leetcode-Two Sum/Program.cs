using leetcode_Two_Sum;

Console.WriteLine("Two Sum\n");
Console.WriteLine("Введите а б\n");
int[]? nums = { 1, 2, 3 };
int target = 5;
var twoSum = new Two_sum();
int[]? answer = twoSum.TwoSum(nums, target);
Console.WriteLine(answer);