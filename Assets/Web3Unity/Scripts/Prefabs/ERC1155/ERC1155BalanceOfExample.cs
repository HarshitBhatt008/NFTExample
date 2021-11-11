using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ERC1155BalanceOfExample : MonoBehaviour
{
    public Text balanceText;
    async void Start()
    {
        
        string chain = "ethereum";
        string network = "Mainnet"; // mainnet ropsten kovan rinkeby goerli
        string account = PlayerPrefs.GetString("Account");

        string balance = await EVM.BalanceOf(chain, network, account);

        print(balance);

        balanceText.text = "Balance : "+ balance.ToString();
    }
}
