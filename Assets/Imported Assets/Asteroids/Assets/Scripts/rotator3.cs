using UnityEngine;
using System.Collections;

public class rotator3 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Rigidbody>().transform.Rotate(0.0f, 0.15f, 0.0f, Space.Self);
    }
}