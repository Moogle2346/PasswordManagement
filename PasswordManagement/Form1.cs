using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagement
{
    public partial class Form1 : Form
    {
        ItemsModel ItemsMdl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string loadData;
            FileManagement fileManagement = new FileManagement();
            loadData = fileManagement.LoadFile(@"test.xml");

            ItemsMdl = ItemsModel.ConvertXMLToInstance(new System.IO.StringReader(loadData));
        }
    }
}
