using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMeanu : MonoBehaviour
{
    public void Return()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start");
    }
}
