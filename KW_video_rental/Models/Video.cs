using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KW_video_rental.Models
{
   public class Video:Connection
    {
        //user define method to insert the record in the table of the Video record 
        public void Add(String Name,String Ratting,int Year,int Copies,String Plot,String Genre)
        {

            //dislay the cost of the price of the video after adding the year of the video
            DateTime dateNow = DateTime.Now;

            int Currentyear = dateNow.Year;

            int diffYear = Currentyear - Convert.ToInt32(Year.ToString());
            int Cost=0;

            // MessageBox.Show(diff.ToString());
            if (diffYear >= 5)
            {
                Cost = 2;
            }
            if (diffYear >= 0 && diffYear < 5)
            {
                Cost = 5;
            }

            SqlQuery("insert into VideoRecord(VName,VRatting,VYear,VCopies,VPlot,VGenre,VCost) values('" + Name + "','" + Ratting + "'," + Year + ","+Copies+",'"+Plot+"','"+Genre+"',"+Cost+")");
            MessageBox.Show("Video is Saved ");
        }

        //user define method to Delete the record in the table of the customer record 
        public void Delete(int ID)
        {
            DataTable tbl = new DataTable();
            tbl = srchRecord("select * from RentRecord where VId=" + ID + " and ReturnDate='Booked'");
            if (tbl.Rows.Count == 0)
            {

                SqlQuery("delete from  VideoRecord  where ID=" + ID + "");
                MessageBox.Show("Video is Deleted  ");
            }
            else
            {
                MessageBox.Show("This video is on rent ");

            }
        }

        //user define method to Update the record in the table of the customer record 
        public void Update(int id, String Name, String Ratting, int Year, int Copies, String Plot, String Genre)
        {


            //dislay the cost of the price of the video after adding the year of the video
            DateTime dateNow = DateTime.Now;

            int Currentyear = dateNow.Year;

            int diffYear = Currentyear - Convert.ToInt32(Year.ToString());
            int Cost = 0;

            // MessageBox.Show(diff.ToString());
            if (diffYear >= 5)
            {
                Cost = 2;
            }
            if (diffYear >= 0 && diffYear < 5)
            {
                Cost = 5;
            }


            SqlQuery("update VideoRecord set VName='" + Name + "',VRatting='" +Ratting + "',VYear=" + Year + ",VCopies="+Copies+",VPlot='"+Plot+"',VGenre='"+Genre+"',VCost="+Cost+" where ID=" + id + "");
            MessageBox.Show("Video Details are Updated  ");
        }



    }
}
