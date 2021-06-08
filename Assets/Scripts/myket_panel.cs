using UnityEngine;
using UnityEngine.UI;

public class myket_panel : MonoBehaviour
{
    public Button myket_Btn;
    public Button yes_Btn;
    public Button no_Btn;
    public GameObject panel;
    public Button GameInMyketForDownload;
    public GameObject PanelForDownload;
    public Button YesForDownload;
    public Button NoForDownload;

    void Start()
    {
        myket_Btn.onClick.AddListener(() =>
        {
            panel.SetActive(true);
            Time.timeScale = 0;
            yes_Btn.onClick.AddListener(() =>
            {
                string Page_In_Myket = "myket://details?id=com.Dostan_Khass.covid19_game";
                Application.OpenURL(Page_In_Myket);
                panel.SetActive(false);
                Time.timeScale = 1;
            });

            no_Btn.onClick.AddListener(() =>
            {
                panel.SetActive(false);
                Time.timeScale = 1;
            });
        });
        GameInMyketForDownload.onClick.AddListener(() =>
        {
            PanelForDownload.SetActive(true);
            Time.timeScale = 0;
            YesForDownload.onClick.AddListener(() =>
            {
                string DownloadURL = "myket://download/com.Dostan_Khass.covid19_game";
                Application.OpenURL(DownloadURL);
                PanelForDownload.SetActive(false);
                Time.timeScale = 1;
            });

            NoForDownload.onClick.AddListener(() =>
            {
                PanelForDownload.SetActive(false);
                Time.timeScale = 1;
            });
        });
    }
}
