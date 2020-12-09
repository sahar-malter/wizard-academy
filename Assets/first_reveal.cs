using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first_reveal : MonoBehaviour
{
    public List<GameObject> cieling_disappear;
    public ParticleSystem falling_rocks;
    public Animator cam_anim;
    private bool has_shaked;
    // Start is called before the first frame update
    void Start()
    {
        has_shaked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!has_shaked && other.CompareTag("Player"))
        {
            has_shaked = true;
            falling_rocks.Play();
            cam_anim.SetTrigger("shake");
            for (int i = 0; i < cieling_disappear.Count; i++)
            {
                cieling_disappear[i].SetActive(false);

            }

        }
    }

}
