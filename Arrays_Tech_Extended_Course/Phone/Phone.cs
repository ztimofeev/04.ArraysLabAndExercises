namespace Phone
{
    using System;

    public class Phone
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split(' ');
            var names = Console.ReadLine().Split(' ');

            var len = phoneNumbers.Length;

            var newCall = Console.ReadLine().Split(' ');

            while (newCall[0] != "done")
            {
                if (newCall[0] == "call")
                {  
                    for (int i = 0; i < len; i++)
                    {
                        ActionInCallCase(newCall[1], names[i], phoneNumbers[i]); 
                    }
                }
                else if (newCall[0] == "message")
                {
                    for (int i = 0; i < len; i++)
                    {
                        ActionInMessageCase(newCall[1], names[i], phoneNumbers[i]);
                        
                    }
                }

                newCall = Console.ReadLine().Split(' ');
            }
        }

        
        public static void ActionInCallCase(string callType, string name, string phoneNumber)
        {
            if (callType == name)
            {
                Console.WriteLine($"calling {phoneNumber}...");

                var sumNumbs = SumOfNumbers(phoneNumber);

                if (sumNumbs % 2 == 0)
                {
                    var duration = CalculateCallDuration(sumNumbs);
                    Console.WriteLine($"call ended. duration: {duration}");
                }
                else
                {
                    Console.WriteLine("no answer");
                }
            }

            else if (callType == phoneNumber)
            {
                Console.WriteLine($"calling {name}...");

                var sumNumbs = SumOfNumbers(phoneNumber);

                if (sumNumbs % 2 == 0)
                {
                    var duration = CalculateCallDuration(sumNumbs);
                    Console.WriteLine($"call ended. duration: {duration}");
                }
                else
                {
                    Console.WriteLine("no answer");
                }
            }
        }

        public static void ActionInMessageCase(string callType, string name, string phoneNumber)
        {
            if (callType == name)
            {
                Console.WriteLine($"sending sms to {phoneNumber}...");

                var diffNumbs = DiffOfNumbers(phoneNumber);

                if (diffNumbs % 2 == 0)
                {
                    Console.WriteLine("meet me there");
                }
                else
                {
                    Console.WriteLine("busy");
                }
            }

            else if (callType == phoneNumber)
            {
                Console.WriteLine($"sending sms to {name}...");

                var diffNumbs = DiffOfNumbers(phoneNumber);

                if (diffNumbs % 2 == 0)
                {
                    Console.WriteLine("meet me there");
                }
                else
                {
                    Console.WriteLine("busy");
                }
            }
        }

        public static int DiffOfNumbers(string num)
        {
            int diffOfDigits = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != '+' && num[i] != '-' && num[i] != '(' && num[i] != ')')
                {
                    diffOfDigits -= (num[i] - '0');
                }
            }

            return Math.Abs(diffOfDigits);
        }

        public static int SumOfNumbers(string num)
        {
            int sumOfDigits = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != '+' && num[i] != '-' && num[i] != '(' && num[i] != ')')
                {
                    sumOfDigits += (num[i] - '0');
                }
            }

            return sumOfDigits;
        }

        public static string CalculateCallDuration(int x)
        {
            string durationOfCall;

            if (x < 60)
            {
                durationOfCall = "00:" + x;
            }
            else
            {
                var min = x / 60;
                var sec = x % 60;
                durationOfCall = "0" + min + ":" + sec;
            }

            return durationOfCall;
        }
    }
}
