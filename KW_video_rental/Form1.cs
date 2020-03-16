using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KW_video_rental
{
    public partial class Form1 : Form
    {
        int Rid = 0;
        int custClk = 0,VideoClk,rentClk=0;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnCAdd_Click(object sender, EventArgs e)
        {
            //the code to Insert the details of the customer for storing the details 
            if (!CName.Text.ToString().Equals("") && !CPlace.Text.ToString().Equals("") && !CContact.Text.ToString().Equals(""))
            {
                //callig the objct of the customer class to pass the record 
                Models.Customer obj = new Models.Customer();
                obj.Add(CName.Text.ToString(),CPlace.Text.ToString(),CContact.Text.ToString());

                CName.Text = "";
                CContact.Text = "";
                CPlace.Text = "";
            }
            else {
                MessageBox.Show("You Must have to fill all the details of the Customer to registere in the portal ");
            }
        }

        private void btnCDelete_Click(object sender, EventArgs e)
        {
            //the code to Delete the details of the customer for storing the details 
            if (txtCId.Text.ToString().Equals(""))
            {
                MessageBox.Show("You must have to select the Customer Record to delete from the Data Pannel ");
            }
            else {
                Models.Customer obj = new Models.Customer();
                obj.Delete(Convert.ToInt32(txtCId.Text.ToString()));
                txtCId.Text = "";
                CName.Text = "";
                CContact.Text = "";
                CPlace.Text = "";
            }
        }

        private void btnCUpdate_Click(object sender, EventArgs e)
        {

            //the code to update the details of the customer for storing the details 
            if (!txtCId.Text.ToString().Equals("")  && !CName.Text.ToString().Equals("") && !CPlace.Text.ToString().Equals("") && !CContact.Text.ToString().Equals(""))
            {
                Models.Customer obj = new Models.Customer();
                obj.Update(Convert.ToInt32(txtCId.Text.ToString()),CName.Text.ToString(),CPlace.Text.ToString(),CContact.Text.ToString());

                txtCId.Text = "";
                CName.Text = "";
                CContact.Text = "";
                CPlace.Text = "";


            }
        }

        private void btnCDetails_Click(object sender, EventArgs e)
        {
            //get the record from the table and pass to the data grid view 
            DataTable tbl = new DataTable();
            Models.Connection obj = new Models.Connection();
            tbl = obj.srchRecord("select * from CustomerRecord ");
            dgvDetails.DataSource = tbl;
            custClk = 1;
        }

        private void btnVAdd_Click(object sender, EventArgs e)
        {
            //the code to Insert the details of the video for storing the details 
            if (!txtVName.Text.ToString().Equals("") && !txtVRatting.Text.ToString().Equals("") && !txtVYear.Text.ToString().Equals("") && !txtVCopies.Text.ToString().Equals("") && !txtVPlot.Text.ToString().Equals("") && !txtVGenre.Text.ToString().Equals(""))
            {
                Models.Video obj = new Models.Video();
                obj.Add(txtVName.Text.ToString(),txtVRatting.Text.ToString(),Convert.ToInt32(txtVYear.Text.ToString()),Convert.ToInt32(txtVCopies.Text.ToString()),txtVPlot.Text.ToString(),txtVGenre.Text.ToString());

                txtVName.Text = "";
                txtVRatting.Text = "";
                txtVYear.Text = "";
                txtVCopies.Text = "";
                txtVPlot.Text = "";
                txtVGenre.Text = "";

            }
            else {
                MessageBox.Show("We Must have to fill all the details of the video ");
            }


        }

        private void btnVDelete_Click(object sender, EventArgs e)
        {
            //the code to delete the details of the video for storing the details 
            if (txtVId.Text.ToString().Equals(""))
            {
                MessageBox.Show("First select the details of the video to delete ");
            }
            else {
                Models.Video obj = new Models.Video();
                obj.Delete(Convert.ToInt32(txtVId.Text.ToString()));

                txtVId.Text = "";
                txtVName.Text = "";
                txtVRatting.Text = "";
                txtVYear.Text = "";
                txtVCopies.Text = "";
                txtVPlot.Text = "";
                txtVGenre.Text = "";


            }

        }

        private void btnVUpdate_Click(object sender, EventArgs e)
        {
            //the code to Update the details of the video for storing the details 
            if (!txtVId.Text.ToString().Equals("") && !txtVName.Text.ToString().Equals("") && !txtVRatting.Text.ToString().Equals("") && !txtVYear.Text.ToString().Equals("") && !txtVCopies.Text.ToString().Equals("") && !txtVPlot.Text.ToString().Equals("") && !txtVGenre.Text.ToString().Equals(""))
            {
                Models.Video obj = new Models.Video();
                obj.Update(Convert.ToInt32(txtVId.Text.ToString()),txtVName.Text.ToString(), txtVRatting.Text.ToString(), Convert.ToInt32(txtVYear.Text.ToString()), Convert.ToInt32(txtVCopies.Text.ToString()), txtVPlot.Text.ToString(), txtVGenre.Text.ToString());

                txtVName.Text = "";
                txtVRatting.Text = "";
                txtVYear.Text = "";
                txtVCopies.Text = "";
                txtVPlot.Text = "";
                txtVGenre.Text = "";
                txtVId.Text = "";


            }
        }

        private void btnVDetails_Click(object sender, EventArgs e)
        {
            //get the record from the table and pass to the data grid view 
            DataTable tbl = new DataTable();
            Models.Connection obj = new Models.Connection();
            tbl = obj.srchRecord("select * from VideoRecord");
            dgvDetails.DataSource = tbl;
            VideoClk = 1;


        }

        private void btnVIssue_Click(object sender, EventArgs e)
        {

            //code to issue the video on rent 
            if (!txtVId.Text.ToString().Equals("") && !txtCId.Text.ToString().Equals("")) {

                Models.Rental obj = new Models.Rental();
                obj.Add(Convert.ToInt32(txtCId.Text.ToString()),Convert.ToInt32(txtVId.Text.ToString()),dtpIssue.Text.ToString());


                txtVName.Text = "";
                txtVRatting.Text = "";
                txtVYear.Text = "";
                txtVCopies.Text = "";
                txtVPlot.Text = "";
                txtVGenre.Text = "";
                txtVId.Text = "";

                txtCId.Text = "";
                CName.Text = "";
                CContact.Text = "";
                CPlace.Text = "";

            }
        }

        private void BtnRentDelete_Click(object sender, EventArgs e)
        {
            //code to delete the rental video record from the details 

            if (Rid>0) {
                Models.Rental obj = new Models.Rental();
                obj.Delete(Rid);

                txtVName.Text = "";
                txtVRatting.Text = "";
                txtVYear.Text = "";
                txtVCopies.Text = "";
                txtVPlot.Text = "";
                txtVGenre.Text = "";
                txtVId.Text = "";

                txtCId.Text = "";
                CName.Text = "";
                CContact.Text = "";
                CPlace.Text = "";
                Rid = 0;

            }


        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (custClk==1) {
                txtCId.Text=dgvDetails.CurrentRow.Cells[0].Value.ToString();
                CName.Text=dgvDetails.CurrentRow.Cells[1].Value.ToString();
                CPlace.Text= dgvDetails.CurrentRow.Cells[2].Value.ToString();
                CContact.Text= dgvDetails.CurrentRow.Cells[3].Value.ToString();

            
            }

            if (rentClk==1) {

                Rid =Convert.ToInt32( dgvDetails.CurrentRow.Cells[0].Value.ToString());
                txtCId.Text= dgvDetails.CurrentRow.Cells[1].Value.ToString();
                txtVId.Text= dgvDetails.CurrentRow.Cells[2].Value.ToString();
                dtpIssue.Text= dgvDetails.CurrentRow.Cells[3].Value.ToString();
            
            }

            if (VideoClk==1) {
                txtVId.Text= dgvDetails.CurrentRow.Cells[0].Value.ToString();
                txtVName.Text= dgvDetails.CurrentRow.Cells[1].Value.ToString();
                txtVRatting.Text= dgvDetails.CurrentRow.Cells[2].Value.ToString();
                txtVYear.Text= dgvDetails.CurrentRow.Cells[3].Value.ToString();
                txtVCopies.Text= dgvDetails.CurrentRow.Cells[4].Value.ToString();
                txtVPlot.Text= dgvDetails.CurrentRow.Cells[5].Value.ToString();
                txtVGenre.Text= dgvDetails.CurrentRow.Cells[6].Value.ToString();
            

            }

            custClk = 0;
            rentClk = 0;
            VideoClk = 0;



        }

        private void btnCustomerMost_Click(object sender, EventArgs e)
        {
            DataTable tblData = new DataTable();
            Models.Connection Instance_Record = new Models.Connection();
            tblData = Instance_Record.srchRecord("select * from CustomerRecord ");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = Instance_Record.srchRecord("select * from RentRecord where CId=" + Convert.ToInt32(tblData.Rows[x]["ID"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["CName"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Top Customer Name is ==" + Title);


        }

        private void btnVideoMost_Click(object sender, EventArgs e)
        {
            DataTable tblData = new DataTable();
            Models.Connection Instance_Record = new Models.Connection();
            tblData = Instance_Record.srchRecord("select * from VideoRecord ");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = Instance_Record.srchRecord("select * from RentRecord where VId=" + Convert.ToInt32(tblData.Rows[x]["ID"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["VName"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            MessageBox.Show("Top Ratting Video  Title is ==" + Title);


        }

        private void btnRDetails_Click(object sender, EventArgs e)
        {

            // get the details of the rental video details frm the database table 
            DataTable tbl = new DataTable();
            Models.Connection obj = new Models.Connection();
            tbl = obj.srchRecord("select * from RentRecord");
            dgvDetails.DataSource = tbl;
            rentClk = 1;

        }

        private void btnVReturn_Click(object sender, EventArgs e)
        {
            //code to return the video on rent 
            if (!txtVId.Text.ToString().Equals("") && !txtCId.Text.ToString().Equals("") && Rid>0)
            {

                Models.Rental obj = new Models.Rental();
                obj.Update(Rid,Convert.ToInt32(txtCId.Text.ToString()), Convert.ToInt32(txtVId.Text.ToString()), dtpIssue.Text.ToString(),dtpReturn.Text.ToString());


                txtVName.Text = "";
                txtVRatting.Text = "";
                txtVYear.Text = "";
                txtVCopies.Text = "";
                txtVPlot.Text = "";
                txtVGenre.Text = "";
                txtVId.Text = "";

                txtCId.Text = "";
                CName.Text = "";
                CContact.Text = "";
                CPlace.Text = "";

            }



        }
    }
}
