using UnityEngine;
using UnityEngine.UI;

public class Load_Level : MonoBehaviour
{
    public GameObject Lock_1, Lock_2, Lock_3 , Lock_4;
    public Button Level_1;
    public Button Level_2;
    public Button Level_3;
    public Button Level_4;

    void Update()
    {
        Lock_1.SetActive(false);
        Lock_2.SetActive(true);
        Lock_3.SetActive(true);
        Lock_4.SetActive(true);
        PlayerPrefs.SetString("1", "on");

        if (PlayerPrefs.GetString("2") == "on")
        {
            Lock_2.SetActive(false);
        }
        if (PlayerPrefs.GetString("3") == "on")
        {
            Lock_3.SetActive(false);
        }
        if (PlayerPrefs.GetString("4") == "on")
        {
            Lock_4.SetActive(false);
        }
    }
}
