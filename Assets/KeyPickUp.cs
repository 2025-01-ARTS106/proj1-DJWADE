using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject keyimage;
    public GameObject keyistrue;
    public GameObject hand;
    public bool isplayer;

    void Start()
    {
        isplayer = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
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
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (isplayer)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                keyimage.SetActive(true);
                keyistrue.SetActive(true);
                hand.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}
