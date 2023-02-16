namespace MyAvgLib
{
    public class Avg{
        public static double MyAvg(double numOne, double numTwo){
            double avg;
            avg = (numOne+numTwo)/2;

            System.Console.WriteLine($"The Average of {numOne} and {numTwo} is {avg}");
            return avg;
        }
    }
}