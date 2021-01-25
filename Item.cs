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
        private bool isSelling;


         public Item(string description,double reservePrice)
        {
            this.description = description;
            this.reservePrice = reservePrice;
            highestBid = 0;
            this.isSelling = true;
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
        public int getHighestBidderId()
        {
            return bidderIDNumber;
        }
        public bool getStatus()
        {
            return isSelling;
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

        public void setHighestBidderID(int newID)
        {
            bidderIDNumber = newID;
        }

        public string GetInfo()
        {
            return description + " " + highestBid + " " + reservePrice;
        }

        public void endAuction()
        {
            if (highestBid >= reservePrice)
            {
                isSelling = false;
            }
            else
            {
                Console.WriteLine(description + " can't be sold at this price");
            }
        }

    }
}
