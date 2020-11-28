using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private SortedList<string, int> namesAndGrades = new SortedList<string, int>();

    public void Add(string student, int grade)
    {
        if(namesAndGrades.ContainsKey(student))
        {
            throw new ArgumentException("Key is already used");
        } else
        {
            namesAndGrades.Add(student, grade);
        }
    }

    public IEnumerable<string> Roster()
    {
        return namesAndGrades.OrderBy(x => x.Value).Select(x => x.Key);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return namesAndGrades.Where(x => x.Value == grade).Select(x => x.Key);
    }
}