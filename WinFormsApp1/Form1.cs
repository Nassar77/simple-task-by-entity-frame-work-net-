using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CompanySdContext Db = new CompanySdContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            Project_GV.DataSource = Db.Employees.Include(x=>x.Departments).Select(a=>new
            { Name=a.Fname+a.Lname,Sallary=a.Salary,Addres=a.Address}
            ).ToList();

            Dept_box.DataSource = Db.Departments.ToList();
            Dept_box.DisplayMember = "Dname";
            Dept_box.ValueMember ="Dnum";
            // Project_GV.DataSource = project;
            //Project_GV.DataSource = Db.Employees.Where(x => x.Salary>1000).ToList();
            // Project_GV.DataSource = Db.Employees.Select(x => new { name = x.Fname + x.Lname, salary = x.Salary }).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project_GV.DataSource = Db.Employees.Include(x => x.Departments).Where( s => s.Fname.Contains(Search_bt.Text)).Select(a => new
            { Name = a.Fname + a.Lname, Sallary = a.Salary, Addres = a.Address }
            ).ToList();
        }

        private void Rest_btn_Click(object sender, EventArgs e)
        {
            Project_GV.DataSource = Db.Employees.Include(x => x.Departments).Select(a => new
            { Name = a.Fname + a.Lname, Sallary = a.Salary, Addres = a.Address }).ToList();
            Search_bt.Text=string.Empty;
            Fname_txt.Text = string.Empty;
            Lname_txt.Text = string.Empty;
            Ssn_txt.Text = string.Empty;
        }

        private void Add_bt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Fname_txt?.Text) ||
               string.IsNullOrWhiteSpace(Lname_txt?.Text) ||
               string.IsNullOrWhiteSpace(Ssn_txt?.Text))
            {
               
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.TryParse(Ssn_txt.Text, out int ssn))
            {
                var check=Db.Employees.Where(x=> x.Ssn==ssn).ToList();
                if (check.Any()) {
                    MessageBox.Show("the ssn is found.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    Employee employee = new Employee
                    {
                        Fname = Fname_txt?.Text,
                        Lname = Lname_txt?.Text,
                        Ssn = int.Parse(Ssn_txt.Text),
                       
                       Dno =(int) Dept_box.SelectedValue

                    };
                    if (Db?.Employees != null)
                    {
                        Db.Employees.Add(employee);
                        Db.SaveChanges();
                        Project_GV.DataSource = Db.Employees.Include(x => x.Departments).Select(a => new
                        { Name = a.Fname + a.Lname, Sallary = a.Salary, Addres = a.Address }).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Database connection error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                
                MessageBox.Show("Invalid SSN. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
