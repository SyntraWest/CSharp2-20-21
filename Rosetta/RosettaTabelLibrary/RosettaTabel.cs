using System;
using System.Collections.Generic;
using System.Text;

namespace RosettaTabelLibrary
{
    public class RosettaTabel
    {
        private List<string> talen;

        public RosettaTabel()
        {
            Talen = new List<string>();
        }

        public List<string> Talen
        {
            get
            {
                return talen;
            }
            private set
            {
                talen = value;
            }
        }
    }
}
