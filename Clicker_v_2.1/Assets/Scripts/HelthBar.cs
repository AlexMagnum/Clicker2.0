using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HelthBar : MonoBehaviour {

	public UnityEngine.UI.Text HelthDisplay;
	public float Health = 1000;
	public float hpPoint = 1000;
	public GoldPerSec GoldPS;
	public Click click;
	public int k = 0;
	private Slider _slider;

	void Start()
	{
		_slider = GetComponentInChildren<Slider> (); 
	}

	void Update(){
		HelthDisplay.text = Health.ToString ("F0");
		Health -= (GoldPS.GetGoldPerSec () / 10);


		if (Health <= 0) {
			k++;
			switch (k) {
			case 1:
				Health = 10000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [1];
				break;
			case 2:
				Health = 100000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [2];
				break;
			case 3:
				Health = 250000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [3];
				break;
			case 4:
				Health = 500000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [4];
				break;
			case 5:
				Health = 1000000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [5];
				break;
			case 6:
				Health = 2000000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [6];
				break;
			case 7:
				Health = 4000000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [7];
				break;
			case 8:
				Health = 8000000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [8];
				break;
			case 9:
				Health = 1600000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [9];
				break;
			case 10:
				Health = 32000000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [10];
				break;
			case 11:
				Health = 64000000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [11];
				break;
			case 12:
				Health = 128000000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [12];
				break;
			case 13:
				Health = 256000000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [13];
				break;
			case 14:
				Health = 512000000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [14];
				break;
			case 15:
				Health = 1024000000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [15];
				break;
			case 16:
				Health = 2048000000;
				hpPoint = Health;
				click.button.image.overrideSprite = click.sprites [16];
				break;
			}
		}

		_slider.value = (hpPoint - Health) / hpPoint ;
	}
			
}
