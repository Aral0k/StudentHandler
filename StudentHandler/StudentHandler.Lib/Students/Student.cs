using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentHandler.Lib.Students
{
    public class Student : IStudent
    {
        public string Name => _name;
        public IReadOnlyList<int> Marks => _marks.AsReadOnly();

        public double AverageMark
        {
            get
            {
                if (_marks.Count == 0)
                {
                    return 0;
                }
                return (double) _marks.Sum() / _marks.Count;
            }
        }

        public bool IsContractor
        {
            get => _isContractor;
            set => _isContractor = value;
        }

        private string _name;
        private List<int> _marks;
        private bool _isContractor;

        public Student(string name, bool isContractor)
        {
            _name = name;
            IsContractor = isContractor;
        }

        public void AddMarks(params int[] marks)
        {
            if (marks is null)
            {
                throw new ArgumentNullException();
            }
            foreach (var mark in marks)
            {
                _marks.Add(mark);
            }
        }
    }
}