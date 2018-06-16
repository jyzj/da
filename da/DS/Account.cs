using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jiuyin.DataStructure
{
    public class Account
    {
        private string name;                        //账户名
        private string pwd;                         //账户密码
        private string safePwd;                     //财产安全口令

        private string characterName;               //角色名

        private string pgId;                        //密保卡id
        private int[,] pgNums;                      //密保数字 0<=x<10, 0<=y<7

        private string realName;                    //真实姓名
        private string sfz;                         //身份证
        private string tel;                         //手机号码
        private string email;                       //邮箱地址
        private string question;                    //安全问题
        private string answer;                      //问题答案

        /**
         * 构造方法
         */
        public Account()
        {
            this.pgNums = new int[10, 7];
        }
        /**
         * 构造方法
         * @name
         * @pwd
         * @safePwd
         * @realName
         * @sfz
         * @tel
         * @email
         * @question
         * @answer
         * @pgId
         * @pgNums
         */
         public Account(string name, string pwd, string safePwd, string realName, string sfz, string tel, string email, string question, string answer, string pgId, int[,]pgNums)
        {
            this.name = name;
            this.pwd = pwd;
            this.safePwd = safePwd;

            this.realName = realName;
            this.sfz = sfz;
            this.tel = tel;
            this.email = email;
            this.question = question;
            this.answer = answer;

            this.pgId = pgId;
            this.pgNums = new int[10, 7];
            //密保卡赋值，可能出现报错
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    this.pgNums[x, y] = pgNums[x, y];
                }
            }
        }


        /*** 获取账户信息的方法 ***/
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }                         
        public string SafePwd
        {
            get { return safePwd; }
            set { safePwd = value; }
        }

        /*** 角色名 ***/
        public string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        }

        /*** 获取密保卡的方法 ***/
        public string PgId
        {
            get { return pgId; }
            set { pgId = value; }
        }
        public int[,] PgNums
        {
            get { return pgNums; }
            set
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 7; y++)
                    {
                        pgNums[x, y] = value[x, y];
                    }
                }
            }
        }

        /*** 获取账号保护信息的方法 ***/
        public string RealName
        {
            get { return realName; }
            set { realName = value; }
        }
        public string Sfz
        {
            get { return sfz; }
            set { sfz = value; }
        }                         
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }                         
        public string Email
        {
            get { return email; }
            set { email = value; }
        }                      
        public string Question
        {
            get { return question; }
            set { question = value; }
        }                    
        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }                                            
    }
}
