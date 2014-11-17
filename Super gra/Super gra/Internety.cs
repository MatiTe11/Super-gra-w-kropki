using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace Super_gra
{
    class Internety
    {
        string nrGracza;
        string messageodb;
        string serverIP = "25.215.124.254";
        TcpClient client;
        StreamReader streamReader;
        StreamWriter streamWriter;
        Stream stream;
        private static readonly Socket clientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);





        public void PierwszyRaz()
        {
            while (!clientSocket.Connected)
            { clientSocket.Connect(IPAddress.Loopback, 25444); }
            //client = new TcpClient(serverIP, 25444);
            //stream = client.GetStream();
            //streamReader = new StreamReader(stream);
            //streamWriter = new StreamWriter(stream);

            //streamWriter.WriteLine("0");
            //streamWriter.Flush();
            //nrGracza = streamReader.ReadLine();
            
        }


        public void Nadajnik(Gracz graczObecny)
        {
            try
            {
                //client = new TcpClient(serverIP, 25444);
                //stream = client.GetStream();
                //streamReader = new StreamReader(stream);
                //streamWriter = new StreamWriter(stream);
                //streamWriter.AutoFlush = true;

                string message = nrGracza + "/" + graczObecny.pozycjaGracza.X + "/" + graczObecny.pozycjaGracza.Y;
                byte[] buffer = Encoding.ASCII.GetBytes(message);
                clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                //streamWriter.WriteLine(message);
                
            }
            catch (Exception e)
            {
                
            }

        }

        public void Odbiornik(Gracz graczRecived)
        {

            try
            {
                //client = new TcpClient(serverIP, 25444);
                //stream = client.GetStream();
                //streamReader = new StreamReader(stream);
                //streamWriter = new StreamWriter(stream);
                //streamWriter.AutoFlush = true;


                //messageodb = streamReader.ReadLine();
                var buffer = new byte[2048];
                int received = clientSocket.Receive(buffer, SocketFlags.None);
                if (received == 0) return;
                var data = new byte[received];
                Array.Copy(buffer, data, received);
                string text = Encoding.ASCII.GetString(data);

                string[] podzielone = text.Split('/');
                graczRecived.pozycjaGracza.X = float.Parse(podzielone[0]);
                graczRecived.pozycjaGracza.Y = float.Parse(podzielone[1]);
            }
            catch {  }


        }



        public void Update(Gracz graczObecny, Gracz graczRecived)
        {
            try
            {
                client = new TcpClient(serverIP, 25444);
                stream = client.GetStream();
                streamReader = new StreamReader(stream);
                streamWriter = new StreamWriter(stream);
                streamWriter.AutoFlush = true;

                string message = nrGracza + "/" + graczObecny.pozycjaGracza.X + "/" + graczObecny.pozycjaGracza.Y;
                streamWriter.WriteLine(message);
                //odb
                if(streamReader.ReadLine() != null)
                    messageodb = streamReader.ReadLine();
                string[] podzielone = messageodb.Split('/');
                graczRecived.pozycjaGracza.X = float.Parse(podzielone[0]);
                graczRecived.pozycjaGracza.Y = float.Parse(podzielone[1]);
                //streamWriter.WriteLine("69");


            }
            catch (Exception e)
            {

            }

        }
    }
}
