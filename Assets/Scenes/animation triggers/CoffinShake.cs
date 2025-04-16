using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffinShake : MonoBehaviour
{
    [SerializeField] private Animator myCoffin = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;
    [Header("Audio")]
    [SerializeField] private AudioSource coffinKnock = null;
    [SerializeField] private float knockDelay = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myCoffin.Play("coffinShake", 0, 0.0f);
                gameObject.SetActive(false);
                coffinKnock.PlayDelayed(knockDelay);
            }
            else if (closeTrigger)
            {
                myCoffin.Play("idle", 0, 0.0f);
                gameObject.SetActive(false);
            }

        }
    }
}
