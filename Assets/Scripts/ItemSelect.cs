using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSelect : MonoBehaviour{
	public Image weaponImage;
	public Sprite[] weapons;
	public Toggle showWeaponsToggle;
	public Button nextButton;
	public Button prevButton;

	private int currentWeaponIndex = 0;

	void Start() {
		if (nextButton != null) {
			nextButton.onClick.AddListener(delegate {
				ChangeWeapon(1);
			});
		}
		if (showWeaponsToggle != null) {
			showWeaponsToggle.onValueChanged.AddListener(delegate {
				ShowWeaponSelect(showWeaponsToggle.isOn);
			});
		}
		if (nextButton != null) {
			prevButton.onClick.AddListener (delegate {
				ChangeWeapon (-1);
			});
		}
		if (nextButton != null) {
			ShowWeaponSelect (showWeaponsToggle.isOn);
		}
	}

	private void ShowWeaponSelect(bool show) {
		weaponImage.enabled = show;
		nextButton.gameObject.SetActive(show);
		prevButton.gameObject.SetActive(show);
		if (show) {
			UpdateWeaponImage();
		}
	}

	private void ChangeWeapon(int delta) {
		currentWeaponIndex += delta;
		if (currentWeaponIndex < 0) {
			currentWeaponIndex = weapons.Length - 1;
		}
		if (currentWeaponIndex >= weapons.Length) {
			currentWeaponIndex = 0;
		}
		UpdateWeaponImage();
	}

	private void UpdateWeaponImage() {
		weaponImage.sprite = weapons[currentWeaponIndex];
		if (currentWeaponIndex == 0) {
			weaponImage.rectTransform.localScale = new Vector3 (0.21f, 1f, 1f);
		} else if (currentWeaponIndex == 1) {
			weaponImage.rectTransform.localScale = new Vector3 (0.75f, 0.75f, 1f);
		} else if (currentWeaponIndex == 2) {
			weaponImage.rectTransform.localScale = new Vector3 (0.75f, 0.75f, 1f);
		} 
	}
}
