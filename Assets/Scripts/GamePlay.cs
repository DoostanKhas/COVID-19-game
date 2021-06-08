using UnityEngine;

public class GamePlay : MonoBehaviour
{
    int Number = 1;
    public float Power = 50;
    public GameObject RightButton, LeftButton;
    public GameObject TikGh;
    public GameObject TikGhLosePanel;
    public GameObject TikBtb;
    public GameObject TikBtnLosePanel;
    
    public void Buttons_Button()
    {
        Number = 1;
        PlayerPrefs.SetInt("number", Number);
        TikGh.SetActive(false);
        TikGhLosePanel.SetActive(false);
        TikBtb.SetActive(true);
        TikBtnLosePanel.SetActive(true);
    }
    public void Ghiroscop_Button()
    {
        Number = 2;
        PlayerPrefs.SetInt("number", Number);
        TikBtb.SetActive(false);
        TikBtnLosePanel.SetActive(false);
        TikGh.SetActive(true);
        TikGhLosePanel.SetActive(true);
    }
    void Update()
    {
        int Number2 = PlayerPrefs.GetInt("number");
        if (Number2 == 1)
        {
            RightButton.SetActive(true);
            LeftButton.SetActive(true);
            TikBtb.SetActive(true);
            TikBtnLosePanel.SetActive(true);
            TikGh.SetActive(false);
            TikGhLosePanel.SetActive(false);
        }
        else if (Number2 == 2)
        {
            transform.position += new Vector3(Input.acceleration.x / Power, 0f,0f);
            RightButton.SetActive(false);
            LeftButton.SetActive(false);
            TikBtb.SetActive(false);
            TikBtnLosePanel.SetActive(false);
            TikGh.SetActive(true);
            TikGhLosePanel.SetActive(true);
        }
    }
}
