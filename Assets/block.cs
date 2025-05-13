using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    [SerializeField] private Animator myBlock = null;
    [SerializeField] private bool openTrigger = false;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myBlock.Play("CloseBlock", 0, 0.0f);
                
            }

        }
    }
}