using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogScript
{
    class Splitter
    {
        public List<string> iplist = new List<string>();
        
        public Splitter()
        {

        }
        public void runProgram(string program)
        {
            string[] logs = program.Split('\n');


            foreach (string line in logs)
            {
                if (line.Contains("phpmyadmin"))
                {
                    string[] logline = line.Split(' ');
                    string ipaddress = logline[0];
                    this.iplist.Add(ipaddress);
                } else if (line.Contains("shaadmin"))
                {
                    string[] logline = line.Split(' ');
                    string ipaddress = logline[0];
                    this.iplist.Add(ipaddress);
                } else if (line.Contains("pma-old"))
                {
                    string[] logline = line.Split(' ');
                    string ipaddress = logline[0];
                    this.iplist.Add(ipaddress);
                }
            }
        }
    }
}
// C:\Users\Lucy\Downloads\logs\15-11-2020.log
