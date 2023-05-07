using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("CharacterCustom");
       
    }
	public void Settings()
	{
		SceneManager.LoadScene("Settings");
	
	}
	public void MainMenu()
	{
		SceneManager.LoadScene("MainMenu");

	}
	public void End()
	{
		SceneManager.LoadScene("GameOver");

	}
   
}