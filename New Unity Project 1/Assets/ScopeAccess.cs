using UnityEngine;
using System.Collections;

public class ScopeAccess : MonoBehaviour {

	public int coins = 0;
	public int num2;

	void OnEnable(){
		int num = AddCoin(coins, num2);
		print(this.name + " has " + num + " Coins");
	}

	public int AddCoin(int coins, int num2){

		int result = coins;
        while(coins <100){
            coins = coins + num2;
        }

		return coins;
	}
}
