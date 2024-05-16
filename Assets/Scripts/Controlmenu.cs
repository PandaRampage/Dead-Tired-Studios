using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlmenu : MonoBehaviour
{
    public void ControlButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Control");
    }
}
