using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGateController1 : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    [Header("Audio")]
    [SerializeField] private AudioSource doorOpenAudioSource = null;
    [SerializeField] private float openDelay = 0;
    [Space(10)]
    [SerializeField] private AudioSource doorCloseAudioSource = null;
    [SerializeField] private float closeDelay = 0.8f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myDoor.Play("Gate1Open", 0, 0.0f);
                gameObject.SetActive(false);
                doorOpenAudioSource.PlayDelayed(openDelay);
            }
            else if (closeTrigger)
            {
                myDoor.Play("Gate1Close", 0, 0.0f);
                gameObject.SetActive(false);
                doorCloseAudioSource.PlayDelayed(closeDelay);
            }
        }

    }

}
