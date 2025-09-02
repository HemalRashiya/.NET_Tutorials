using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorialSix
{
    public partial class Popup : Form
    {
        public string InputText { get;private set; }
        public Popup()
        {
            InitializeComponent();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            InputText = addtext.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
