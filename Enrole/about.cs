using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrole
{
    public partial class about : Form
    {
        public String strVersionApp = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public about()
        {
            InitializeComponent();

            this.version.Text = strVersionApp;
        }
    }
}
