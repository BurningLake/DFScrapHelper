using System;
using System.Linq;
using System.IO;
using HtmlAgilityPack;
using System.Collections.Generic;
using ScrapItems;

namespace scrap_helper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            HtmlDocument trades = new HtmlDocument();

            try
            {
                trades.LoadHtml(File.ReadAllText("archived_trade.txt"));
            }
            catch
            {
                Console.WriteLine("Please include the 'archived_trade' file in the main folder.");
                Console.WriteLine("Press Enter to Close Application.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            int serviceCharge = 0;

            while(true)
            {
                Console.Write("Enter Price Under Scrap per Item: ");
                bool check = int.TryParse(Console.ReadLine(), out serviceCharge);
                if (check)
                    break;
                Console.WriteLine("Insert Valid Number");
            }

                Console.Write("Enter Customer Name: ");
                string customerName = Console.ReadLine();

            // create list of items to search for and add an instance of each item to this list
            List<IItem> itemsToTest = new List<IItem>();

            // list of items to be shown on the receipt
            List<ReceiptItem> receipt = new List<ReceiptItem>();

            // strings to be added to the receipt txt file:
            List<string> receiptText = new List<string>();

            // adding the items to search for: 

            // Melee Weapons
            itemsToTest.Add(new BowieKnife());
            itemsToTest.Add(new Scalpel());
            itemsToTest.Add(new Shovel());
            itemsToTest.Add(new TrenchKnife());
            itemsToTest.Add(new RonanPro());
            itemsToTest.Add(new Machete());
            itemsToTest.Add(new WoodAxe());
            itemsToTest.Add(new Sabre());
            itemsToTest.Add(new SteelMS800());
            itemsToTest.Add(new Kukri());
            itemsToTest.Add(new SledgeHammer());
            itemsToTest.Add(new Katana());
            itemsToTest.Add(new BattleAxe());
            itemsToTest.Add(new Grinder());
            itemsToTest.Add(new Wakizashi());
            itemsToTest.Add(new Nodachi());
            itemsToTest.Add(new Steel090());
            itemsToTest.Add(new Spiker());
            itemsToTest.Add(new RipsawG12());
            itemsToTest.Add(new DualBlade());
            itemsToTest.Add(new GoreTooth44G());

            // Pistols
            itemsToTest.Add(new DesertFox());
            itemsToTest.Add(new SW500());
            itemsToTest.Add(new AlphaBull());
            itemsToTest.Add(new Magnum475());
            itemsToTest.Add(new Greyhawk());

            // Rifles
            itemsToTest.Add(new MSG9());
            itemsToTest.Add(new SIC550());
            itemsToTest.Add(new HawkOP96());
            itemsToTest.Add(new DragonSVD());
            itemsToTest.Add(new M82A2());
            itemsToTest.Add(new VSSVintorez());
            itemsToTest.Add(new Rex577());
            itemsToTest.Add(new Ironsight());

            // Shotguns
            itemsToTest.Add(new Sweeper());
            itemsToTest.Add(new USAN12());
            itemsToTest.Add(new AA12());
            itemsToTest.Add(new Painshot());

            // Machine Guns
            itemsToTest.Add(new XM8());
            itemsToTest.Add(new AK47());
            itemsToTest.Add(new K50M());
            itemsToTest.Add(new FMMitrail());
            itemsToTest.Add(new M4());
            itemsToTest.Add(new M60());
            itemsToTest.Add(new FMMAG());
            itemsToTest.Add(new CrissVictor());
            itemsToTest.Add(new Vulcan());
            itemsToTest.Add(new Uziel());
            itemsToTest.Add(new Hammerhead47());

            // Explosives
            itemsToTest.Add(new RG6());
            itemsToTest.Add(new FalconMM1());
            itemsToTest.Add(new XM25());
            itemsToTest.Add(new PAW20());

            // Armor
            itemsToTest.Add(new MeshRX2());
            itemsToTest.Add(new MeshSLX());
            itemsToTest.Add(new ReactiveSLX());
            itemsToTest.Add(new ReactiveXT800());
            itemsToTest.Add(new ExterminatorMesh());
            itemsToTest.Add(new ExterminatorMeshGT());
            itemsToTest.Add(new ExterminatorReactive());
            itemsToTest.Add(new ExterminatorReactiveXT());

            // Other Stuff
            itemsToTest.Add(new Nero5A());
            itemsToTest.Add(new Blueprint());
            itemsToTest.Add(new Implants());
            itemsToTest.Add(new CrashHelmet());
            itemsToTest.Add(new ExterminatorHelmet());
            itemsToTest.Add(new TrenchCoat());
            itemsToTest.Add(new MotorcycleJacket());
            itemsToTest.Add(new CowboyHat());
            itemsToTest.Add(new BaseballHelmet());
            itemsToTest.Add(new FlyingGoggles());
            itemsToTest.Add(new SurgicalHat());
            itemsToTest.Add(new Sunglasses());
            itemsToTest.Add(new Bandana());
            itemsToTest.Add(new BioHelmet());
            itemsToTest.Add(new SkiMask());

            // search for items
            foreach(IItem item in itemsToTest)
            {
                // gets the number of occurrences of items
                List<HtmlNode> getOccurences = trades.DocumentNode.Descendants().Where
                                        (x => (x.Name == "div" && x.Attributes["data-type"] != null &&
                                        x.Attributes["data-type"].Value.Contains(item.getName()))).ToList();
                                    
                if (getOccurences.Count != 0)
                {
                    List<HtmlNode> getStats = getOccurences.Where
                                        (x => (x.Name == "div" && x.Attributes["data-type"] != null &&
                                        x.Attributes["data-type"].Value.Contains("stats"))).ToList();

                    // add item to receipt if it exists
                    receipt.Add(new ReceiptItem(
                    item.ToString(),
                    getOccurences.Count - getStats.Count,
                    getStats.Count,
                    item.getPrice()
                    ));
                }
            }

            int totalScrap = 0;
            int numberOfItems = 0;
            int numberOfMC = 0;

            // print receipt
            foreach(ReceiptItem item in receipt)
            {
                receiptText.Add(item.printLine());
                totalScrap+=item.totalScrap;
                numberOfItems+=(item.amount + item.amountMC);
                numberOfMC+=item.amountMC;
            }

            receiptText.Add("Customer: " + customerName);
            receiptText.Add("Total Number of Items Scrapped: " + numberOfItems);
            receiptText.Add("Number of MC Items: " + numberOfMC);
            receiptText.Add("Total Scrap Value: $" + String.Format("{0:n0}", totalScrap));
            receiptText.Add("Service Charge: $" + String.Format("{0:n0}", serviceCharge));
            receiptText.Add("Total Amount Paid to Customer: $" + String.Format("{0:n0}", totalScrap - serviceCharge*numberOfItems));
            receiptText.Add("Scrapper Profit: $" + String.Format("{0:n0}", serviceCharge*numberOfItems));

            File.WriteAllLines("receipt.txt", receiptText);
        }
    }
}
