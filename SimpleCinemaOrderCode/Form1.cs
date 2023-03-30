using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Cinema_Order_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int TotalPrice = 0;
        int AllTotalPrice = 0;
        int corn, water, tea, ticket;

        private void HesaplaBtn_Click(object sender, EventArgs e)
        {

            corn = Convert.ToInt16(CornTbx.Text == null || CornTbx.Text == "" ? "0" : CornTbx.Text);
            water = Convert.ToInt16(WaterTbx.Text == null || WaterTbx.Text == "" ? "0" : WaterTbx.Text);
            tea = Convert.ToInt16(TeaTbx.Text == null || TeaTbx.Text == "" ? "0" : TeaTbx.Text);
            ticket = Convert.ToInt16(TicketTbx.Text == null || TicketTbx.Text == "" ? "0" : TicketTbx.Text);

            TotalPrice = corn * 4 + water * 1 + tea * 2 + ticket * 8;
            AllTotalPrice += TotalPrice;

            TotalPriceLbl.Text = TotalPrice.ToString() + " $";
            AllTotalPriceLbl.Text = AllTotalPrice.ToString() + " $";

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Variable
            string MessageBoxTitle = "Delete";
            string MessageBoxContent = "The data will be deleted. Are you sure? ";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                corn = 0;
                water = 0;
                tea = 0;
                ticket = 0;
                TotalPrice = 0;
                AllTotalPrice = 0;
                CornTbx.Text = "";
                WaterTbx.Text = "";
                TeaTbx.Text = "";
                TicketTbx.Text = "";
                TotalPriceLbl.Text = "0,0 TL";
                AllTotalPriceLbl.Text = "0,0 TL";

                CornTbx.Focus();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}

