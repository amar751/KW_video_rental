using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KW_video_rental.Models
{
  public  class Rental:Connection
    {

        //user define method to insert the rec,ord in the table of the Rental record 
        public void Add(int CId, int VId, String Issue)
        {

            DataTable tbl = new DataTable();
            // count the customer 
            tbl = srchRecord("select * from RentRecord where CId="+CId+" and ReturnDate='Booked'");
            if (tbl.Rows.Count < 3)
            {
                DataTable tbl1 = new DataTable();

                tbl1 = srchRecord("select * from RentRecord where VId=" + VId + " and ReturnDate='Booked'");



                DataTable tbl2 = new DataTable();
                tbl2 = srchRecord("select * from VideoRecord where ID="+VId+"");

                if (Convert.ToInt32(tbl2.Rows[0]["VCopies"].ToString()) >= tbl1.Rows.Count)
                {
                    SqlQuery("insert into RentRecord (CId,VId,IssueDate,ReturnDate) values(" + CId + "," + VId + ",'" + Issue + "','Booked')");
                    MessageBox.Show("Video is given at rent ");
                }
                else {
                    MessageBox.Show("All the Video is on Rent ");
                }

            }
            else {
                MessageBox.Show("You already have 2 video on rent ");
            }
        }

        //user define method to Delete the record in the table of the Rental record 
        public void Delete(int ID)
        {
            SqlQuery("delete from  RentRecord  where ID=" + ID + "");
            MessageBox.Show("Rental Video  is Deleted  ");
        }

        //user define method to Update the record in the table of the Rental record 
        public void Update(int id, int CId, int VId, String Issue,String RetDate)
        {
            DataTable tbl = new DataTable();
            tbl = srchRecord("select * from VideoRecord where ID=" + VId + "");

            DateTime new_date = DateTime.Now;

            //convert the old date from string to Date fromat
            DateTime prev_date = Convert.ToDateTime(Issue);


            //get the difference in the days fromat
            String Daysdiff = (new_date - prev_date).TotalDays.ToString();


            // calculate the round off value 
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));



            int Price = Convert.ToInt32(DaysInterval) * Convert.ToInt32(tbl.Rows[0]["VCost"]);



            SqlQuery("update RentRecord set CId=" + CId + ",VId=" + VId + ",IssueDate='" + Issue + "',ReturnDate='"+RetDate+"' where ID=" + id + "");
            MessageBox.Show("Rental Video is returned and your charges are $"+Price);
        }


    }
}
