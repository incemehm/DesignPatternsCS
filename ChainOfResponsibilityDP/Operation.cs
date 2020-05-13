namespace ChainOfResponsibilityDP
{
    public abstract class Operation
    {
        private Operation next;

        public Operation SetNextOperation(Operation operation)
        {
            this.next = operation;
            return operation;
        }

        public void Start(string word)
        {
            string result = DoProcess(word);

            if (next != null)
            {
                next.Start(result);
            }
        }

        protected abstract string DoProcess(string word);
    }
}
