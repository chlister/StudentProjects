using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSSystem.Models
{
    public class Bagage
    {
        private string[] data;
        private string destination;
        private string bagTag;
        private int status;
        public string[] Data { get; set; }
        public int Status
        {
            get { return status; }
            set
            {
                Data[2] = value.ToString();
                status = value;
            }
        }

        public string Destination
        {
            get { return destination; }
            set
            {
                Data[1] = value;
                destination = value;
            }
        }
        public string BagTag
        {
            get { return bagTag; }
            set
            {
                Data[0] = value;
                bagTag = value;
            }
        }
        #region Constructor
        public Bagage(string _dest)
        {
            Data = new string[3];
            Destination = _dest;
        }
        #endregion
    }
}
