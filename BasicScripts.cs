using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BasicScripts : MonoBehaviour {


    public Slider soundSlider;
    private int soundSliderValue;

	// Use this for initialization
	void Start () 
    {
        soundSlider.value = PlayerPrefs.GetInt("SoundSlider");

	}
	
	// Update is called once per frame
	void Update () 
    {
        if(soundSlider.value == 0)
        {
            soundSliderValue = 0;
            PlayerPrefs.SetInt("SoundSlider", soundSliderValue);
        }
        if (soundSlider.value == 1)
        {
            soundSliderValue = 1;
            PlayerPrefs.SetInt("SoundSlider", soundSliderValue);
        }
	
	}
}
