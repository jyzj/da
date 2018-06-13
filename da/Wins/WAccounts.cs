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
    public partial class WAccounts : Form
    {
        private DataSet dsAccounts;                     //账户数据

        /**
         * 构造方法
         * @dsAccounts                                  //传递过来的账户数据
         */
        public WAccounts(DataSet dsAccounts)
        {
            //接受传递过来的账户数据
            if (dsAccounts != null)
            {
                this.dsAccounts = dsAccounts;
            }else
            {
                dsAccounts = new DataSet();
            }

            
            //初始化界面
            InitializeComponent();

            //绑定数据源
            this.Table.DataSource = this.dsAccounts;
        }


    }
}
