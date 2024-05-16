using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMeanu : MonoBehaviour
{
    public void RestartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
