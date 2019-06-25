using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Aika_Game_Server
{

    public class ServerConfig
    {
        public string Ip { get; set; }
        public int Port { get; set; }
        public int Version { get; set; }
        public int Max_Players { get; set; }
    }

    public class ServerSocket
    {
        public static GlobalData Global = new GlobalData();
        public static Load TLoad = new Load();
        public static ServerConfig SC = new ServerConfig();

        public TcpListener _client;
        public NetworkStream _stream;
        public Thread _thread;

        public static string JsonConfigText;

        public static void Run()
        {
            Global.ServerDir = Directory.GetCurrentDirectory();
            Global.ServerDataDir = String.Join(' ', Global.ServerDir, "\\Data\\");

            Console.Title = Global.ServerDataDir;

            JsonConfigText = TLoad.InitServerConfig();

            var ServerFileConf = JsonConvert.DeserializeObject<ServerConfig>(JsonConfigText);

            SC.Ip = ServerFileConf.Ip;
            SC.Port = ServerFileConf.Port;
            SC.Version = ServerFileConf.Version;
            SC.Max_Players = ServerFileConf.Max_Players;

            Console.WriteLine(SC.Ip);

            Console.ReadLine();

        }

    }
}
