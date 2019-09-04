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

        

      
        //filter callback function thing for filtering by KeyID
        public StoreItem(string keyId, string name, double cost)
        {
            this.keyId = keyId;
            this.name = name;
            this.cost = cost;


        }

    }
}
