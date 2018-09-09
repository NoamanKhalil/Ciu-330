using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerCs : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject buttons;
    public float mainTimer;
    public float goodTimer;
    public float badTimer;
    [Header("Give T Area name post-tutorial t area")]
    public string levelName;
    [SerializeField]
    bool SceneA;
    [SerializeField]
    bool SceneB;

	// Use this for initialization
	void Start ()
    {
        SceneA = false;
        SceneB = false;
        Debug.Log("GM StartCalled");
    }
	
	// Update is called once per frame
	void Update ()
    {
       // Debug.Log("GM Update called");
        mainTimer -= Time.deltaTime;
        Debug.Log(mainTimer);
        //Debug.Log(timer);
        if (mainTimer <=0)
        {
            //videoPlayer.Pause();
            Debug.Log("OptionEnabled");
            buttons.SetActive(true);
        }
        if (SceneA)
        {
            Debug.Log("SceneA");
            goodTimer -= Time.deltaTime;
            mainTimer = 10;
            if (goodTimer <= 0)
            {
            
                SceneManager.LoadScene(levelName);
            }
        }
        if (SceneB)
        {
            Debug.Log("SceneB");
            badTimer -= Time.deltaTime;
            mainTimer = 10;
            if (badTimer <= 0)
            {
                SceneManager.LoadScene(levelName);
            }
        }

    }


    public void SceneAActive()
    {
        buttons.SetActive(false);
        SceneA = true;
        mainTimer = 10.0f;
        videoPlayer.Play();
    }
    public void SceneBActive()
    {
        buttons.SetActive(false);
        SceneB = true;
        mainTimer = 10.0f;
        videoPlayer.Play();
    }
}
