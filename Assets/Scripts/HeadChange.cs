using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadChange : MonoBehaviour {
	public Image startingImage;
	public Image HeadImage;
	public Sprite[] Hats;
	public Sprite[] Helmets;
	private Sprite[] spriteArray;
	public Toggle HelmetOn;

	private int imageNumber = 0;

	private void Start() {
		if (HelmetOn.isOn) {
			spriteArray = Helmets;
			HeadImage.enabled = false;
		} else {
			spriteArray = Hats;
			HeadImage.enabled = true;
		}
	}

	public void NextButtonClicked()
	{
		HeadImage.enabled = false;
		imageNumber++;
		if (imageNumber >= spriteArray.Length)
		{
			imageNumber = 0;
		}
		UpdateImage();
	}

	public void PrevButtonClicked()
	{
		HeadImage.enabled = false;
		imageNumber--;
		if (imageNumber < 0)
		{
			imageNumber = spriteArray.Length - 1;
		}
		UpdateImage();
	}

	public void UpdateImage()
	{
		if (HelmetOn.isOn) {
			spriteArray = Helmets;
			HeadImage.enabled = false;
		} else {
			spriteArray = Hats;
			HeadImage.enabled = true;
		}
		startingImage.sprite = spriteArray[imageNumber];
	}
}
