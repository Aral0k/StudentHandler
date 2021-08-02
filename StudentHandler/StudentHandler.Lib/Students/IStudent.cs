using System.Collections.Generic;

namespace StudentHandler.Lib.Students
{
    public interface IStudent
    {
        string Name { get; }
        IReadOnlyList<int> Marks { get; }
        double AverageMark { get; }
        bool IsContractor { get; set; }

        void AddMarks(params int[] marks);
    }
}