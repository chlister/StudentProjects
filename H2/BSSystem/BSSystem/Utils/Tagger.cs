using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSSystem.Utils
{
    public static class Tagger
    {
        private static int tagSize = 12;
        private static int iteration = 1;
        public static int Iteration
        {
            get { return iteration; }
            private set { iteration = value; }
        }
        #region Methods
        public static string GenTag()
        { 
            string tag = "";
            tag += "l0ca1";
            string tempTag = tag;
            int forSize = tagSize - (tag.Length + Iteration.ToString().Length) - 1; 
            // insert 0's to fill tag to tagsize
            for (int i = 0; i < forSize; i++)
            {
                tempTag += "0";
            }
            tempTag += Iteration;
            tag = tempTag;
            // Make sure the next tag has another number
            Iteration++;
            return tag;
        }
        #endregion
    }
}
