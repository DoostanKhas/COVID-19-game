using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    public float range = 0;

    void Start()
    {
        transform.position = new Vector3( 3 - range * Random.value , speed, 0); 
    }
    void Update()
    {
        transform.position += new Vector3( 0 , -speed, 0) * Time.deltaTime;
    }
}