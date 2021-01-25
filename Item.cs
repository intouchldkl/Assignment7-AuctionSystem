using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7_AuctionSystem
{
    class Item
    {
        private string description;
        private double reservePrice;
        private double highestBid;
        private int bidderIDNumber;


         public Item(string description,double reservePrice)
        {
            this.description = description;
            this.reservePrice = reservePrice;
            highestBid = 0;
        }

        public string getDescription()
        {
            return description;
        }
        public double getReservePrice()
        {
            return reservePrice;
        }
        public double getHighestBid()
        {
            return highestBid;
        }
        public int getBidderId()
        {
            return bidderIDNumber;
        }

        public bool setHighestBid(double newBid)
        {
            if (newBid > highestBid)
            {
                highestBid = newBid;
                return true;
            }
            else
            {
                return false;
            }


        }

        public void setBidderID(int newID)
        {
            bidderIDNumber = newID;
        }

        public string GetInfo()
        {
            return description + " " + highestBid + " " + reservePrice;
        }

        

    }
}
