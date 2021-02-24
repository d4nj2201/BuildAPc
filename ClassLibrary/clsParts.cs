using System;

namespace ClassLibrary
{
    public class clsParts
    {
        private int        mPartId;
        private string     mPartDescription;
        private string     mPartType;
        private DateTime   mDateAdded;
        private double     mPrice;
        private int        mWattage;
        private bool       mAvailable;

        public int PartId
        {
            get
            {
                return mPartId;
            }
            set
            {
                mPartId = value;
            }
        }

        public string PartDescription
        {
            get
            {
                return mPartDescription;
            }
            set
            {
                mPartDescription = value;
            }
        }

        public string PartType
        {
            get
            {
                return mPartType;
            }
            set
            {
                mPartType = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public int Wattage
        {
            get
            {
                return mWattage;
            }
            set
            {
                mWattage = value;
            }
        }

        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }

        public bool Find(int partId)
        {
            //set private data member
            mPartId = 21;
            mPartDescription  = "test description";
            mPartType         = "testing";
            mDateAdded        = Convert.ToDateTime("01/01/2001");
            mPrice            = 2.5;
            mWattage          = 50;
            mAvailable        = true;
            //return true
            return true;
        }
    }
}