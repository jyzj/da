using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jiuyin.DataStructure
{
    class Conf
    {
        private int maxOANum = 2;                       //最高同时操作账号数量
        


        /*** 最高同时操作账号数量 ***/
        public void setMaxOANum(int maxOANum)
        {
            this.maxOANum = maxOANum;
        }
        public int getMaxOANum()
        {
            return this.maxOANum;
        }
    }
}
