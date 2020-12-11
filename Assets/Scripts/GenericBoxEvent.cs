using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericBoxEvent : MonoBehaviour
{
    public BoxTriggerHolder boxHolder;
    public int eventNumber;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log(boxHolder.playerAnimator);
            boxHolder.TMPEventTextList[eventNumber].SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            boxHolder.TMPEventTextList[eventNumber].SetActive(false);
        }
    }
}
