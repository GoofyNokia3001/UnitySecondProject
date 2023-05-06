using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("CharacterCustom");
        Debug.Log("CharacterCustom");
    }
	public void Settings()
	{
		SceneManager.LoadScene("Settings");
		Debug.Log("Settings");
	}
	public void MainMenu()
	{
		SceneManager.LoadScene("MainMenu");
		Debug.Log("MainMenu");
	}
   
}