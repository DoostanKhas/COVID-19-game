using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System;

public class Menu : MonoBehaviour
{
    //string CoinNumberStr = "0";
    int Number = 1;
    public Text CoinNumber;
    public GameObject Loading_Panel;
    public GameObject MainMenuHolder;
    public int LevelNumber;
    public GameObject DifficultyHolder;
    public GameObject QuitPanelHolder;
    public GameObject OptionHolder;
    public GameObject About_us_Holder;
    public GameObject Store_Panel;
    public GameObject CoinPanel;
    public Button CoinButton;
    public Button YesButtonForCoinPanel;
    //public Button CharacterBtn;
    //public GameObject CharactersPanel;
    //public GameObject TikCharacter;
    public GameObject TikGhiroscop;
    public GameObject TikButton;
    public GameObject TikPer;
    public GameObject TikEng;
    //public Button Pessar1;
    public Button store;
    public Button Level_1;
    public Button Level_2;
    public Button Level_3;
    public Button Level_4;
    public GameObject vote;
    public GameObject myket;
    public Slider Master_Volume_Slider;
    public Slider Music_Volume_Slider;
    public Slider SFX_Volume_Slider;
    public AudioMixer AudioMixerObject;
    //public int VersionInt = 

    public void Buttons_Button()
    {
        Number = 1;
        PlayerPrefs.SetInt("number", Number);
        TikButton.SetActive(true);
        TikGhiroscop.SetActive(false);
    }

    public void Ghiroscop_Button()
    {
        Number = 2;
        PlayerPrefs.SetInt("number", Number);
        TikGhiroscop.SetActive(true);
        TikButton.SetActive(false);
    }

    public void Start_Button()
    {
        MainMenuHolder.SetActive(false);
        DifficultyHolder.SetActive(true);
        vote.SetActive(false);
        myket.SetActive(false);
    }
    private void Awake()
    {
        if (PlayerPrefs.GetInt("number") == 1)
        {
            TikGhiroscop.SetActive(false);
            TikButton.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("number") == 2)
        {
            TikGhiroscop.SetActive(true);
            TikButton.SetActive(false);
        }
    }
    void Start()
    {
        store.onClick.AddListener(() =>
        {
            Store_Panel.SetActive(true);
            vote.SetActive(false);
            myket.SetActive(false);
            MainMenuHolder.SetActive(false);
        });
        CoinButton.onClick.AddListener(() =>
        {
            CoinPanel.SetActive(true);
        });
        YesButtonForCoinPanel.onClick.AddListener(() =>
        {
            CoinPanel.SetActive(false);
        });
        Level_1.onClick.AddListener(() =>
        {
            Time.timeScale = 1;
            Loading_Panel.SetActive(true);
            SceneManager.LoadScene(LevelNumber);
        });

        Level_2.onClick.AddListener(() =>
        {
            Time.timeScale = 1;
            Loading_Panel.SetActive(true);
            SceneManager.LoadScene(LevelNumber + 1);
        });

        Level_3.onClick.AddListener(() =>
        {
            Time.timeScale = 1;
            Loading_Panel.SetActive(true);
            SceneManager.LoadScene(LevelNumber + 2);
        });
        Level_4.onClick.AddListener(() =>
        {
            Time.timeScale = 0;
            Loading_Panel.SetActive(true);
            SceneManager.LoadScene(LevelNumber + 3);
        });
        if (PlayerPrefs.GetInt("Coin") == 30 || PlayerPrefs.GetInt("Coin") == 50 || PlayerPrefs.GetInt("Coin") == 70 || PlayerPrefs.GetInt("Coin") == 90)
        {
            //CoinNumber.text = "30";
            int Coin = PlayerPrefs.GetInt("Coin");
            int CoinFinally = Convert.ToInt32(CoinNumber);
            int CoinNumberFinally = CoinFinally + Coin;
            CoinNumber.text = CoinNumberFinally.ToString();
        }
        /*CharacterBtn.onClick.AddListener(() =>
        {
            CharactersPanel.SetActive(true);
        });*/
        /*Pessar1.onClick.AddListener(() =>
        {
            TikCharacter.SetActive(true);
        });*/
    }
    public void Abut_us_BTN()
    {
        About_us_Holder.SetActive(true);
        vote.SetActive(false);
        myket.SetActive(false);
        MainMenuHolder.SetActive(false);
    }
    public void BackToMainMenuFromAbut_us()
    {
        MainMenuHolder.SetActive(true);
        About_us_Holder.SetActive(false);
        myket.SetActive(true);
        vote.SetActive(true);
    }
    public void BackToMainMenuFromStore()
    {
        MainMenuHolder.SetActive(true);
        Store_Panel.SetActive(false);
        myket.SetActive(true);
        vote.SetActive(true);
    }
    //public void BackToStoreFromCharacterSelection()
    //{
        //CharactersPanel.SetActive(false);
    //}
    public void option_BTN()
    {
        OptionHolder.SetActive(true);
        vote.SetActive(false);
        myket.SetActive(false);
        MainMenuHolder.SetActive(false);
    }
    public void BackToMainMenuFromOption()
    {
        OptionHolder.SetActive(false);
        vote.SetActive(true);
        myket.SetActive(true);
        MainMenuHolder.SetActive(true);
    }
    public void BackToMainMenuFromDifficulty()
    {
        MainMenuHolder.SetActive(true);
        DifficultyHolder.SetActive(false);
        myket.SetActive(true);
        vote.SetActive(true);
    }
    public void Quit_Button()
    {
        QuitPanelHolder.SetActive(true);
        myket.SetActive(false);
        vote.SetActive(false);
    }
    public void Quit_Yes_Button()
    {
        Application.Quit();
    }
    public void Quit_No_Button()
    {
        QuitPanelHolder.SetActive(false);
        myket.SetActive(true);
        vote.SetActive(true);
    }
    public void SetMasterVolume(float master)
    {
        AudioMixerObject.SetFloat("MasterVolume", master);
        PlayerPrefs.SetFloat("CurrentMasterVolume", Master_Volume_Slider.value);
    }
    public void SetMusicVolume(float music)
    {
        AudioMixerObject.SetFloat("MusicVolume", music);
        PlayerPrefs.SetFloat("CurrentMusicVolume", Music_Volume_Slider.value);
    }
    public void SetSFXVolume(float sfx)
    {
        AudioMixerObject.SetFloat("SFXVolume", sfx);
        PlayerPrefs.SetFloat("CurrentSFXVolume", SFX_Volume_Slider.value);
    }
    void Update()
    {
        Master_Volume_Slider.value = PlayerPrefs.GetFloat("CurrentMasterVolume");
        Music_Volume_Slider.value = PlayerPrefs.GetFloat("CurrentMusicVolume");
        SFX_Volume_Slider.value = PlayerPrefs.GetFloat("CurrentSFXVolume");
        //CoinNumber.text = "0";
        //int Coin = PlayerPrefs.GetInt("Coin");
        //int CoinFinally = Convert.ToInt32(CoinNumber);
        //int CoinNumberFinally = CoinFinally + Coin;
        //CoinNumber.text = CoinNumberFinally.ToString();
    }

}