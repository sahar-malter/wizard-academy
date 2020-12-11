using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTriggerHolder : MonoBehaviour
{
    public List<GameObject> eventBoxes = new List<GameObject>();
    public List<GameObject> TMPEventTextList = new List<GameObject>();
    public Animator playerAnimator;
    public void Start()
    {
        StartCoroutine(RumbleDelay());
    }
    // Start is called before the first frame update
    IEnumerator RumbleDelay()
    {
        yield return new WaitForSeconds(10f);
        eventBoxes[0].SetActive(true);
    }
}
