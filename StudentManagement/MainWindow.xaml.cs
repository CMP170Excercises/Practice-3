using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string  Firstname { get; set; }
        public string  Lastname { get; set; }
        public string  Email  { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public string Gpa  { get; set; }
    }
}
