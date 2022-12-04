using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider musicSlider;
    

    public const string MIXER_MUSIC = "MusicVolume";
    
   
    void Awake() 
    {
        musicSlider.onValueChanged.AddListener(SetMusicVolume);
        
    }

    void Start() 
    {
       
        musicSlider.value = PlayerPrefs.GetFloat(AudioManager.MUSIC_KEY, 1f); 
        
    }

    
    void OnDisable()
    {
        PlayerPrefs.SetFloat(AudioManager.MUSIC_KEY, musicSlider.value);
        
    }


    void SetMusicVolume(float volume)
    {
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(volume) * 20);
    }
}
