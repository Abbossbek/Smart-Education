using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartEducation
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        public AccountForm(DataGridViewRow AbitRow)
        {
            InitializeComponent();
            for (int i = 1; i < 4; i++)
                lblAbit.Text += AbitRow.Cells[i].Value.ToString()+" ";
        }
      
    }
}
