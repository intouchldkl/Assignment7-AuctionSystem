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
           
            

            printAllItems(items);
            BidOnItem(3, 100000, 7, items);
            BidOnItem(0, 20000000, 5, items);
            BidOnItem(1, 400000, 2, items);
            BidOnItem(2, 80000, 7, items);
            BidOnItem(3, 120000, 8, items);
            BidOnItem(4, 200, 1, items);

            items[0].endAuction();
            items[1].endAuction();
            items[2].endAuction();
            items[3].endAuction();
            items[4].endAuction();

            getAllItemsSold(items);



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
            if(bid > items[itemNumber].getHighestBid())
            {
                items[itemNumber].setHighestBid(bid);
                items[itemNumber].setHighestBidderID(bidderIDNumber);



            }
            else
            {
                Console.WriteLine("Please bid more money!");
            }
        }
        static void getAllItemsSold(Item[] items)

        {
            for (int i = 0;i < items.Length;i++)
            {
                if(items[i].getStatus() == false)
                {
                    Console.WriteLine(items[i].getDescription() + " " + items[i].getHighestBid() +
                        " " + items[i].getHighestBidderId());
                }
            }

        }
            

    }
}
