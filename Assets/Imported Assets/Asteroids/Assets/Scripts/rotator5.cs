using UnityEngine;
using System.Collections;

public class rotator5 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Rigidbody>().transform.Rotate(0.0f, 0.05f, 0.0f, Space.Self);
    }
}