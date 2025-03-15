
// if string is palindrome

bool IsPalindrome(string str)
{
    string reversed = string.Empty;

    char[] strArr = str.ToCharArray();

    for (int i = strArr.Length - 1; i >= 0; i--)
    {
        reversed += strArr[i];
    }

    if (reversed == str)
        return true;

    return false;
}

Console.WriteLine(IsPalindrome("racecar"));
Console.WriteLine(IsPalindrome("hello"));
Console.WriteLine(IsPalindrome("level"));

// if number is palindrome

bool isNumberPalindrome(int num)
{
    int reversedNum = 0;
    int original = num;

    while (num > 0)
    {
        int digit = num % 10;
        reversedNum = reversedNum * 10 + digit;
        num = num / 10;
    }

    if (reversedNum == original)
        return true;

    return false;
}

Console.WriteLine(isNumberPalindrome(1221));
Console.WriteLine(isNumberPalindrome(123321));
Console.WriteLine(isNumberPalindrome(10));
Console.WriteLine(isNumberPalindrome(123));