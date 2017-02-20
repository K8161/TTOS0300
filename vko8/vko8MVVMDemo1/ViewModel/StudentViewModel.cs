using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMDemo.Model;
using System.Collections.ObjectModel;

namespace MVVMDemo.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }
        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            students.Add(new Student { FirstName = "Mark", LastName = "Allen", Asioid="A1234" });
            students.Add(new Student { FirstName = "John", LastName = "Doe", Asioid = "B666" });
            students.Add(new Student { FirstName = "Linda", LastName = "Kernell", Asioid = "K2456" });
            Students = students;
        }
    }
}
