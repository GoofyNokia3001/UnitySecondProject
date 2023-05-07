using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LegsChange : MonoBehaviour {


	public Image startingImageLeft;
	public Image startingImageRight;
	public Sprite[] spritesLeft;
	public Sprite[] spritesRight;

	private int imageNumber = 0;

	public void NextButtonClicked()
	{
		imageNumber++;
		if (imageNumber >= spritesLeft.Length)
		{
			imageNumber = 0;
		}else if(imageNumber >= spritesRight.Length){
			imageNumber = 0;
		}
		UpdateImage();
	}

	public void PrevButtonClicked()
	{
		imageNumber--;
		if (imageNumber < 0)
		{
			imageNumber = spritesLeft.Length - 1;
			imageNumber = spritesRight.Length - 1;
		}
		UpdateImage();
	}

	private void UpdateImage()
	{
		startingImageLeft.sprite = spritesLeft[imageNumber];
		startingImageRight.sprite = spritesRight[imageNumber];
	}
}


