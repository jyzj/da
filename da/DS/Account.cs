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
        public string getName()
        {
            return this.name;
        }
        public string getPwd()
        {
            return this.pwd;
        }                         
        public string getSafePwd()
        {
            return this.safePwd;
        }

        /*** 角色名 ***/
        public void setCharacterName(string characterName)
        {
            this.characterName = characterName;
        }
        public string getCharacterName()
        {
            return this.characterName;
        }

        /*** 获取密保卡的方法 ***/
        public string getPgId()
        {
            return this.pgId;
        }
        public int getPgNum(int x, int y)
        {
            try
            {
                return this.pgNums[x, y];
            }
            catch (IndexOutOfRangeException)
            {
                //数组越界返回-1
                return -1;
            }
        }

        /*** 获取账号保护信息的方法 ***/
        public string getRealName()
        {
            return this.realName;
        }
        public string getSfz()
        {
            return this.sfz;
        }                         
        public string getTel()
        {
            return this.tel;
        }                         
        public string getEmail()
        {
            return this.email;
        }                      
        public string getQuestion()
        {
            return this.question;
        }                    
        public string getAnswer()
        {
            return this.answer;
        }                                            
    }
}
