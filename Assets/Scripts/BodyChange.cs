using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyChange : MonoBehaviour {
	public Image startingImage;
	public Sprite[] sprites;

	private int imageNumber = 0;

	public void NextButtonClicked()
	{
		imageNumber++;
		if (imageNumber >= sprites.Length)
		{
			imageNumber = 0;
		}
		UpdateImage();
	}

	public void PrevButtonClicked()
	{
		imageNumber--;
		if (imageNumber < 0)
		{
			imageNumber = sprites.Length - 1;
		}
		UpdateImage();
	}

	private void UpdateImage()
	{
		startingImage.sprite = sprites[imageNumber];
	}
}
