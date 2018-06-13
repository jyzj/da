using da.Wins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace da
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            init();                                                             //执行初始化

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new WMain());
            Application.Run(new WAccounts(null));
        }

        /**
         * 初始化
         */
        static void init()
        {
            //获取当前路径
            string curDir = System.Environment.CurrentDirectory;
            System.Console.WriteLine("当前程序路径" + curDir);
            //各种文件 & 文件夹 路径
            string confDir = curDir + "\\config";                               //config文件夹路径
            string accounts = confDir + "\\accounts.json";


            //检查如果配置文件夹不存在，则创建
            if (!Directory.Exists(confDir))
            {
                Directory.CreateDirectory(confDir);
                System.Console.WriteLine("conf文件夹创建成功（" + curDir + "）");
            }
            else
            {
                System.Console.WriteLine("conf文件夹存在（" + curDir + "）");

            }
        }
    }
}