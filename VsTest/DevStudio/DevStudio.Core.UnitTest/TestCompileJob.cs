using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace DevStudio.Core.UnitTest
{
    [TestClass]
    public class TestCompileJob
    {
        [TestMethod]
        public void TestRestore()
        {
            string args = $@"restore Compiler.csproj";
            Process restoreProcess = new Process
            {
                StartInfo = new ProcessStartInfo("dotnet", args)
            };
            restoreProcess.Start();
            restoreProcess.WaitForExit();Assert.AreEqual(0, restoreProcess.ExitCode);
        }
    }
}
