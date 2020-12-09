using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEventBoxCollision : MonoBehaviour
{
    public BoxTriggerHolder boxHolder;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log(boxHolder.playerAnimator);
            boxHolder.playerAnimator.SetTrigger("shake");
            boxHolder.TMPEventTextList[0].SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            boxHolder.TMPEventTextList[0].SetActive(false);
        }
    }
}
