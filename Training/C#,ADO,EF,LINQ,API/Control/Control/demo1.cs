using System;
class demo1
{
    public  void Bignum()
    {
        int num1, num2,num3;
        Console.WriteLine("enter 3 numbers");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        num3 = Convert.ToInt32(Console.ReadLine());
        if ((num1 == num2)&&(num1==num3))
            Console.WriteLine("both are equals");
        else if ((num1 > num2)&&(num1>num3))
            Console.WriteLine(num1 + " is greater than " + num2+" "+num3);
        else if ((num2 > num1) && (num2 > num3))
            Console.WriteLine(num2 + " is greater than " + num1+" "+num3);
        else 
            Console.WriteLine(num3 + " is greater than " + num1+" "+num2);

    }
    public void stc()
    {
        
        
    }
    public int loop(int max)
    {
        int sum=0,cou=1;
        do
        {
            sum += cou;
            cou++;
        } while (cou <= max);
        return sum;
    }
    public void frech(string s1)
    {
        
        foreach (char s in s1){
            Console.Write(s);
        }
    }
    public void ary()
    {
        int[] nums = new int[10];
        nums[0] = 12;
        nums[1] = 23;
        nums[2] = 32;
        nums[3] = 45;
        nums[4] = 32;
        nums[5] = 40;
        nums[6] = 50;
        foreach (int n in nums)
        {
            Console.Write(n);
        }
    }
    public void srt()
    {
        int[] nums = { 21, 2, 13, 33, 20, 90 };
        Array.Sort(nums);
        foreach(int n in nums)
        {
            Console.WriteLine(n);
        }
    }
}
