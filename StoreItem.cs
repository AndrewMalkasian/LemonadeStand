using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class StoreItem
    {
        public string keyId;
        public string name;
        public double cost;
        public int totalProductBought;

        public StoreItem(string keyId, string name, double cost, int totalProductBought)
        {
            this.keyId = keyId;
            this.name = name;
            this.cost = cost;
            this.totalProductBought = totalProductBought;


        }

    }
}
