using System;

namespace Assignment7_AuctionSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] items = new Item[5];
            items[0] = new Item("Faberge", 10000000);
            items[1] = new Item("Rolex Submarine", 300000);
            items[2] = new Item("Louis XII whiskey", 80000);
            items[3] = new Item("Intouch's wine glass", 99000);
            items[4] = new Item("Mr.H's security software", 1000);
        }

           static void printAllItems(Item[] items)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] != null)
                    {
                        Console.WriteLine(items[i].GetInfo());
                    }
                }
            }
        static void BidOnItem(int itemNumber,double bid,int bidderIDNumber,Item[] items)
        {
            if(bid > items[itemNumber].getHighestBid)
        }

            

    }
}
