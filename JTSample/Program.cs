using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moraware.JobTrackerAPI5;

namespace JTSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // var DB = "yourdatabasename";
            var JTURL = "https://" + DB + ".moraware.net/";
            // var UID = "your username";
            // var PWD = "your password";

            Connection conn = new Connection(JTURL + "api.aspx", UID, PWD);
            conn.Connect();

            int jobid = 456; // a random job in my system - yours will be different

            var job = conn.GetJob(jobid);
            Console.WriteLine("Job {0} is {1}", job.JobName, job.JobStatus);

            conn.Disconnect();
        }
    }
}
