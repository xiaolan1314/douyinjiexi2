using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace douyinjiexi
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {


            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
            Process instance = RunningInstance();
            if (instance != null) //进程中已经有一个实例在运行
            {
                HandleRunningInstance(instance);
            }
            else //没有实例在运行
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());                       //***主窗体的Form名称**//
            }
        }


        #region 在进程中查找是否已经有实例在运行
        //确保程序只运行一个实例
        public static Process RunningInstance()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] Processes = Process.GetProcessesByName(currentProcess.ProcessName);
            //遍历与当前进程名称相同的进程列表
            foreach (Process process in Processes)
            {
                //如果实例已经存在,则忽略当前进程
                if (process.Id != currentProcess.Id)
                {
                    //保证要打开的进程 同 已经存在的进程来自同一个文件路径
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == currentProcess.MainModule.FileName)
                    {
                        //返回另一个进程实例
                        return process;
                    }
                }
            }
            return null; //找不到其他进程实例，返回nulL。         
        }
        #endregion


        #region 调用Win32API,进程中已经有一个实例在运行,激活其窗口并显示在最前端
        private static void HandleRunningInstance(Process instance)
        {
            MessageBox.Show("软件已经在运行!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }
        #endregion
    }
}