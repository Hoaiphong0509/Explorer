using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer
{
    public partial class CreateFile : Form
    {
        private string nameFile;
        public CreateFile()
        {
            InitializeComponent();
        }
        public string NameFile
        {
            get { return nameFile; }
            set { nameFile = value; }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            nameFile = "";
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nameFile = txtNameFile.Text;
            this.Close();
        }

        private void CreateFile_Load(object sender, EventArgs e)
        {
            txtNameFile.Text = nameFile;
        }
    }
}
