using System;
using System.Collections.Generic;

public class ReceiptItem
{
    public ReceiptItem(string p_name, int p_amount, int p_amountMC, int p_pricePerUnit)
    {
        name = p_name;
        amount = p_amount;
        amountMC = p_amountMC;
        pricerPerUnit = p_pricePerUnit;
        totalScrap = pricerPerUnit*(amount + 2*amountMC);
    }   
    public string name;
    public int amount;
    public int amountMC;
    public int pricerPerUnit;
    public int totalScrap;

    public string printLine()
    {
        string textOutput = "===== " + name + " =====\r\nPrice Per Unit: $" + String.Format("{0:n0}", pricerPerUnit)+ "\r\nNumber of Non-MCs: " + amount + "\r\nNumber of MCs: " + amountMC + "\r\nScrap Value: $" + String.Format("{0:n0}", totalScrap) + "\r\n";

        return textOutput;
    }
}