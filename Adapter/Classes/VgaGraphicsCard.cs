using System;
namespace Adapter.Classes
{
    public class VgaGraphicsCard
    {
        public VgaStream GetVgaStream()
        {
            VgaStream vgaStream = new VgaStream();
            vgaStream.SetData(new byte[] { });
            return vgaStream;
        }
    }


   
    public class VgaStream
    {
        private byte[] _stream;
        public void SetData(byte[] data)
        {
            _stream = data;
        }
        public byte[] GetData()
        {
            return _stream;
        }
    }

    public class DviMonitor
    {
        private byte[] _inputStream;
        public void SetInput(DviStream inputStream)
        {
            _inputStream = inputStream.GetData();
        }
    }


    public class DviStream
    {
        private byte[] _stream;
        public void SetData(byte[] data)
        {
            _stream = data;
        }
        public byte[] GetData()
        {
            return _stream;
        }
    }



}
