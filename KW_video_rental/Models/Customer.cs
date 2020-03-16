using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KW_video_rental.Models
{
    public class Customer: Connection
    {
        //user define method to insert the record in the table of the customer record 
        public void Add(String Name, String Place,String Contact) {

            SqlQuery("insert into CustomerRecord (CName,CPlace,CContact) values('"+Name+"','"+Place+"','"+Contact+"')");
            MessageBox.Show("Customer is Registered ");
        }

        //user define method to Delete the record in the table of the customer record 
        public void Delete(int ID)
        {

            DataTable tbl = new DataTable();
            tbl = srchRecord("select * from RentRecord where CId="+ID+" and ReturnDate='Booked'");
            if (tbl.Rows.Count == 0)
            {
                SqlQuery("delete from  CustomerRecord  where ID=" + ID + "");
                MessageBox.Show("Customer is Deleted  ");
            }
            else {
                MessageBox.Show("You already have a video on rent ");
            }
        }

        //user define method to Update the record in the table of the customer record 
        public void Update(int id, String Name, String Place, String Contact)
        {
            SqlQuery("update CustomerRecord set CName='" + Name + "',CPlace='" + Place + "',CContact='" + Contact + "' where ID=" + id + "");
            MessageBox.Show("Customer Details are Updated  ");
        }






    }
}
