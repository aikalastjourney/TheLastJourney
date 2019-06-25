using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aika_Game_Server
{
    public class Load
    {
        public string InitServerConfig()
        {
            string Path = ServerSocket.Global.ServerDataDir + "\\Config.json";

            var file = File.ReadAllText(Path);

            return file;           
        }

    }
}
