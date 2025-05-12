using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hand;
    public GameObject keyistrue;
    public GameObject noEntry;
    public GameObject PartyBlock;
    public GameObject partyMusic;
    public GameObject crows;
    public bool isplayer;
    Animator animator;

    void Start()
    {
        isplayer = false;
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isplayer = true;
            hand.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isplayer = false;
            hand.SetActive(false);
            noEntry.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (keyistrue.activeInHierarchy)
        {
            if (isplayer)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hand.SetActive(false);
                    animator.enabled = true;
                    PartyBlock.SetActive(false);
                    partyMusic.SetActive(true);
                    crows.SetActive(false);
                }
            }
        }
        else //(keyistrue.activeInHierarchy == false)
        {
            if (isplayer)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hand.SetActive(false);
                    noEntry.SetActive(true);
                   
                }
            }
        }
    }
}
