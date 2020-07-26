using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPos : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform transTarget;
    void Update()
    {
        transform.position = transTarget.position;
    }
}
