bool ContainsDuplicate(int[] nums)
{
    // for (int i = 0; i < nums.Length; i++)
    // {
    //     for (int j = i + 1; j < nums.Length; j++)
    //     {
    //         if (nums[i] == nums[j])
    //         {
    //             return true;
    //         }
    //     }
    // }
    //
    // return false;

    if (nums.Length != nums.Distinct().Count())
    {
        return true;
    }

    return false;
}

int[] nums = { 1, 2, 3, 4 };
Console.WriteLine(ContainsDuplicate(nums));