using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inventoryManagementSystem_Div2_Internal_
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        Inventory i;
        string command;
        public Form1()
        {
            InitializeComponent();
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\prath\\OneDrive\\Desktop\\Pratham Data\\SEM 5\\ADNF\\Practicals\\inventoryManagementSystem(Div2_Internal)\\inventoryManagementSystem(Div2_Internal)\\dbInventory.mdf\";Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(conString);
        }

        // functions 
        // Insert data in Database 
        private void dbInsert(Inventory i)
        {
            try
            {
                command = $"insert into tblProductDetails(serialNum,pName,Quantity,price,brand) values('{i.serialNum}','{i.name}',{i.Quantity},{i.price},'{i.brand}')";
                cmd = new SqlCommand(command, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"{i.name}'s Data Inserted Succesfully!!", "Data Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something Went Wrong!!\n" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // collect data from database and display in datagridview
        private void dbDisplay()
        {
            try
            {
                command = "select serialNum,pName,Quantity,price,brand from tblProductDetails";
                da = new SqlDataAdapter(command, conn);
                dt = new DataTable();
                da.Fill(dt);

                dgDisplay.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something Went Wrong!!\n" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // collect id and name and fill the combobox
        private void fillComboBox()
        {
            try
            {
                command = $"select Id,pName from tblProductDetails";
                da = new SqlDataAdapter(command, conn);
                dt = new DataTable();
                da.Fill(dt);

                DataRow row = dt.NewRow();
                row["Id"] = -1;
                row["pName"] = "-- Select --";
                dt.Rows.InsertAt(row, 0);

                cmbUpdateProduct.ValueMember = "Id";
                cmbUpdateProduct.DisplayMember = "pName";
                cmbUpdateProduct.DataSource = dt;

                cmbUpdateProduct.SelectedValue = -1;

                int id = Convert.ToInt32(cmbUpdateProduct.SelectedValue);
                fillUpdateBoxes(id);
            }
            catch (Exception e) {
                MessageBox.Show("Something Went Wrong!!\n" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // collect data from database and fill Update tab textboxes 
        private void fillUpdateBoxes(int id)
        {
            try
            {
                if (id != -1)
                {
                    command = $"select serialNum,pName,Quantity,price,brand from tblProductDetails where id = {id}";
                    cmd = new SqlCommand(command, conn);
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    txtUpSrNo.Text = dr["serialNum"].ToString();
                    txtUpQuan.Text = dr["Quantity"].ToString();
                    txtUpPrice.Text = dr["price"].ToString();
                    txtUpBrand.Text = dr["brand"].ToString();

                    dr.Close();
                    conn.Close();
                }
                else
                    resetUpdate();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something Went Wrong!!\n" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // update database
        private void dbUpdate(Inventory i)
        {
            try
            {
                int q = Convert.ToInt32(i.Quantity) + Convert.ToInt32(txtUpMoreQuan.Text);
                command = $"update tblProductDetails set Quantity = {q} where id = {i.id}";
                cmd = new SqlCommand(command, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"Quantity Added for {i.name}, Toal Quantity is {q} now.","Quantity Added",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong!!\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // reset insert tab textboxes
        protected void reset()
        {
            txtProductName.Text = string.Empty;
            txtSerialNum.Text = string.Empty;
            txtQuan.Text = "0";
            txtPricePerProduct.Text = "0";
            txtBrand.Text = string.Empty;
            txtProductName.Focus();
        }

        //reset update tab textboxes
        protected void resetUpdate()
        {
            cmbUpdateProduct.SelectedValue = -1;
            txtUpBrand.Text = "";
            txtUpSrNo.Text = string.Empty;
            txtUpPrice.Text = "0";
            txtUpQuan.Text= "0";
            txtUpMoreQuan.Text = "0";
            cmbUpdateProduct.Focus();
        }

        // events
        // insert button event
        private void btnInsert_Clicked(object sender, EventArgs e)
        {
            i = new Inventory();
            i.serialNum = txtSerialNum.Text;
            i.name = txtProductName.Text;
            i.price = Convert.ToInt32(txtPricePerProduct.Text);
            i.brand = txtBrand.Text;
            i.Quantity = Convert.ToInt32(txtQuan.Text);

            dbInsert(i);
            reset();
        }

        // update button click
        private void btnUpdate_Clicked(object sender, EventArgs e)
        {
            i = new Inventory();
            i.id = Convert.ToInt32(cmbUpdateProduct.SelectedValue);            
            i.name = cmbUpdateProduct.Text;
            i.Quantity = Convert.ToInt32(txtUpQuan.Text);            

            dbUpdate(i);
            resetUpdate();
        }

        // reset button clicked
        private void btnReset_Clicked(object sender, EventArgs e)
        {
            reset();
        }

        // tab contoller tab change event
        private void tabController_tabChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabDisplay)            
                dbDisplay();
            else if (tabControl1.SelectedTab == tabUpdate)            
                fillComboBox();            
        }

        // combobox value change event
        private void cmbUpdateProduct_valueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbUpdateProduct.SelectedValue);
            fillUpdateBoxes(id);
        }

        // number entered in textboxes event
        private void txtBox_numEnter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            try
            {                
                int num = Convert.ToInt32(t.Text);
            }
            catch
            {
                if (!(t.Text == ""))
                {
                    MessageBox.Show("Can't Enter Non Numeric Value Here!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    t.Text = "0";
                }
            }
        }
    }
}