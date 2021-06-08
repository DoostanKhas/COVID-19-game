using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System;

public class Game_Manager : MonoBehaviour
{
    public GameObject TikEasy;
    public GameObject TikMedium;
    public GameObject TikHard;
    public GameObject Loading_Panel;
    public string NextLevel;
    public Text ScoreText;
    public Text numberzofoniText;
    public Text numbermaskText;
    public GameObject rocks;
    public GameObject coronaese;
    public GameObject coronamedume;
    public GameObject coronahard;
    public float creatspeed;
    public float firstspeed;
    int score = 0;
    int mnumberzofoni = 3;
    int mnumbermask = 1;
    public int finishscore = 999999999;
    public Button FreeGameStart;
    public Text NoticeTextForUser;
    public GameObject PanelPused;
    public GameObject PanleGame;
    public GameObject PanleWin;
    public GameObject Quit_Panel;
    public GameObject PanleOption;
    public GameObject zofoni_img;
    public GameObject mask_img;
    public GameObject PesarMask;
    public GameObject PesarAsl;
    public GameObject firstpanel;
    public int LoadLevelNumber;
    public Button zofoni;
    public Button mask;
    public AudioClip gameaudio;
    AudioSource sound;
    public AudioMixer AudioMixerObject;
    public InputField finishscore2;
    public int finishscore3 = 100;
    public Text Mask;
    public Text Zofoni;
    // 1 Audio Publics
    public Slider Master_Volume_Slider;
    public Slider Music_Volume_Slider;
    public Slider SFX_Volume_Slider;

    void Update()
    {
        //Audio 1
        Master_Volume_Slider.value = PlayerPrefs.GetFloat("CurrentMasterVolume");
        Music_Volume_Slider.value = PlayerPrefs.GetFloat("CurrentMusicVolume");
        SFX_Volume_Slider.value = PlayerPrefs.GetFloat("CurrentSFXVolume");
    }

    void Start()
    {
        if (File.Exists(Application.persistentDataPath + "Mask.lvl"))
        {
            Mask.text = File.ReadAllText(Application.persistentDataPath + "Mask.lvl");
            int MaskInt = Convert.ToInt32(Mask.text);
            mnumbermask = mnumbermask + MaskInt;
            print("Mask Succesfuly!");
        }

        if (File.Exists(Application.persistentDataPath + "Zofoni.lvl"))
        {
            Zofoni.text = File.ReadAllText(Application.persistentDataPath + "Zofoni.lvl");
            int ZofoniInt = Convert.ToInt32(Zofoni.text);
            mnumbermask = mnumbermask + ZofoniInt;
            print("Zofoni Succesfuly!");
        }

        if (LoadLevelNumber == 4 || LoadLevelNumber == 9)
        {
            Time.timeScale = 0;
            FreeGameStart.onClick.AddListener(() =>
            {
                if (finishscore2.text == "")
                {
                    Time.timeScale = 0;
                    NoticeTextForUser.gameObject.SetActive(true);
                }
                else
                {
                    Time.timeScale = 1;
                    TikEasy.SetActive(false);
                    TikMedium.SetActive(false);
                    TikHard.SetActive(false);
                    finishscore3 = int.Parse(finishscore2.text);
                    PesarAsl.SetActive(true);
                    firstpanel.SetActive(false);
                }

            });
        }
        InvokeRepeating("Create_rock", firstspeed, creatspeed);
        sound = GetComponent<AudioSource>();
        sound.clip = gameaudio;
        sound.Play();
        zofoni.onClick.AddListener(() =>
        {
            mnumberzofoni--;
            string CurrentScore = ((int)(mnumberzofoni)).ToString();

            numberzofoniText.text = CurrentScore;
            GameObject[] allRocks = GameObject.FindGameObjectsWithTag("rocks");

            for (int i = 0; i < allRocks.Length; i++)
            {
                allRocks[i].SetActive(false);
            }

            Time.timeScale = 1;
            System.Threading.Thread.Sleep(100);
            Time.timeScale = 1;
        });
        mask.onClick.AddListener(() =>
        {
            mnumbermask--;
            string CurrentScore = ((int)(mnumbermask)).ToString();

            numbermaskText.text = CurrentScore;
            PesarMask.SetActive(true);
            PesarAsl.SetActive(false);
            InvokeRepeating("setactive", 15.0f, 0f);
        });
    }
    public void EasyBTN()
    {
        TikEasy.SetActive(true);
        TikMedium.SetActive(false);
        TikHard.SetActive(false);
        rocks = coronaese;
        creatspeed = 5.75f;
        firstspeed = 1.53f;
    }
    public void MediumBTN()
    {
        TikMedium.SetActive(true);
        TikEasy.SetActive(false);
        TikHard.SetActive(false);
        rocks = coronamedume;
        creatspeed = 4.2f;
        firstspeed = 0.54f;
    }
    public void HardBTN()
    {
        TikHard.SetActive(true);
        TikEasy.SetActive(false);
        TikMedium.SetActive(false);
        rocks = coronahard;
        creatspeed = 3.32f;
        firstspeed = 0f;
    }

    void setactive()
    {
        PesarMask.SetActive(false);
        PesarAsl.SetActive(true);
    }

    public void PusedButton()
    {
        Time.timeScale = 0;
        PanelPused.SetActive(true);
        PanleGame.SetActive(false);
        GameObject[] allRocks = GameObject.FindGameObjectsWithTag("rocks");

        for (int i = 0; i < allRocks.Length; i++)
        {
            allRocks[i].SetActive(false);
        }
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
        PanelPused.SetActive(false);
        PanleOption.SetActive(false);
        PanleGame.SetActive(true);
    }
    public void Exit_From_Any_Level()
    {
        Time.timeScale = 1;
        Loading_Panel.SetActive(true);
        PanelPused.SetActive(false);
        PanleOption.SetActive(false);
        PanleGame.SetActive(false);
        if (LoadLevelNumber < 5)
        {
            SceneManager.LoadScene(0);
        }
        if (LoadLevelNumber > 4)
        {
            SceneManager.LoadScene(5);
        }
    }
    public void ResumeButtonForFreeLevel()
    {
        PanelPused.SetActive(false);
        PanleOption.SetActive(false);
        PanleGame.SetActive(true);

        if (finishscore2.text == "")
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void ResetButton()
    {
        Time.timeScale = 1;
        Loading_Panel.SetActive(true);
        SceneManager.LoadScene(LoadLevelNumber);
    }
    public void ResetButtonForFreeLevel()
    {
        Time.timeScale = 0;
        Loading_Panel.SetActive(true);
        SceneManager.LoadScene(LoadLevelNumber);
    }
    public void NextLevelButton()
    {
        Time.timeScale = 1;
        Loading_Panel.SetActive(true);
        SceneManager.LoadScene(LoadLevelNumber + 1);
        if (LoadLevelNumber + 1 == 4)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            if (LoadLevelNumber + 1 == 8)
            {
                SceneManager.LoadScene(4);
            }
            else
            {
                SceneManager.LoadScene(LoadLevelNumber + 1);
            }
        }
    }
    public void MinExitPanelButton()
    {
        Time.timeScale = 0;
        PanelPused.SetActive(true);
        PanleGame.SetActive(false);
        Quit_Panel.SetActive(true);
        GameObject[] allRocks = GameObject.FindGameObjectsWithTag("rocks");

        for (int i = 0; i < allRocks.Length; i++)
        {
            allRocks[i].SetActive(false);
        }

    }
    public void NoButtonQuitPanel()
    {
        Time.timeScale = 0;
        PanelPused.SetActive(true);
        PanleGame.SetActive(false);
        Quit_Panel.SetActive(false);
        PanleOption.SetActive(false);
        GameObject[] allRocks = GameObject.FindGameObjectsWithTag("rocks");

        for (int i = 0; i < allRocks.Length; i++)
        {
            allRocks[i].SetActive(false);
        }
    }
    public void OptionButtonPused()
    {
        Time.timeScale = 0;
        PanelPused.SetActive(false);
        PanleGame.SetActive(false);
        PanleOption.SetActive(true);
        PanleWin.SetActive(false);
        GameObject[] allRocks = GameObject.FindGameObjectsWithTag("rocks");

        for (int i = 0; i < allRocks.Length; i++)
        {
            allRocks[i].SetActive(false);
        }
    }
    public void OptionButtonWin()
    {
        Time.timeScale = 0;
        PanelPused.SetActive(false);
        PanleGame.SetActive(false);
        PanleWin.SetActive(false);
        GameObject[] allRocks = GameObject.FindGameObjectsWithTag("rocks");

        for (int i = 0; i < allRocks.Length; i++)
        {
            allRocks[i].SetActive(false);
        }
    }
    public void FromOptionToWin()
    {
        Time.timeScale = 0;
        PanelPused.SetActive(false);
        PanleGame.SetActive(false);
        PanleOption.SetActive(false);
        PanleWin.SetActive(true);
        GameObject[] allRocks = GameObject.FindGameObjectsWithTag("rocks");

        for (int i = 0; i < allRocks.Length; i++)
        {
            allRocks[i].SetActive(false);
        }
    }
    void Create_rock()
    {
        Instantiate(rocks);
        score++;

        string CurrentScore = ((int)(score)).ToString();
        ScoreText.text = CurrentScore;
    }
    // Audio ________________________________
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
    void FixedUpdate()
    {
        if (score == finishscore)
        {
            sound.Pause();
            Time.timeScale = 0;
            PanleGame.SetActive(false);
            PanelPused.SetActive(false);
            PanleWin.SetActive(true);
            PlayerPrefs.SetString(NextLevel, "on");
            GameObject[] allRocks = GameObject.FindGameObjectsWithTag("rocks");
            for (int i = 0; i < allRocks.Length; i++)
            {
                allRocks[i].SetActive(false);
            }
            if (LoadLevelNumber == 1 | LoadLevelNumber == 6) 
            {
                PlayerPrefs.SetInt("Coin", 30);
            }
            if (LoadLevelNumber == 2 | LoadLevelNumber == 7)
            {
                PlayerPrefs.SetInt("Coin", 40);
            }
            if (LoadLevelNumber == 3 | LoadLevelNumber == 8)
            {
                PlayerPrefs.SetInt("Coin", 50);
            }
        }
        if (score == finishscore3)
        {
            sound.Pause();
            Time.timeScale = 0;
            PanleGame.SetActive(false);
            PanelPused.SetActive(false);
            PanleWin.SetActive(true);
            PlayerPrefs.SetString(NextLevel, "on");
            GameObject[] allRocks = GameObject.FindGameObjectsWithTag("rocks");
            for (int i = 0; i < allRocks.Length; i++)
            {
                allRocks[i].SetActive(false);
            }

            PlayerPrefs.SetInt("Coin", 90);
        }

        if (mnumberzofoni == 0)
        {
            zofoni_img.SetActive(true);
        }
        if (mnumbermask == 0)
        {
            mask_img.SetActive(true);
        }
    }
}
