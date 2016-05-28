using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

	public UnityEngine.UI.Text goldDisplay;
	public UnityEngine.UI.Text gpc;

	public float gold = 0.00f;
	public int goldPerClick = 1;

	void Update(){
		goldDisplay.text = CurrencyConverter.Instance.GetCurrencyIntoString(gold, false, false);
		gpc.text = CurrencyConverter.Instance.GetCurrencyIntoString(goldPerClick, false, true) + " gold/click";
	}

	public void Clicked() {
		gold += goldPerClick;

	}
}
