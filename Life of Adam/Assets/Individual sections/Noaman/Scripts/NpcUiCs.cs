using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcUiCs : MonoBehaviour 
{
    [Header("Add HelpCanvas_Timer")]
    [SerializeField]
    private GameObject thingToEnable;
    [Header("Add All pickable objects here")]
    [SerializeField]
    private GameObject[] PickUps;
    [Header("Add Lightoobject door entrance")]
    [SerializeField]
    private GameObject[] HappyEntrance;
    public GameObject NpcText;
    public GameObject NpcInterActionText;
    public NpcAnimationCs npc;
    private LevelManagerCs lv;
    
	// Use this for initialization
	void Start () 
	{
        if (!thingToEnable)
        {
            thingToEnable=GameObject.FindWithTag("NpcEvent");
        }
        //NpcInterActionText = GameObject.FindWithTag("NpcInteract");
        lv= Object.FindObjectOfType<LevelManagerCs>();
        NpcText.SetActive(false);
        NpcInterActionText.SetActive(false);
        thingToEnable.SetActive(false);
        for (int i = 0; i < PickUps.Length; i++)
        {
            PickUps[i].SetActive(false);
        }
    }
	void OnTriggerEnter(Collider other)
    {
        NpcInterActionText.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            GameObject.Find("PauseHandler").SetActive(false);
            Object.FindObjectOfType<PauseCs>().OnPause();
            thingToEnable.SetActive(true);
           // NpcText.SetActive(true);
            // npc.SetInteractive();

            for (int i = 0; i < PickUps.Length; i++)
            {
                PickUps[i].SetActive(true);
            }
            NpcInterActionText.SetActive(false);
            for (int i = 0; i < HappyEntrance.Length; i++)
            {
               
                HappyEntrance[i].SetActive(false);
            }
            this.gameObject.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        NpcInterActionText.SetActive(false);
    }

}
