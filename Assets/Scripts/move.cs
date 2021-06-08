using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public Button Left;
    public Button Right;
    public int playerSpeed = 4;
    
    void Start()
    {
        Left.onClick.AddListener(() =>
        {
            transform.Translate(new Vector2(-playerSpeed * Time.deltaTime, 0));
        });

        Right.onClick.AddListener(() =>
        {
            transform.Translate(new Vector2(playerSpeed * Time.deltaTime, 0));
        });
    }
}
