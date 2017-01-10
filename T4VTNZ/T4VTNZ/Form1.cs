using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T4VTNZ
{
    public partial class Form1 : Form
    {
        VTNZ vtnz;
        List<IService> servicelist;
        decimal price;
        string details;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vtnz = new VTNZ("VTNZ North Harbour", "3-5 Saturn Place, Albany", "Mon - Fri 7.30am - 5pm", "vtnz@massey.ac.nz");
            vtnz.AddList(new CarWrap("WoF Inspection", 50));
            vtnz.AddList(new CarWrap("Check-up", 200));
            vtnz.AddList(new CarWrap("Pre-purchase", 150));
            vtnz.AddList(new CarWrap("Vehicle Inspection", 210));
            lstInspection.DataSource = vtnz.ServiceList;
            lstInspection.DisplayMember = "ServiceDetails";
            lstInspection.SelectedIndex = -1;

            lblHeader.Text = vtnz.ShowStationDetails();
            lblSelect.Text = "Select a Service";
            lblServiceDetails.Text = "Service Details";
            lblTotalPrice.Text = "Total Price";
            lblRequested.Text = "Service Requested";
            lblDetails.Text = "";
            lblPrice.Text = "";
            lblCount.Text = "";

            servicelist = new List<IService>();
        }

        private void btnServiceRequest_Click(object sender, EventArgs e)
        {
            if (lstInspection.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Service First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                servicelist.Add((IService)lstInspection.SelectedItem);
                lblCount.Text = servicelist.Count.ToString();

                price = 0;
                details = "";
                foreach (IService s in servicelist)
                {
                    price += s.ServicePrice;
                    details += "Inspection Type " + Convert.ToString(s.ServiceTitle) + Environment.NewLine + " Price" + Convert.ToString(s.ServicePrice) + Environment.NewLine;
                }
                lblDetails.Text = details;
                lblPrice.Text = Convert.ToString(price);
            }
        }
    }
}
