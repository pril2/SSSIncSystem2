using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SSSIncSystem
{
    class EmployeeData
    {
        public int ID { set; get; }
        private string employeeID { set; get; }
        public string Lastname { set; get; }
        public string Firstname { set; get; }
        public string Middlename { set; get; }
        public string SSS { set; get; }
        public string TIN { set; get; }
        public string Pagibig { set; get; }
        public string Philhealth { set; get; }
        public string Address { set; get; }
        public string Cashcard { set; get; }
        public string Assignmentdesignation { set; get; }
        public string Lisence { set; get; }
        public string Expirydate { set; get; }
        public string Cellphone { set; get; }
        public string Datehired { set; get; }
        public string Dateresigned { set; get; }
        public string Image { set; get; }
        public string Status { set; get; }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\securiforce.mdf;Integrated Security=True;Connect Timeout=30");


        public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData ed = new EmployeeData();
                            ed.ID = (int)reader["id"];
                            ed.employeeID = reader["employee_id"].ToString();
                            ed.Lastname = reader["lastname"].ToString();
                            ed.Firstname = reader["firstname"].ToString();
                            ed.Middlename = reader["middlename"].ToString();
                            ed.SSS = reader["sss"].ToString();
                            ed.TIN = reader["tin"].ToString();
                            ed.Pagibig = reader["pagibig"].ToString();
                            ed.Philhealth = reader["philhealth"].ToString();
                            ed.Address = reader["address"].ToString();
                            ed.Cashcard = reader["cashcard"].ToString();
                            ed.Assignmentdesignation = reader["assignmentdesignation"].ToString();
                            ed.Lisence = reader["lisence"].ToString();
                            ed.Expirydate = reader["expirydate"].ToString();
                            ed.Cellphone= reader["cellphone"].ToString();
                            ed.Datehired = reader["datehired"].ToString();
                            ed.Dateresigned = reader["dateresigned"].ToString();
                            ed.Image = reader["image"].ToString();
                            ed.Status = reader["status"].ToString();

                            listdata.Add(ed);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }

    }
}