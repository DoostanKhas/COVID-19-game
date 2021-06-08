using UnityEngine;

public class Rotate_Loading_Image : MonoBehaviour
{
    void Awake()
    {
        transform.Rotate(Vector3.forward * 6.0f);
    }
}