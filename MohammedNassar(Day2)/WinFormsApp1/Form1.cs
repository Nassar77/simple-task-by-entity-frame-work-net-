using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Project_GV.DataSource = Db.Employees.ToList();
        }
        CompanySdContext Db = new CompanySdContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            var project = Db.Projects.ToList();
            // Project_GV.DataSource = project;
            //Project_GV.DataSource = Db.Employees.Where(x => x.Salary>1000).ToList();
            // Project_GV.DataSource = Db.Employees.Select(x => new { name = x.Fname + x.Lname, salary = x.Salary }).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project_GV.DataSource = Db.Employees.Where( s => s.Fname.Contains(Search_bt.Text)).ToList();
        }

        private void Rest_btn_Click(object sender, EventArgs e)
        {
            Project_GV.DataSource = Db.Employees.ToList();
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
                    Employee employee = new Employee
                    {
                        Fname = Fname_txt?.Text,
                        Lname = Lname_txt?.Text,
                        Ssn = int.Parse(Ssn_txt.Text)
                    };
                if (Db?.Employees != null)
                {
                    Db.Employees.Add(employee);
                    Db.SaveChanges();
                    Project_GV.DataSource = Db.Employees.ToList();
                }
                else
                {
                    MessageBox.Show("Database connection error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                
                MessageBox.Show("Invalid SSN. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
