using UnityEngine;
using System.Collections;

public class rotator6 : MonoBehaviour
{
    void Update()
    {
        GetComponent<Rigidbody>().transform.Rotate(0.1f, 0.0f, 0.0f, Space.Self);
    }
}