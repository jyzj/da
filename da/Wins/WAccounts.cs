using jiuyin.DataStructure;
using System;
using System.Collections;                               // 导入ArrayList的命名空间
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
        private ArrayList accounts;                     //账户数据

        /**
         * 构造方法
         * @dsAccounts                                  //传递过来的账户数据
         */
        public WAccounts(ArrayList accounts)
        {
            //尝试接收传递过来的账户数据
            if (accounts != null)
            {
                this.accounts = (ArrayList) accounts.Clone();
            }else
            {
                this.accounts = new ArrayList();
                int[,] aa = new int[1, 1];
                aa[0, 0] = 1;

                Account a = new Account("", "", "", "", "", "", "", "", "", "", aa);
                this.accounts.Add(a);
            }

            
            //初始化界面
            InitializeComponent();
        }


        /**
         * 显示行号
         */
        private void tRowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //显示在HeaderCell上
            for (int i = 0; i < this.Table.Rows.Count; i++)
            {
                DataGridViewRow r = this.Table.Rows[i];
                r.HeaderCell.Value = string.Format("{0}", i + 1);
            }
            this.Table.Refresh();
        }

    }
}
