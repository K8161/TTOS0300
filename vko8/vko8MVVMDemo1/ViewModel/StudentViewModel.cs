using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMDemo.Model;
using System.Collections.ObjectModel;
using MySql.Data.MySqlClient;

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

        //metodi StudentViewModeliin jolla haetaan oppilastiedot mysql-palvemilta
        public void LoadStudentsFromMysql()
        {
            try
            {
                ObservableCollection<Student> students = new ObservableCollection<Student>();
                //luodaan yhteys labranetin mysql-palvelimelle
                string connStr = GetMysqlConnectionString();
                string sql = "SELECT firstname, lastname, asioid FROM student";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MVVMDemo.Model.Student s = new Model.Student();
                            s.FirstName = reader.GetString(0);
                            s.LastName = reader.GetString(1);
                            s.Asioid = reader.GetString(2);
                            students.Add(s);
                        }
                        Students = students;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        private string GetMysqlConnectionString()
        {
            string pw = "";
            // haetaan salasana App.Config- konfiguraatiotiedostosta
            pw = MVVMDemo.Properties.Settings.Default.passu;
            return string.Format
                ("Data source=mysql.labranet.jamk.fi;Initial Catalog=K8161_3;username=K8161;password={0}", pw);
        }
    }
}
