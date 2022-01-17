DateTime dateValue = new DateTime(2013, 9, 15, 12, 0, 0);
for (int i = 0; i < 60 * 24; i++)
{
    double minute = i;

    string data = dateValue.AddMinutes(minute).ToString("H:mm");
    Console.WriteLine(data);
    char[] normal = data.ToArray();
    char[] reversed = data.ToArray();
    Array.Reverse(reversed);

    string palindrome = "tak palindrom";
    for (int j = 0; j < normal.Count(); j++)
    {
        if (normal[j] != reversed[j])
        {
            palindrome = "ni";
        }
    }

    Console.WriteLine("palindrom? : " + palindrome);
}