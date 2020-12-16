using UnityEngine;
using System.Collections;

public class rotator4 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Rigidbody>().transform.Rotate(0.0f, 0.1f, 0.0f, Space.Self);
    }
}