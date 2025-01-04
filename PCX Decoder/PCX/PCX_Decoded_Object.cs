using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCX_Decoder
{
    class PCX_Decoded_Object
    {
        private PCX_Header Header;
        private byte[] Decomprossed;
        private Bitmap Result;
        public PCX_Decoded_Object(PCX_Header Header, byte[] Decomprossed)
        {
            this.Header = Header;
            this.Decomprossed = Decomprossed;
        }
        public PCX_Header Get_Header()
        {
            return Header;
        }
        public byte[] Get_Decomprossed_Data()
        {
            return Decomprossed;
        }
        public void Set_Result(Bitmap Result)
        {
            this.Result = Result;
        }
        public Bitmap Get_Result()
        {
            return Result;
        }
    }
}