using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinSCP;

namespace ConexionSID
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WinSCP.SessionOptions sessionOptions = new WinSCP.SessionOptions();
                sessionOptions.Protocol = Protocol.Sftp;
                //sessionOptions.HostName = "sid1.crtm.es";
                sessionOptions.HostName = "82.194.72.125";
                sessionOptions.UserName = "root";
                sessionOptions.Password = "Qwe123456*!";
                sessionOptions.PortNumber = 27;
                //sessionOptions.s
                //sessionOptions.SshPrivateKeyPath = @"C:\ClavesSid\private.ppk";
                //sessionOptions.SshPrivateKeyPassphrase = "&20101028-Prointec";
                sessionOptions.SshHostKeyFingerprint = "ssh-rsa 2048 14:98:1e:8b:ce:a8:74:dd:cb:61:62:26:3c:8c:84:07";
                

                Session s = new Session();
                try
                {
                    s.ExecutablePath = @"C:\Program Files (x86)\WinSCP\WinSCP.exe";
                    //Connect
                    s.Open(sessionOptions);
                    Console.WriteLine("Conectado");
                    Console.ReadLine();

                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.ToString());
                    Console.ReadLine();
                }
                finally
                {
                    // Disconnect, clean up
                    s.Dispose();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
