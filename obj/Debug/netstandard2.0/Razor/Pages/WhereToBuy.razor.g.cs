#pragma checksum "/usr/local/bin/WebApplication1/Pages/WhereToBuy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d395acf471d24e74b3ce7af0342e32e03bb9d548"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/usr/local/bin/WebApplication1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/usr/local/bin/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/usr/local/bin/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "/usr/local/bin/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "/usr/local/bin/WebApplication1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/usr/local/bin/WebApplication1/_Imports.razor"
using WebApplication1;

#line default
#line hidden
#line 7 "/usr/local/bin/WebApplication1/_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/wheretobuy")]
    public class WhereToBuy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>How Do I Purchase, Buy, and Hold Electra? (ECA)</h1>\n<br>\n");
            builder.AddMarkupContent(1, "<h2>Where Do I Even Start?</h2>\n\n");
            builder.AddMarkupContent(2, "<p>You want to be an investor in Electra (ECA) but you have no idea where to begin?\nLet\'s walk you through the things you need to be successful and to be a holder of ECA!\n</p>\n\n");
            builder.AddMarkupContent(3, "<ul>\n   <li>1. A place to hold your Electra Coins</li>\n   <li>2. A place to buy or purchase your Electra Coins</li>\n   <li>3. A source or means to buy or purchse your Electra Coins</li>\n</ul>\n\n");
            builder.AddMarkupContent(4, "<h3>A Place to Hold Your Electra Coins</h3>\n");
            builder.AddMarkupContent(5, @"<p>Coins need to be stored in a wallet. This is the basic fundamental understanding of cryptocurrency. In order to store you coins in your wallet, your wallet needs to know what coins belong to you as the investor.
How does my wallet know what coins are belong to the investor? That's through private keys. The wallet itself actually does not for lack of better terms ""hold"" your Electra coins. The wallet stores the private keys in the wallet so they may be accessed on the blockchain.
When you move coins between exchanges, wallets, and back and fourth between the wallets and exchanges, your private keys are authorizing the amount of coins to be moved to new addresses. Your wallet addresses, really called public keys, are viewable on a blockchain, the public ledger. Your private keys are not to be revealed by anyone and should not be revealed to anyone else. Let me make an example that might help it to be easier understood.</p>

");
            builder.AddMarkupContent(6, "<p>Imagine a home. Homes are meant to be locked when not in use (there are other times they should be locked but just bear with me). Your home is like your wallet. People know you have one, they know it exists and your home holds many things!\n<br><br>\nYour home also has rooms. So far, let\'s think of the home as a wallet, and the rooms as addresses. Your home holds rooms which a wallet hold addresses. To access your wallet or to get insides your home, you need to get past the locks. To get past these locks you need to the code to get in. In cryptocurrency, that is called \"Encrypting your wallet\". It\'s a simple process that the user enables and can the wallet can be unlocked with a password or passphrase.\n<br><br>\nNow as I mentioned earlier, your rooms are addresses. Imagine these rooms on the outside walls of the house so they each have a window. As your walking buy a house you do not own, you can see in the room from the outside of the home. You, not the owner, do not have access to inside the room as you do not have access to inside the home. As for wallets, each address in the wallet, or public address, can be seen by anyone on the blockchain. It\'s public knowledge just as if you were passing by a window and could see a bed, maybe a dresser, and mayb even a television. Those items think of them as the \"coins\" in your wallet. Only the owner has access to those items.\n<br><br>\nBut how does one moves these items from room to room or from house to house? That is where private keys come in.\n<br><br>\nPrivate keys are for example are the doors to each room. If you own the house you can freely move items from room to room. As with our wallets, we can freely move coins from address to address. Easy right? But how does it work if you send your coins or your house items to a neighbor? Send items is the same concept as if you took your items from a room and are given to your neighbor. When sending coins you are sending your coins from public address to public address. Since you hold the private keys in your wallet, you can authorize the movement of coins from your public address to someone else\'s public address. Then only that person will have authorization to move those coins as they have the private keys to that address. In simple terms, each public address has a private address.\n</p>\n\n");
            builder.AddMarkupContent(7, "<h3>A Place to Buy or Purchase Your Electra Coin</h3>\n");
            builder.AddMarkupContent(8, @"<p>Where can I buy or purchase Electra? You have many options. You can purchase coins on Exchanges. If you are familiar with the stock market, think of it as a stock exchange. It's very similar. If you have never worked with stocks before, think of it as a place where buyer and sellers are and can name the price they want to buy or sell at.
<br><br>
Coins can also be gained through means of other Electra investors. It's as simple as the user sending you coins to your Electra wallet.
<br><br>
You can find the current list of exchanges by clicking on the following link: <a herf=""https://electraproject.org/exchanges/"">https://electraproject.org/exchanges/</a>
</p>

");
            builder.AddMarkupContent(9, "<h3>A Source or Means to Buy or Purchase Your Electra Coins</h3>\n");
            builder.AddMarkupContent(10, @"<p>Electra coins or ECA, can be purchased using fiat (paper currency or in digital format) or using other crypto currencies. Some of the most common currencies you can buy Electra with (or also called trading pairs) are Bitcoin, Litecoin, Ethereum, and Dogecoin. THere are many others always being added but these are the most common.
<br><br>
In order to receive any other crypto currency, you more than likely need to use your fiat currency to first. Examples sites such as Coinbase, Kraken, etc and even mobile apps such as CashApp for example support the use of trading fiat currency for major crypto currencies. You could use your fiat currency and purchase for example Bitcoin. In order to buy Electra, you would need to send Bitcoin from the exchange your purchased it from and send it to the exchange you wish to buy ECA from.
<br><br>
Each exchange has it's own set of rules, laws, and regulations, all through each lcoation country and the user purchasing crypto has to follow the regulations of their own country. This also brings KYC, Know your Customer, in to play. You are required by some exchanges to provide personal info, including social security number for a number of American exchanges, to purchase crypto. As these safeguards may be burdensome, they are requried. Please refer to your local laws for any legal and financial questions.
</p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
