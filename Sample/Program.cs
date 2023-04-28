class Palindrome
{
    private string reverseString(string s)
    {
        char[] charsArrayString = s.ToCharArray();
        Array.Reverse(charsArrayString);
        String revString = new String(charsArrayString);
        return revString;
    }
    public bool checkPalindrome(string str)
    {
        Console.WriteLine(reverseString(str));
        if (str == reverseString(str)) {
            return true;
        }
        return false;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Palindrome palindrome = new Palindrome();
        Console.WriteLine("Enter the string to check for palindrome: ");
        string palindromeCheckString = Console.ReadLine();
        if (palindrome.checkPalindrome(palindromeCheckString))
        {
            Console.WriteLine("{0} is palindrome.", palindromeCheckString);
        }
        else
        {
            Console.WriteLine("{0} is not palindrome.", palindromeCheckString);
        }
    }
   

}