using System;
using Adapter.Adapter;
using Adapter.Classes;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            VgaGraphicsCard vgaGraphicsCard = new VgaGraphicsCard();
            DviMonitor dviMonitor = new DviMonitor();
            VgaGraphicsCardAdapter vgaGraphicsCardAdapter = new VgaGraphicsCardAdapter(vgaGraphicsCard);
            dviMonitor.SetInput(vgaGraphicsCardAdapter.GetDviStream());

            Console.ReadLine();

        }
    }
}
