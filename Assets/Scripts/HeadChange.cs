using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadChange : MonoBehaviour {
	public Image startingImage;
	public Image HeadImage;
	public Sprite[] sprites;

	private int imageNumber = 0;

	public void NextButtonClicked()
	{HeadImage.enabled = false;
		imageNumber++;
		if (imageNumber >= sprites.Length)
		{
			imageNumber = 0;
		}
		UpdateImage();
	}

	public void PrevButtonClicked()
	{HeadImage.enabled = false;
		imageNumber--;
		if (imageNumber < 0)
		{
			imageNumber = sprites.Length - 1;
		}
		UpdateImage();
	}

	private void UpdateImage()
	{if (imageNumber >= 7) {
			HeadImage.enabled = true;
	} else {HeadImage.enabled = false;
		}
		startingImage.sprite = sprites[imageNumber];
	}
}
