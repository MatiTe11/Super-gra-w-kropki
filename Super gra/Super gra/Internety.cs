using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Sockets;

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





        public void PierwszyRaz()
        {
            client = new TcpClient(serverIP, 25444);
            stream = client.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);

            streamWriter.WriteLine("0");
            streamWriter.Flush();
            nrGracza = streamReader.ReadLine();
            
        }


        public void Nadajnik(Gracz graczObecny)
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
                
            }
            catch (Exception e)
            {
                
            }

        }

        public void Odbiornik(Gracz graczRecived)
        {

            try
            {
                client = new TcpClient(serverIP, 25444);
                stream = client.GetStream();
                streamReader = new StreamReader(stream);
                streamWriter = new StreamWriter(stream);
                streamWriter.AutoFlush = true;


                messageodb = streamReader.ReadLine();
                string[] podzielone = messageodb.Split('/');
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
