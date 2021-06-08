using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class trya_p : MonoBehaviour
{
    public Button exit;
    public Button option;

    void Start()
    {
        exit.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("easy_p");
        });

        option.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("option_p");
        });
    }
}