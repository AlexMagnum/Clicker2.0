using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Click : MonoBehaviour {

	public UnityEngine.UI.Text goldDisplay;
	public UnityEngine.UI.Text gpc;
	public Sprite[] sprites = new Sprite[16];
	public Button button;
	public HelthBar HB;

	public float gold = 0.00f;
	public int goldPerClick = 1;

	void Start()
	{
		button = GetComponent<Button> ();
	}

	void Update(){
		goldDisplay.text = CurrencyConverter.Instance.GetCurrencyIntoString(gold, false, false);
		gpc.text = CurrencyConverter.Instance.GetCurrencyIntoString(goldPerClick, false, true) + " DPC";

	}

	public void Clicked() {
		gold += goldPerClick;
		HB.Health -= goldPerClick;
		GetComponent<Animator> ().SetTrigger ("Hit");
	}
}
