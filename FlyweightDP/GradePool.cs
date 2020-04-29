using System.Collections.Generic;

namespace FlyweightDP
{
    public class GradePool
    {
        private Dictionary<string, Grade> gradeDict = new Dictionary<string, Grade>();

        public Grade GetGrade(string letter)
        {
            if (gradeDict.ContainsKey(letter))
                return gradeDict[letter];

            else
            {
                Grade grade = new Grade(letter);

                gradeDict.Add(letter, grade);

                return grade;
            }        
        }
    }
}
