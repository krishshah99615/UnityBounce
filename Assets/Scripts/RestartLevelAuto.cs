using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelAuto : MonoBehaviour
{

    // Update is called once per frame
    [SerializeField] string s;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == s)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

    }
}
