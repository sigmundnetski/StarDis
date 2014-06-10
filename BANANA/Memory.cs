namespace BANANA
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Text;

    internal class Memory
    {
        public static int NUJISHIRHOECKHOTHOYGEQ;
        public static long PYHKTUBUVKULYYDMTKRMRB;
        public static Process proc = null;
        public static IntPtr processHandle;

        public static void ECHLANPSCMFCZZHKLTKSIO(long PEGYHSMCUSDKTPFJRTXUNB, int MHAPGNTLYFBIAVZLFGNFA)
        {
            byte[] bytes = BitConverter.GetBytes(MHAPGNTLYFBIAVZLFGNFA);
            WriteProcessMemory(processHandle, (UIntPtr) PEGYHSMCUSDKTPFJRTXUNB, bytes, (UIntPtr) bytes.Length, IntPtr.Zero);
        }

        public static IntPtr FPDMLOTRRLWBZBIHJSPNFP(int VMGBTBNHLTJALQQZDAMEN, int YZJGMCQOMSYJDIHRWXTQF)
        {
            return (IntPtr) ((((short) YZJGMCQOMSYJDIHRWXTQF) << 0x10) | (VMGBTBNHLTJALQQZDAMEN & 0xffff));
        }

        public static float readFloat(long PEGYHSMCUSDKTPFJRTXUNB)
        {
            byte[] hJQWJBPWDNCJLPOQAUWCDD = new byte[4];
            ReadProcessMemory(processHandle, (UIntPtr) PEGYHSMCUSDKTPFJRTXUNB, hJQWJBPWDNCJLPOQAUWCDD, (UIntPtr) 4, IntPtr.Zero);
            return BitConverter.ToSingle(hJQWJBPWDNCJLPOQAUWCDD, 0);
        }

        public uint KQSHHXUDVWMAUINHPUGGGN(string ZFZYSKMCOFHHFRJMRZLYLG)
        {
            try
            {
                return (uint) this.RVATPAYXAOTRMGRFXAJSIR(ZFZYSKMCOFHHFRJMRZLYLG).BaseAddress.ToInt32();
            }
            catch
            {
                return 0;
            }
        }

        public static IntPtr readIntPtr(long PEGYHSMCUSDKTPFJRTXUNB)
        {
            byte[] hJQWJBPWDNCJLPOQAUWCDD = new byte[8];
            ReadProcessMemory(processHandle, (UIntPtr) PEGYHSMCUSDKTPFJRTXUNB, hJQWJBPWDNCJLPOQAUWCDD, (UIntPtr) 4, IntPtr.Zero);
            return (IntPtr) BitConverter.ToInt32(hJQWJBPWDNCJLPOQAUWCDD, 0);
        }

        public static uint readUInt32(long PEGYHSMCUSDKTPFJRTXUNB)
        {
            byte[] hJQWJBPWDNCJLPOQAUWCDD = new byte[4];
            ReadProcessMemory(processHandle, (UIntPtr) PEGYHSMCUSDKTPFJRTXUNB, hJQWJBPWDNCJLPOQAUWCDD, (UIntPtr) 4, IntPtr.Zero);
            return BitConverter.ToUInt32(hJQWJBPWDNCJLPOQAUWCDD, 0);
        }

        public static void NIECRRMSYVVGXWQWRVPPPY(long PEGYHSMCUSDKTPFJRTXUNB, float MHAPGNTLYFBIAVZLFGNFA)
        {
            byte[] bytes = BitConverter.GetBytes(MHAPGNTLYFBIAVZLFGNFA);
            WriteProcessMemory(processHandle, (UIntPtr) PEGYHSMCUSDKTPFJRTXUNB, bytes, (UIntPtr) bytes.Length, IntPtr.Zero);
        }

        public static string readString(long PEGYHSMCUSDKTPFJRTXUNB)
        {
            byte[] hJQWJBPWDNCJLPOQAUWCDD = new byte[60];
            ReadProcessMemory(processHandle, (UIntPtr) PEGYHSMCUSDKTPFJRTXUNB, hJQWJBPWDNCJLPOQAUWCDD, (UIntPtr) 60, IntPtr.Zero);
            string str = Encoding.Unicode.GetString(hJQWJBPWDNCJLPOQAUWCDD);
            if (str.IndexOf('\0') != -1)
            {
                str = str.Remove(str.IndexOf('\0'));
            }
            return str;
        }

        [DllImport("kernel64.dll")]
        private static extern IntPtr OpenProcess(uint ENIKXZNVPNKNZOVCOFNYFY, bool VZZLEIDOKILHJFNPPBCDUN, int GSSNCXTYDTHTOIRKGEGNTB);
        [DllImport("user32.dll", SetLastError=true)]
        public static extern bool PostMessage(IntPtr DMSIZKJOXVTPBMLWXABFQW, uint PIMRZGSTKYTBMZUIPJDWCI, int TAHKQSBMRZNJPIYVAIXTOZ, uint LSXXVOVJNPNYKCBJKUCKE);
        public static byte readByte(long PEGYHSMCUSDKTPFJRTXUNB)
        {
            byte[] buffer = new byte[1];
            ReadProcessMemory(processHandle, (UIntPtr) PEGYHSMCUSDKTPFJRTXUNB, buffer, (UIntPtr) 1, IntPtr.Zero);
            return buffer[0];
        }

        public static int readInt32(long PEGYHSMCUSDKTPFJRTXUNB)
        {
            byte[] hJQWJBPWDNCJLPOQAUWCDD = new byte[8];
            ReadProcessMemory(processHandle, (UIntPtr) PEGYHSMCUSDKTPFJRTXUNB, hJQWJBPWDNCJLPOQAUWCDD, (UIntPtr) 4, IntPtr.Zero);
            return BitConverter.ToInt32(hJQWJBPWDNCJLPOQAUWCDD, 0);
        }

        public static bool QYNUEAWVBSYTIBOIJPMZOG()
        {
            proc = Process.GetCurrentProcess();
            if (proc.Handle != IntPtr.Zero)
            {
                processHandle = proc.Handle;
                return true;
            }
            return false;
        }

        public static bool QYNUEAWVBSYTIBOIJPMZOG(int BEBUULFCUIBDSWAMOKEREV)
        {
            proc = Process.GetProcessById(BEBUULFCUIBDSWAMOKEREV);
            if (proc.Handle != IntPtr.Zero)
            {
                processHandle = proc.Handle;
                return true;
            }
            return false;
        }

        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(IntPtr VWOGRJBCXICJDZRLCOEIQK, UIntPtr BRFGVQQTUYHAMSADKFVWHV, [Out] byte[] HJQWJBPWDNCJLPOQAUWCDD, UIntPtr LANATMKINDZGOHDDGTFXIB, IntPtr FJEVJCWCDDCLTFAGBQMTE);
        private ProcessModule RVATPAYXAOTRMGRFXAJSIR(string ZFZYSKMCOFHHFRJMRZLYLG)
        {
            for (int i = 0; i < proc.Modules.Count; i++)
            {
                if (proc.Modules[i].ModuleName == ZFZYSKMCOFHHFRJMRZLYLG)
                {
                    return proc.Modules[i];
                }
            }
            return null;
        }

        public static void RWADSZEVBFOAPRDKBLGYFD(ulong PEGYHSMCUSDKTPFJRTXUNB, uint MHAPGNTLYFBIAVZLFGNFA)
        {
            byte[] bytes = BitConverter.GetBytes(MHAPGNTLYFBIAVZLFGNFA);
            WriteProcessMemory(processHandle, (UIntPtr) PEGYHSMCUSDKTPFJRTXUNB, bytes, (UIntPtr) bytes.Length, IntPtr.Zero);
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr DMSIZKJOXVTPBMLWXABFQW, uint PIMRZGSTKYTBMZUIPJDWCI, int TAHKQSBMRZNJPIYVAIXTOZ, uint LSXXVOVJNPNYKCBJKUCKE);
        public static ulong readUInt64(long PEGYHSMCUSDKTPFJRTXUNB)
        {
            byte[] hJQWJBPWDNCJLPOQAUWCDD = new byte[8];
            ReadProcessMemory(processHandle, (UIntPtr) PEGYHSMCUSDKTPFJRTXUNB, hJQWJBPWDNCJLPOQAUWCDD, (UIntPtr) 8, IntPtr.Zero);
            return BitConverter.ToUInt64(hJQWJBPWDNCJLPOQAUWCDD, 0);
        }

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(IntPtr VWOGRJBCXICJDZRLCOEIQK, UIntPtr BRFGVQQTUYHAMSADKFVWHV, byte[] HJQWJBPWDNCJLPOQAUWCDD, UIntPtr LANATMKINDZGOHDDGTFXIB, IntPtr IWWHTXWTHWJGXJFADOINFB);
    }
}

