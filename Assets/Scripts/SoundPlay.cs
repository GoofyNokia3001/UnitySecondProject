using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlay : MonoBehaviour {
	public AudioSource soundPlay;

	public void playThisSoundEffect()
	{
		soundPlay.Play ();
	}
}
