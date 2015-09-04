using System;
using System.Diagnostics;

namespace TruckSystem.Utils
{
    public class RunUtil
    {
        public static int Run(string file, string args, bool waitForExit)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.Arguments = args;
                processStartInfo.UseShellExecute = false;
                processStartInfo.FileName = file;
                Process process = new Process();
                process.StartInfo = processStartInfo;
                process.Start();
                if (process != null)
                {
                    if (waitForExit)
                        process.WaitForExit();
                }
                return process.ExitCode;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
