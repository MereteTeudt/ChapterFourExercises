using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset
{
    class AssetTest
    {
        static void Main(string[] args)
        {
            Asset assetOne = new Asset("Toyota C-HR", 100, 10);
            Asset assetTwo = new Asset("Fiat 500", 100, 15);

            Console.WriteLine($"Depreciation: {assetOne.DepreciationAmount()}. Depreciated value: {assetOne.DepreciatedValue()}");
            Console.WriteLine($"Depreciation: {assetTwo.DepreciationAmount()}. Depreciated value: {assetTwo.DepreciatedValue()}");

            Console.ReadLine();
        }
    }
}
