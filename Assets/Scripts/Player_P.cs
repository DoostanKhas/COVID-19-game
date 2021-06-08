using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Player_P : MonoBehaviour
{
    public GameObject PanleLose;
    public GameObject PanleGame;
    public GameObject PanleOptionLose;
    public int LevelLoaderNumber;
    public Slider Master_Volume_Slider_Two;
    public Slider Music_Volume_Slider_Two;
    public Slider SFX_Volume_Slider_Two;
    public AudioMixer AudioMixerObject;

    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x > Screen.width)
        {
            die();
        }
    }
    public void OptionButton()
    {
        Time.timeScale = 0;
        PanleOptionLose.SetActive(true);
        PanleLose.SetActive(false);
    }
    public void BackfromOptionButton()
    {
        Time.timeScale = 0;
        PanleLose.SetActive(true);
        PanleOptionLose.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D corona)
    {
        die();
    }
    void die()
    {
        Time.timeScale = 0;
        PanleGame.SetActive(false);
        PanleLose.SetActive(true);
        GameObject[] allRocks = GameObject.FindGameObjectsWithTag("rocks");

        for (int i = 0; i < allRocks.Length; i++)
        {
            allRocks[i].SetActive(false);
        }
        
    }
    public void SetMasterVolume(float master)
    {
        AudioMixerObject.SetFloat("MasterVolume", master);
        PlayerPrefs.SetFloat("CurrentMasterVolume", Master_Volume_Slider_Two.value);
    }
    public void SetMusicVolume(float music)
    {
        AudioMixerObject.SetFloat("MusicVolume", music);
        PlayerPrefs.SetFloat("CurrentMusicVolume", Music_Volume_Slider_Two.value);
    }
    public void SetSFXVolume(float sfx)
    {
        AudioMixerObject.SetFloat("SFXVolume", sfx);
        PlayerPrefs.SetFloat("CurrentSFXVolume", SFX_Volume_Slider_Two.value);
    }
}
