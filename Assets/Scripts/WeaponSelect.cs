using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelect : MonoBehaviour {
	public Image weaponImage;
	public Sprite[] weapons;
	public Toggle showWeaponsToggle;
	public Dropdown weaponDropdown;

	private int currentWeaponIndex = 0;

	void Start() {
		if (showWeaponsToggle != null) {
			showWeaponsToggle.onValueChanged.AddListener(delegate {
				ShowWeaponSelect(showWeaponsToggle.isOn);
			});
		}

		if (weaponDropdown != null) {
			weaponDropdown.ClearOptions();

			List<string> weaponOptions = new List<string>();

			foreach (Sprite weapon in weapons) {
				weaponOptions.Add(weapon.name);
			}

			weaponDropdown.AddOptions(weaponOptions);

			weaponDropdown.onValueChanged.AddListener(delegate {
				ChangeWeapon(weaponDropdown.value);
			});
		}

		if (showWeaponsToggle != null) {
			ShowWeaponSelect(showWeaponsToggle.isOn);
		}
	}

	private void ShowWeaponSelect(bool show) {
		weaponImage.enabled = show;
		weaponDropdown.gameObject.SetActive(show);
		if (show) {
			UpdateWeaponImage();
		}
	}

	private void ChangeWeapon(int index) {
		currentWeaponIndex = index;
		UpdateWeaponImage();
	}

	private void UpdateWeaponImage() {
		weaponImage.sprite = weapons[currentWeaponIndex];

		if (currentWeaponIndex == 0) {
			weaponImage.rectTransform.localScale = new Vector3(0.42f, 1.75f, 1f);
		} else if (currentWeaponIndex == 1) {
			weaponImage.rectTransform.localScale = new Vector3(0.21f, 3.25f, 1f);
		} else if (currentWeaponIndex == 2) {
			weaponImage.rectTransform.localScale = new Vector3(0.42f, 3.5f, 1f);
		} else if (currentWeaponIndex == 3) {
			weaponImage.rectTransform.localScale = new Vector3(0.42f, 1.7f, 1f);
		} else if (currentWeaponIndex == 4) {
			weaponImage.rectTransform.localScale = new Vector3(0.21f, 1.75f, 1f);
		} else if (currentWeaponIndex == 5) {
			weaponImage.rectTransform.localScale = new Vector3(0.55f, 2f, 1f);
		} else if (currentWeaponIndex == 6) {
			weaponImage.rectTransform.localScale = new Vector3(0.21f, 3f, 1f);
		} else {
			weaponImage.rectTransform.localScale = Vector3.one;
		}
	}
}
