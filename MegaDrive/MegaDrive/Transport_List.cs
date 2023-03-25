using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDrive
{
    public partial class Transport_List : Form
    {
        public Transport_List()
        {
            InitializeComponent();
        }

        private void Transport_List_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.transport". При необходимости она может быть перемещена или удалена.
            this.transportTableAdapter2.Fill(this.dataSet2.transport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.transport". При необходимости она может быть перемещена или удалена.
            //this.transportTableAdapter1.Fill(this.dataSet1.transport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_transport.transport". При необходимости она может быть перемещена или удалена.
            //this.transportTableAdapter.Fill(this.dataSet_transport.transport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.transport2". При необходимости она может быть перемещена или удалена.
            //this.transport2TableAdapter.Fill(this.dataSet.transport2);
            labelDateMake.Text = "";
            labelPrice.Text = "";
            labelColor.Text = "";
            labelPlace.Text = "";
            //GridViewTransport.Font = labelDateMake2.Font;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new TransportAdd().Show();
            Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            new FormAuthorization().Show();
            Hide();
        }
    }
}
