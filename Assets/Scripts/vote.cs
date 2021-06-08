using UnityEngine;
using UnityEngine.UI;

public class vote : MonoBehaviour
{
    public Button Vote_Btn;
    public Button Yes_Btn;
    public Button No_Btn;
    public GameObject Panel;
    public Button Vote_Btn_In_Store;
    public Button Yes_Btn_In_Store;
    public Button No_Btn_In_Store;
    public GameObject Panel_In_Store;
    public Button Vote_Btn_In_About_US;
    public Button Yes_Btn_In_About_US;
    public Button No_Btn_In_About_US;
    public GameObject Panel_In_About_US;

    void Start()
    {
        Vote_Btn.onClick.AddListener(() =>
        {
            Panel.SetActive(true);
            Time.timeScale = 0;

            Yes_Btn.onClick.AddListener(() =>
            {
                string VoteInMyket = "myket://comment?id=com.Dostan_Khass.covid19_game";
                Application.OpenURL(VoteInMyket);
                Panel.SetActive(false);
                Time.timeScale = 1;
            });

            No_Btn.onClick.AddListener(() =>
            {
                Panel.SetActive(false);
                Time.timeScale = 1;
            });
        });
        //---------------------Vote_In_About_Us------------------------
        Vote_Btn_In_About_US.onClick.AddListener(() =>
        {
            Panel_In_About_US.SetActive(true);
            Time.timeScale = 0;

            Yes_Btn_In_About_US.onClick.AddListener(() =>
            {
                string VoteInMyket = "myket://comment?id=com.Dostan_Khass.covid19_game";
                Application.OpenURL(VoteInMyket);
                Panel_In_About_US.SetActive(false);
                Time.timeScale = 1;
            });

            No_Btn_In_About_US.onClick.AddListener(() =>
            {
                Panel_In_About_US.SetActive(false);
                Time.timeScale = 1;
            });
        });
        //-------------------------Vote_In_Store---------------------------
        Vote_Btn_In_Store.onClick.AddListener(() =>
        {
            Panel_In_Store.SetActive(true);
            Time.timeScale = 0;

            Yes_Btn_In_Store.onClick.AddListener(() =>
            {
                string VoteInMyket = "myket://comment?id=com.Dostan_Khass.covid19_game";
                Application.OpenURL(VoteInMyket);
                Panel_In_Store.SetActive(false);
                Time.timeScale = 1;
            });

            No_Btn_In_Store.onClick.AddListener(() =>
            {
                Panel_In_Store.SetActive(false);
                Time.timeScale = 1;
            });
        });
    }
}
