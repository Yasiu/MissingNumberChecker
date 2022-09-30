using MissingNumbersCheck;

var input = new int[] { 0, 0, 0, 1 }; // Just put here any numbers you like
var missingNumberCheck = new MissingNumberCheck();
var output = missingNumberCheck.CheckForMissingNumbers(input);
var outputViaSwap = missingNumberCheck.CheckForMissingNumbersViaSwap(input);
Console.WriteLine("Result: {0}", string.Join(" ", output));
Console.WriteLine("Result via swap: {0}", string.Join(" ", outputViaSwap));