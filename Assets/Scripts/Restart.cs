using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void RestartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

}
