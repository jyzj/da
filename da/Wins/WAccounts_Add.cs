using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace da.Wins
{
    public partial class WAccounts_Add : Form
    {
        public WAccounts_Add()
        {
            InitializeComponent();
        }

        /**
         * 点击提交
         */
        private void bConfirm_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();
            this.Dispose();
        }
    }
}
