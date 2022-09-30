namespace MissingNumbersCheck
{
    public class MissingNumberCheck
    {
        public int[] CheckForMissingNumbers(int[] input)
        {
            if (input == null || input.Length == 0)
            {
                return new int[0];
            }

            int[] sortedInput = new int[input.Length];
            foreach (var inputNumber in input)
            {
                if (inputNumber != 0)
                {
                    sortedInput[inputNumber - 1] = inputNumber;
                }
            }

            var result = new List<int>();
            for (int i = 0; i < sortedInput.Length; i++)
            {
                if (sortedInput[i] == 0)
                {
                    result.Add(i + 1);
                }
            }

            return result.ToArray();
        }

        public int[] CheckForMissingNumbersViaSwap(int[] input)
        {
            if (input == null || input.Length == 0)
            {
                return new int[0];
            }

            int i = 0;
            while (i < input.Length)
            {
                int swapTemp;
                var inputNumber = input[i];
                if (inputNumber != 0 && inputNumber - 1 != i)
                {
                    swapTemp = input[inputNumber - 1];
                    input[inputNumber - 1] = inputNumber;
                    input[i] = swapTemp;
                }
                else
                {
                    i++;
                }
            }

            var result = new List<int>();
            for (i = 0; i < input.Length; i++)
            {
                if (input[i] == 0)
                {
                    result.Add(i + 1);
                }
            }

            return result.ToArray();
        }
    }
}
