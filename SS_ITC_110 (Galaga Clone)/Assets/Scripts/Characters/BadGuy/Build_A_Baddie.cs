using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_A_Baddie : MonoBehaviour
{
    //Put your own functions here!
    public BadGuyBrain badGuyBrain;

    private void Start()
    {
        badGuyBrain = GetComponent<BadGuyBrain>();
    }

    private void Update()
    {
        if (Vector3.Distance(this.gameObject.transform.position, badGuyBrain.player.transform.position) <= 4.0f)
        {
            DamagePlayerFromADistanceAndTeleport();
        }
    }

    public void DamagePlayerFromADistanceAndTeleport()
    {


        transform.position = transform.position + new Vector3(UnityEngine.Random.Range(-1.0f, 1.0f) * 200 * Time.deltaTime, UnityEngine.Random.Range(-1.0f, 1.0f) * 200 * Time.deltaTime, 0);
        badGuyBrain.player.GetComponent<CharacterBrain>().health--;

    }
}

