using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ACTY1
{
    public partial class ListBoxExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Pilihan yang diinginkan : ";
            foreach (ListItem item in ListBox1.Items) {
                if (item.Selected == true)
                {
                    Label1.Text = Label1.Text + item.Text;
                }
            }
        }
    }
}