using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject rocks;
    int score = 0;

    void Start()
    {
		InvokeRepeating ("Create_rock", 2f, 6.5f);
    }
    void OnGUI()
    {
    GUI.color = Color.black;
    GUILayout.Label("Score :  " + score.ToString());
    }
    void Create_rock()
    {
    Instantiate(rocks);
    score ++;
    }
}