using Newtonsoft.Json;                                  //json转化
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
            //初始化界面
            InitializeComponent();
            //初始化账户数组
            accounts = new ArrayList();
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

        /**
        * 添加新账户
        */
        private void btnNew_Click(object sender, EventArgs e)
        {
            //打开新建账号窗口（模态窗口）
            WAccounts_Add waa = new WAccounts_Add(this);
            waa.ShowDialog(this);
        }
        /**
         * 收到新账户
         * @account 新账户
         */
        public void receiveNewAccount(Account account)
        {
            //string jsonstr = JsonConvert.SerializeObject(account);
            //Console.WriteLine("接收到的账户");
            //Console.Write(jsonstr);
        }
    }
}
