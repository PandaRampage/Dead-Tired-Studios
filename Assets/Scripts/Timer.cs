using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI tText;
    float rTime = 60;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rTime -= Time.deltaTime;
	int min = Mathf.FloorToInt(rTime / 60);
	int sec = Mathf.FloorToInt(rTime % 60);
	tText.text = string.Format("{0:00}:{1:00}", min, sec);
	if (rTime <= 0)
	{
	    UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
	}
    }
}
