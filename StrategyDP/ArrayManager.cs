namespace StrategyDP
{
    public class ArrayManager
    {
        private ISortingAlgorithm  algorithm;

        public ArrayManager(ISortingAlgorithm algorithm)
        {
            this.algorithm = algorithm;
        }

        public void Sort(int[] numbers)
        {
            algorithm.Sort(numbers);
        }
    }
}
