using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SSSIncSystem
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\securiforce.mdf;Integrated Security=True;Connect Timeout=30");
        private object addEmployee_employeeid;

        public AddEmployee()
        {
            InitializeComponent();

            displayEmployeeData();
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeeData();
        }
        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

            dataGridView1.DataSource = listData;
        }
        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == ""
                || addEmployee_lastname.Text == ""
                || addEmployee_firstname.Text == ""
                || addEmployee_middlename.Text == ""
                || addEmployee_sss.Text == ""
                || addEmployee_tin.Text == ""
                || addEmployee_pagibig.Text == ""
                || addEmployee_address.Text == ""
                || addEmployee_cashcard.Text == ""
                || addEmployee_assignmentdesignation.Text == ""
                || addEmployee_lisence.Text == ""
                || addEmployee_expirydate.Text == ""
                || addEmployee_cellphone.Text == ""
                || addEmployee_datehired.Text == ""
                || addEmployee_dateresigned.Text == ""
                || addEmployee_status.Text == ""
                || addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmployeeID = "SELECT COUNT(*) FROM employees WHERE employee_id = @checkEmployeeID AND delete_date IS NULL";

                        using (SqlCommand checkEmployee = new SqlCommand(checkEmployeeID, connect))
                        {
                            checkEmployee.Parameters.AddWithValue("@checkEmployeeID", addEmployee_id.Text.Trim());
                            int count = (int)checkEmployee.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addEmployee_id.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employees " +
                                   "(employee_id, lastname, firstname, middlename, sss, tin, pagibig, philhealth " +
                                   ", address, cashcard, assignmentdesignation, lisence, expirydate " +
                                   ", cellphone, datehired, dateresigned, status, image) " +
                                   " VALUES (@employee_id, @lastname, @firstname, @middlename, @sss, @tin, @pagibig, @philhealth " +
                                   ", @address, @cashcard, @assignmentdesignation, @lisence, @expirydate " +
                                   ", @cellphone, @datehired, @dateresigned, @status, @image) ";

                                string picturePath = Path.Combine(@"C:\Users\Crisanta 1\source\repos\SSSIncSystem\Directory\"
                                    + addEmployee_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(picturePath);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addEmployee_picture.ImageLocation, picturePath, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employee_id", addEmployee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@lastname", addEmployee_lastname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@firstname", addEmployee_firstname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@middlename", addEmployee_middlename.Text.Trim());
                                    cmd.Parameters.AddWithValue("@sss", addEmployee_sss.Text.Trim());
                                    cmd.Parameters.AddWithValue("@tin", addEmployee_tin.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pagibig", addEmployee_pagibig.Text.Trim());
                                    cmd.Parameters.AddWithValue("@philhealth", addEmployee_philhealth.Text.Trim());
                                    cmd.Parameters.AddWithValue("@address", addEmployee_address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cashcard", addEmployee_cashcard.Text.Trim());
                                    cmd.Parameters.AddWithValue("@assignmentdesignation", addEmployee_assignmentdesignation.Text.Trim());
                                    cmd.Parameters.AddWithValue("@lisence", addEmployee_lisence.Text.Trim());
                                    cmd.Parameters.AddWithValue("@expirydate", addEmployee_expirydate.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cellphone", addEmployee_cellphone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@datehired", addEmployee_datehired.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateresigned", addEmployee_dateresigned.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", picturePath);

                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void addEmployee_ImportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addEmployee_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addEmployee_id.Text = row.Cells[1].Value.ToString();
                addEmployee_lastname.Text = row.Cells[2].Value.ToString();
                addEmployee_firstname.Text = row.Cells[3].Value.ToString();
                addEmployee_middlename.Text = row.Cells[4].Value.ToString();
                addEmployee_sss.Text = row.Cells[5].Value.ToString();
                addEmployee_tin.Text = row.Cells[6].Value.ToString();
                addEmployee_pagibig.Text = row.Cells[7].Value.ToString();
                addEmployee_philhealth.Text = row.Cells[8].Value.ToString();
                addEmployee_address.Text = row.Cells[9].Value.ToString();
                addEmployee_cashcard.Text = row.Cells[10].Value.ToString();
                addEmployee_assignmentdesignation.Text = row.Cells[11].Value.ToString();
                addEmployee_lisence.Text = row.Cells[12].Value.ToString();
                addEmployee_cellphone.Text = row.Cells[13].Value.ToString();
                addEmployee_datehired.Text = row.Cells[14].Value.ToString();
                addEmployee_dateresigned.Text = row.Cells[15].Value.ToString();

                string imagePath = row.Cells[16].Value.ToString();

                if (imagePath != null)
                {
                    addEmployee_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addEmployee_picture.Image = null;
                }

                addEmployee_status.Text = row.Cells[17].Value.ToString();
            }
        }
        public void clearFields()
        {
            addEmployee_id.Text = "";
            addEmployee_lastname.Text = "";
            addEmployee_firstname.Text = "";
            addEmployee_middlename.Text = "";
            addEmployee_sss.Text = "";
            addEmployee_tin.Text = "";
            addEmployee_pagibig.Text = "";
            addEmployee_philhealth.Text = "";
            addEmployee_address.Text = "";
            addEmployee_cashcard.Text = "";
            addEmployee_assignmentdesignation.Text = "";
            addEmployee_lisence.Text = "";
            addEmployee_expirydate.Text = "";
            addEmployee_cellphone.Text = "";
            addEmployee_datehired.Text = "";
            addEmployee_dateresigned.Text = "";
            addEmployee_status.SelectedIndex = -1;
            addEmployee_picture.Image = null;
        }

        private void addEmployee_updateBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == ""
                || addEmployee_lastname.Text == ""
                || addEmployee_firstname.Text == ""
                || addEmployee_middlename.Text == ""
                || addEmployee_sss.Text == ""
                || addEmployee_tin.Text == ""
                || addEmployee_pagibig.Text == ""
                || addEmployee_philhealth.Text == ""
                || addEmployee_address.Text == ""
                || addEmployee_cashcard.Text == ""
                || addEmployee_assignmentdesignation.Text == ""
                || addEmployee_lisence.Text == ""
                || addEmployee_expirydate.Text == ""
                || addEmployee_cellphone.Text == ""
                || addEmployee_datehired.Text == ""
                || addEmployee_dateresigned.Text == ""
                || addEmployee_status.Text == ""
                || addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                   , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + addEmployee_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET lastname = @lastname" +
                        ", firstname = @firstname, middlename = @middlename, sss = @sss" +
                        ", tin = @tin, pagibig = @pagibig, philhealth = @philhealth, address = @address" +
                        ", cashcard = @cashcard, assignmentdesignation = @assignmentdesignation, lisence = @lisence" +
                        ", expirydate = @expirydate, cellphone = @cellphone, datehired = @datehired, dateresigned = @dateresigned, status = @status" +
                        " WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                            cmd.Parameters.AddWithValue("@lastname", addEmployee_lastname.Text.Trim());
                            cmd.Parameters.AddWithValue("@firstname", addEmployee_firstname.Text.Trim());
                            cmd.Parameters.AddWithValue("@middlename", addEmployee_middlename.Text.Trim());
                            cmd.Parameters.AddWithValue("@sss", addEmployee_sss.Text.Trim());
                            cmd.Parameters.AddWithValue("@tin", addEmployee_tin.Text.Trim());
                            cmd.Parameters.AddWithValue("@pagibig", addEmployee_pagibig.Text.Trim());
                            cmd.Parameters.AddWithValue("@philhealth", addEmployee_philhealth.Text.Trim());
                            cmd.Parameters.AddWithValue("@address", addEmployee_address.Text.Trim());
                            cmd.Parameters.AddWithValue("@cashcard", addEmployee_cashcard.Text.Trim());
                            cmd.Parameters.AddWithValue("@assignmentdesignation", addEmployee_assignmentdesignation.Text.Trim());
                            cmd.Parameters.AddWithValue("@lisence", addEmployee_lisence.Text.Trim());
                            cmd.Parameters.AddWithValue("@expirydate", addEmployee_expirydate.Text.Trim());
                            cmd.Parameters.AddWithValue("@cellphone", addEmployee_cellphone.Text.Trim());
                            cmd.Parameters.AddWithValue("@datehired", addEmployee_datehired.Text.Trim());
                            cmd.Parameters.AddWithValue("@dateresigned", addEmployee_dateresigned.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void addEmployee_clearBtn_Click(object sender, EventArgs e)
        {
            {
                clearFields();
            }
        }
        private void addEmployee_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == ""
                || addEmployee_lastname.Text == ""
                || addEmployee_firstname.Text == ""
                || addEmployee_middlename.Text == ""
                || addEmployee_sss.Text == ""
                || addEmployee_tin.Text == ""
                || addEmployee_pagibig.Text == ""
                || addEmployee_philhealth.Text == ""
                || addEmployee_address.Text == ""
                || addEmployee_cashcard.Text == ""
                || addEmployee_assignmentdesignation.Text == ""
                || addEmployee_lisence.Text == ""
                || addEmployee_expirydate.Text == ""
                || addEmployee_cellphone.Text == ""
                || addEmployee_datehired.Text == ""
                || addEmployee_dateresigned.Text == ""
                || addEmployee_status.Text == ""
                || addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                   , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Employee ID: " + addEmployee_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET delete_date = @deleteDate " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}

