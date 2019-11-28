using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalhoo
{
    public partial class filtro : Form
    {
        public DateTime? data = null;
        public filtro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = dateTimePicker1.Value;
            this.Close();
        }
    }
}
