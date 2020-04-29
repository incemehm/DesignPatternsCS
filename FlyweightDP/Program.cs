namespace FlyweightDP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = new string[] { "AA", "BA", "BB", "AA", "CC", "FF", "FF", "BB", "CC", "BB", "AA", "CC", "FF", "BB", "CC", "BA" };
            GradePool gradePool = new GradePool();

            foreach (string letter in letters)
            {
                Grade grade = gradePool.GetGrade(letter);
                grade.Print();
            }
        }
    }
}
