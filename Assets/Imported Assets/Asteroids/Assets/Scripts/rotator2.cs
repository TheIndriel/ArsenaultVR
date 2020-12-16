using UnityEngine;
using System.Collections;

public class rotator2 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Rigidbody>().transform.Rotate(0.0f, 0.25f, 0.0f, Space.Self);
    }
}