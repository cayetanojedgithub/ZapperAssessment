internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter user settings string:");
        var input = Console.ReadLine();

        Console.WriteLine("1 - SMS Notifications Enabled");
        Console.WriteLine("2 - Push Notifications Enabled");
        Console.WriteLine("3 - Bio-metrics Enabled");
        Console.WriteLine("4 - Camera Enabled");
        Console.WriteLine("5 - Location Enabled");
        Console.WriteLine("6 - NFC Enabled");
        Console.WriteLine("7 - Vouchers Enabled");
        Console.WriteLine("8 - Loyalty Enabled");
        Console.WriteLine("Please select feature number to test:");
        var featureNumber = Console.ReadLine();

        var result = IsFeatureEnabled(input, featureNumber);

        Console.WriteLine(result);

        Console.WriteLine("Would you like to save the input to a file? [y/n]");
        var response = Console.ReadLine();

        if (response != null && response.ToLower() == "y")
        {
            SaveInputSettings(input);
        }


        bool IsValid8BitBinary(string input)
        {
            if (input.Length != 8)
            {
                return false;
            }

            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }

            return true;
        }

        bool IsFeatureEnabled(string input, string featureNumber)
        {
            bool result = true;
            if (!IsValid8BitBinary(input))
            {
                Console.WriteLine("Invalid input settings. Input must be a string representing a valid 8-bit binary consisting only of 1s or 0s.");
                result = false;
            }

            int intFeatureNumber;

            if (!int.TryParse(featureNumber, out intFeatureNumber) || intFeatureNumber < 0 || intFeatureNumber > 8)
            {
                Console.WriteLine("Invalid feature number. Please select number from 1 - 8");
                result = false;
            }

            return result && input[intFeatureNumber - 1] == '1';
        }

        void SaveInputSettings(string input)
        {
            string filePath = "inputSettings.bin";
            byte settingsByte = Convert.ToByte(input, 2);
            File.WriteAllBytes(filePath, new[] { settingsByte });
        }
    }
}