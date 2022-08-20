// Pinger
using System.Net.NetworkInformation;
using System.Text;

string dataToSend = "Ping form Florin";
byte[] buffer = Encoding.ASCII.GetBytes(dataToSend);
int timeout = 120;
// Google's ip
string serverAddress = "4.2.2.2"; 

Ping pingSender = new Ping();
PingOptions options = new PingOptions();

options.DontFragment = true;

PingReply reply = pingSender.Send(serverAddress, timeout, buffer, options);

if (reply.Status == IPStatus.Success)
{
    Console.WriteLine("Response: {0}", reply.Status.ToString());
    Console.WriteLine("RoundTrip: {0} ms.", reply.RoundtripTime);
    Console.WriteLine("Time to live {0}", reply.Options.Ttl);
} else
{
    Console.WriteLine("Something went wrong.");
}