using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
namespace StudentManagement
{

    public class SearchStudentViewModel : BaseViewModel
    {
        private string m_searchkeyword;

        public string Searchkeyword
        {
            get => m_searchkeyword;
            set
            {
                m_searchkeyword = value;
                OnPropertyChanged(nameof(Searchkeyword));

            }
        }

        private string m_selectedclass;
        public string Selectedclass
        {
            get => m_selectedclass;
            set
            {
                m_selectedclass = value;
                OnPropertyChanged(nameof(Selectedclass));

            }
        }

        private string m_selectedstudent;
        public string Selectedstudent
        {
            get => m_selectedstudent;
            set
            {
                m_selectedstudent = value;
                OnPropertyChanged(nameof(Selectedstudent));

            }
        }

        public ObservableCollection<Student> Students { get; set; }

        public ICommand SearchCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public ICommand OpenDetailCommand { get; set; }


        public class Student
        {
            public int studentId { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string email { get; set; }
            public string gender { get; set; }
            public string Class { get; set; }
            public decimal gpa { get; set; }
        }

        public SearchStudentViewModel()
        {
            var jsonString = File.ReadAllText("Student_Data.json");
            var students = JsonSerializer.Deserialize<List<Student>>(jsonString);
            Students = new ObservableCollection<Student>(students);

        }
    }
}
