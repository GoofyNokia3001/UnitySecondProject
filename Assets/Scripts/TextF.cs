using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JetBrains.Annotations;
using UnityEngine.UI;

public class TextF : MonoBehaviour {
	private string text;
	private int age;
	public GameObject inputField;
	public GameObject ageField;
	public GameObject textImager;

	// Use this for initialization
	public void SaveText() {
		text = inputField.GetComponent<InputField>().text;
		int x = 0; // Initialize x with a default value

		// Check if both fields are empty
		if (string.IsNullOrEmpty(text.Trim()) && string.IsNullOrEmpty(ageField.GetComponent<InputField>().text.Trim())) {
			textImager.GetComponent<Text>().text = "Please enter your name and age.";
			return;
		}

		// Check if name field is empty
		if (string.IsNullOrEmpty(text.Trim())) {
			textImager.GetComponent<Text>().text = "Name wrong";
			return;
		}

		// Check if age field is empty or invalid
		if (string.IsNullOrEmpty(ageField.GetComponent<InputField>().text.Trim()) || !int.TryParse(ageField.GetComponent<InputField>().text, out x)) {
			textImager.GetComponent<Text>().text = "Age wrong";
			return;
		}

		age = x;

		// Check if age is out of range
		if (age < 20 || age > 122) {
			textImager.GetComponent<Text>().text = "Age must be between 20 and 122.";
			return;
		}

		textImager.GetComponent<Text>().text = "Hello hero: " + text + ", you are " + age + " years old.\n";
	}
}
