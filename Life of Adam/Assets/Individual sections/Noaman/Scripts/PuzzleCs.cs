using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PuzzleCs : MonoBehaviour
{
    [Header("Add the cube to of the shape slot to enable")]
    [SerializeField]
	private GameObject shapeSlot;
    public float sphereRadius;
    public LayerMask layer;
    [SerializeField]
    private float Dist;
    [Header("Add the cube to of the corresponding name, shape to pick")]
    [SerializeField]
    private GameObject otherObj;

    [SerializeField]
    private GameObject player;

    private AudioSource aud;

    public bool isBlue;
	public bool isRed;
    public bool isGreen;
    // Use this for initialization
    void Start ()
    {
        if (!player)
        {
            player = GameObject.Find("Player");
        }
        shapeSlot.SetActive(false);
        aud = GetComponent<AudioSource>();
	}
	// Update is called once per frame
	void Update ()
    {
		if (Vector3.Distance(this.transform.position, player.transform.position) <= Dist)
		{
			//Debug.Log("set can drop is working ");
			//Debug.Log(Vector3.Distance(this.transform.position, player.transform.position));
			player.GetComponent<PickUpCs>().setCanDrop(true);
		}
		else if (Vector3.Distance(this.transform.position, player.transform.position) >= Dist)
		{ 
			player.GetComponent<PickUpCs>().setCanDrop(false);
		}
    }

	public void setSlotActive()
	{
		shapeSlot.SetActive(true);
        aud.Play();
	}


	public void Reset()
	{
		shapeSlot.SetActive(false);
		otherObj.SetActive(true);
		otherObj.GetComponent<objectHandlerCs>().Reset();
	}
    /*void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, sphereRadius);
    }*/
}
