using System;
using Adapter.Classes;

namespace Adapter.Adapter
{
    public class VgaGraphicsCardAdapter
    {
        private VgaGraphicsCard _vgaGraphicsCard;
        public VgaGraphicsCardAdapter(VgaGraphicsCard vgaGraphicsCard)
        {
            _vgaGraphicsCard = vgaGraphicsCard;
        }

        public DviStream GetDviStream()
        {
            byte[] data = _vgaGraphicsCard.GetVgaStream().GetData();
            //process and convert the vga video into the dvi video data
            byte[] dviVideoData = ConvertFromVgaToDvi(data);
            DviStream dviStream = new DviStream();
            dviStream.SetData(dviVideoData);
            return dviStream;
        }
        private byte[] ConvertFromVgaToDvi(byte[] input)
        {
            Console.WriteLine("Converted VGA VIdeo to DVI video");
            return new byte[] { };
        }
    }
}
