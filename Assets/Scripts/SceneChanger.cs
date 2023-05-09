using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{ 
	public void Create()
	{
		SceneManager.LoadScene("CharacterChanger");

	}
    public void PlayK()
    {
        SceneManager.LoadScene("CharacterCustomK");
       
    }
	public void PlayD()
	{
		SceneManager.LoadScene("CharacterCustomD");

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