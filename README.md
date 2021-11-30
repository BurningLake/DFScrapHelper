# DFScrapHelper
More Scrapping With Less Hassle!

## Startup!
NOTE: To run the application please have .NET 5.0 Runtime installed on your machine which could be found at https://dotnet.microsoft.com/download/dotnet/5.0
1. Clone this repository or download the zip and extract to the location of your choosing.
2. Run the 'run.bat' batch file to run the Scrap Helper application.

## How Do I Use This?
1. Visit the Private Trade Panel either through the Archived Trades or a Current Trade.

![Capture](https://user-images.githubusercontent.com/63990105/144073312-ccd50fd1-6e60-4b1f-94a6-ac6440c5a6d0.PNG)

2. Right click the first item in their trades and select "Inspect"

![image](https://user-images.githubusercontent.com/63990105/144073636-1ca66e6e-3c04-4f62-8af1-3950d1bc472b.png)

3. This opens up the HTML element. Right click the element that says "marketDataHolder itemHolder theirItems" --> Copy --> Copy Element. The element you're looking for is the one right above the one you right-clicked.

![image](https://user-images.githubusercontent.com/63990105/144074139-8ee29c5f-3975-45c1-b355-b3af604e5d59.png)

4. Open the "archived_trade.txt" file.

![image](https://user-images.githubusercontent.com/63990105/144074743-cc644e8f-3b5e-4eb0-97b3-f36f960b9c64.png)

5. Paste the Item list you copied into this file.

![image](https://user-images.githubusercontent.com/63990105/144075107-b862ba4f-9bdc-47b6-9f17-2cbd34b896bd.png)

6. Run the application! It will ask you for under-scrap price (usually 3k) and the name of the player that's being helped. Receipt will be generated in the "receipt.txt" file.

![image](https://user-images.githubusercontent.com/63990105/144075712-76a6d2d8-0981-491e-9347-f6beb96dc79c.png)

7. This receipt file could be sent through discord for others to look at and verify. 
8. For more than one trade window, you could past the item list on a new line in "archived_trade.txt" and the app will count the additional items as well.
9. Verify that the number of items the player sent is the same as what the receipt tells you, sometimes people send one-off items that haven't been accounted for which I will have to add manually.
