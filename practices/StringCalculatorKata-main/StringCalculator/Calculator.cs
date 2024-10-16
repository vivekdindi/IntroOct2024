public class Calculator
{
    public int Add(string numbers)
    {
        bool hasDelimiters = false;


        // List<string> delimiters = new() { ",", "\n" };

        if (numbers == "" || numbers.Length == 0)
        {
            return 0;
        }

        else if (numbers.Contains(","))
        {

            var sum = 0;
            for (int i = 0; i < numbers.Split(',').Length; i++)
            {
                string num = numbers.Split(',')[i];
                sum += Convert.ToInt32(num);

            }
            return sum;


        }



        else if (numbers.Contains("\n"))
        {

            var sum = 0;
            for (int i = 0; i < numbers.Split('\n').Length; i++)
            {
                string num = numbers.Split('\n')[i];
                sum += Convert.ToInt32(num);

            }
            return sum;

        }

        else if (numbers.Contains(",") || numbers.Contains("\n"))
        {
            var sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (Char.IsDigit(numbers[i]))
                {
                    sum += Convert.ToInt32(numbers[i]);
                }

            }
            return sum;

        }



        else return Convert.ToInt32(numbers);



    }


}
