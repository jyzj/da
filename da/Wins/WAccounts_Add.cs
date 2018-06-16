using jiuyin.DataStructure;
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
        private WAccounts waccounts;                //账户管理窗口实例
        

        public WAccounts_Add(WAccounts waccounts)
        {
            InitializeComponent();
            this.waccounts = waccounts;
        }

        /**
         * 点击提交
         */
        private void bConfirm_Click(object sender, EventArgs e)
        {
            //获取参数
            //获取账户名
            string name = this.tbName.Text;
            if (name == null || name.Trim() == "")
            {
                MessageBox.Show("账户名不能为空", "警告", MessageBoxButtons.OK);
                return;
            }
            name = name.Trim();
            //获取密码
            string pwd = this.tbPwd.Text;
            if (pwd == null || pwd.Trim() == "")
            {
                MessageBox.Show("密码不能为空", "警告", MessageBoxButtons.OK);
                return;
            }
            pwd = pwd.Trim();
            //获取财产安全口令
            string safePwd = this.tbSafePwd.Text;
            if ( safePwd == null || safePwd.Trim() == "")
            {
                MessageBox.Show("财产安全口令不能为空", "警告", MessageBoxButtons.OK);
                return;
            }
            safePwd = safePwd.Trim();
            //获取密保卡序列号
            string pgId = this.tbPgId.Text;
            if (pgId == null || pgId.Trim() == "")
            {
                MessageBox.Show("密保卡序列号不能为空", "警告", MessageBoxButtons.OK);
                return;
            }
            pgId = pgId.Trim();
            //获取密保卡
            int[,] pgNums = new int[10, 7];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    char cY = (char)(y + 97);
                    string tb = "tbPgNums_" + cY + (x + 1);
                    if (this.Controls[tb].Text == null || this.Controls[tb].Text.Trim() == "")
                    {
                        MessageBox.Show("密保卡（" + cY + "," + (x + 1) + "）不能为空", "警告", MessageBoxButtons.OK);
                        return;
                    }
                    if(!int.TryParse(this.Controls[tb].Text.Trim(), out pgNums[x, y]))
                    {
                        MessageBox.Show("密保卡（" + cY + "," + (x + 1) + "）不是数字", "警告", MessageBoxButtons.OK);
                        return;
                    }
                    
                }
            }

            //获取真实姓名
            string realName = this.tbRealName.Text;
            if (realName == null || realName.Trim() == "")
            {
                MessageBox.Show("真实姓名不能为空", "警告", MessageBoxButtons.OK);
                return;
            }
            realName = realName.Trim();
            //获取身份证号
            string sfz = this.tbSfz.Text;
            if (sfz == null || sfz.Trim() == "")
            {
                MessageBox.Show("身份证不能为空", "警告", MessageBoxButtons.OK);
                return;
            }
            sfz = sfz.Trim();
            //获取手机号码
            string tel = this.tbTel.Text;
            if (tel == null || tel.Trim() == "")
            {
                MessageBox.Show("手机号码不能为空", "警告", MessageBoxButtons.OK);
                return;
            }
            tel = tel.Trim();
            //获取邮箱
            string email = this.tbEmail.Text;
            if (email == null || email.Trim() == "")
            {
                MessageBox.Show("邮箱不能为空", "警告", MessageBoxButtons.OK);
                return;
            }
            email = email.Trim();
            //获取安全问题
            string question = this.tbQuestion.Text;
            if (question == null || question.Trim() == "")
            {
                MessageBox.Show("安全问题不能为空", "警告", MessageBoxButtons.OK);
                return;
            }
            question = question.Trim();
            //获取问题答案
            string answer = this.tbAnswer.Text;
            if (answer == null || answer.Trim() == "")
            {
                MessageBox.Show("问题答案不能为空", "警告", MessageBoxButtons.OK);
                return;
            }
            answer = answer.Trim();

            //构造新账户
            Account account = new Account(name, pwd, safePwd, realName, sfz, tel, email, question, answer, pgId, pgNums);
            //传递参数
            this.waccounts.receiveNewAccount(account);

            //关闭窗口
            this.Close();
            this.Dispose();
        }
    }
}
