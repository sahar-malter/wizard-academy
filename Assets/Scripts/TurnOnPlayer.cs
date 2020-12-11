using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnPlayer : MonoBehaviour
{
    PlayerMovement player;
    MouseLook mouseLook;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlayerMovement>();
        mouseLook = GetComponentInChildren<MouseLook>();
        StartCoroutine(PlayerControlDelay());
    }

    // Update is called once per frame
    IEnumerator PlayerControlDelay()
    {
        yield return new WaitForSeconds(5);
        player.enabled = true;
        mouseLook.enabled = true;
    }
}
