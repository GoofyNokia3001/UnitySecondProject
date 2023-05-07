using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MusicController : MonoBehaviour

{

	public Slider volumeSlider;
	public GameObject ObjectMusic;
	//Value from the slider, and it converts to volume level
	private float MusicVolume = 0f;
	private AudioSource AudioSource;

	private void Start()
	{
		ObjectMusic = GameObject.FindWithTag ("GameMusic");
		AudioSource = ObjectMusic.GetComponent<AudioSource>();


		//set Volune
		MusicVolume = PlayerPrefs.GetFloat("volune");
		AudioSource. volume = MusicVolume;
		volumeSlider.value = MusicVolume;
	}


	private void Update()
	{
		AudioSource. volume = MusicVolume;
		PlayerPrefs.SetFloat("volume:", MusicVolume);
			}

			public void VolumeUpdater(float volume)
			{
				MusicVolume = volume;
			}


			public void MusicReset(){



				PlayerPrefs.DeleteKey ("volume");
				AudioSource. volume = 1;
		volumeSlider.value = 1;
			}
			}
