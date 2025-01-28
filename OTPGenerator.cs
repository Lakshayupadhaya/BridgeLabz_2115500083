using System;

public class OTPGenerator
{
    // Method to generate a 6-digit OTP number using Math.Random()
    public static int GenerateOTP()
    {
        Random rand = new Random();
        // Generate a random number between 100000 and 999999 (inclusive)
        return rand.Next(100000, 1000000);
    }

    // Method to check if all OTP numbers are unique
    public static bool AreOTPsUnique(int[] otps)
    {
        // Compare each OTP with every other OTP in the array
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])  // If a duplicate is found, return false
                {
                    return false;
                }
            }
        }
        return true;  // All OTPs are unique
    }

    public static void Main()
    {
        int[] otps = new int[10];  // Array to store the generated OTPs
        
        // Generate 10 OTP numbers
        for (int i = 0; i < otps.Length; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine("OTP " + (i + 1) + ": " + otps[i]);
        }

        // Check if all OTPs are unique
        if (AreOTPsUnique(otps))
        {
            Console.WriteLine("All OTP numbers are unique.");
        }
        else
        {
            Console.WriteLine("There are duplicate OTP numbers.");
        }
    }
}
