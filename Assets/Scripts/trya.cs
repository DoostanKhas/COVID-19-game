using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class trya : MonoBehaviour
{
    public Button exit;
    public Button option;

    void Start()
    {
        exit.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("esygame_E");
        });

        option.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("option_E");
        });
    }
}
