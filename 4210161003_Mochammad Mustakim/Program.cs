using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Encapsulation
{
    [Serializable]
    public struct playerAtt
    {
        public int idPlayer;
        public int[] coorPlayer;
        public int kill;
        public int killed;
        public int assist;
        public float healthPlayer;
        public int shoot;
        public int idTarget;
        public int bomb;
        public string notification;

        public playerAtt(int id, int x, int y, int k, int kd, int ast, float hp, int tembak, int target, int bom, string notif)
        {
            this.idPlayer = id;
            coorPlayer = new int[2];
            coorPlayer[0] = x;
            coorPlayer[1] = y;
            this.kill = k;
            this.killed = kd;
            this.assist = ast;
            healthPlayer = hp;
            this.shoot = tembak;
            this.idTarget = target;
            this.bomb = bom;
            notification = notif;
        }
    }   

    public static class StructToByte
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient();
            client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
            Console.Write(">");
            string inputs = Console.ReadLine();
            if (inputs != null)
            {
                byte[] bytesent = Encoding.ASCII.GetBytes(inputs);
                client.Send(bytesent, bytesent.Length);
                Console.WriteLine("berhasil mengirimkan pesan");

                client.Close();
                Console.ReadLine();
            }
        }
    }
}
