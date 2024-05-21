using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallmove : MonoBehaviour
{
    public float moveSpeed = 1f;

    void Update()
    {

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    private void OnTriggerStay(Collider collision)
    {
        if (collision.GetComponent<Player>())
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("New Island");
        }
    }
}
