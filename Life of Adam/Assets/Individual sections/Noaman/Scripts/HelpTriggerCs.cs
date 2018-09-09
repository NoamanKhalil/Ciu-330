using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpTriggerCs : MonoBehaviour
{
	[SerializeField]
	private GameObject thingToEnable;
    [SerializeField]
    private GameObject PauseThing;

	// Use this for initialization
	void Start ()
	{
		thingToEnable.SetActive(false);
	}

	void OnTriggerEnter(Collider other)
	{
        PauseThing.SetActive(false);
		Time.timeScale = 0; 
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		thingToEnable.SetActive(true);
		this.gameObject.SetActive(false);
	}



}
