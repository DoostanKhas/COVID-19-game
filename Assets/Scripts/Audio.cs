using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    public Slider Master_Volume_Slider_Three;
    public Slider Music_Volume_Slider_Three;
    public Slider SFX_Volume_Slider_Three;
    public AudioMixer AudioMixerObject;

    void Start()
    {

    }

    void update()
    {
        Master_Volume_Slider_Three.value = PlayerPrefs.GetFloat("CurrentMasterVolume");
        Music_Volume_Slider_Three.value = PlayerPrefs.GetFloat("CurrentMusicVolume");
        SFX_Volume_Slider_Three.value = PlayerPrefs.GetFloat("CurrentSFXVolume");
    }

    public void SetMasterVolume(float master)
    {
        AudioMixerObject.SetFloat("MasterVolume", master);
        PlayerPrefs.SetFloat("CurrentMasterVolume", Master_Volume_Slider_Three.value);
    }
    public void SetMusicVolume(float music)
    {
        AudioMixerObject.SetFloat("MusicVolume", music);
        PlayerPrefs.SetFloat("CurrentMusicVolume", Music_Volume_Slider_Three.value);
    }
    public void SetSFXVolume(float sfx)
    {
        AudioMixerObject.SetFloat("SFXVolume", sfx);
        PlayerPrefs.SetFloat("CurrentSFXVolume", SFX_Volume_Slider_Three.value);
    }
}
