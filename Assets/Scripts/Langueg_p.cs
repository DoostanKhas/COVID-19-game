using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Langueg_p : MonoBehaviour
{
    public Button parsian;
    public Button English;

    void Start()
    {
        parsian.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("menue_p");
        });

        English.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("menue_E");
        });
    }
}
