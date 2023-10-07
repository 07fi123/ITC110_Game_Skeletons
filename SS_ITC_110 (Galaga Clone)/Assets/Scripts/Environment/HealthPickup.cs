using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPickup : MonoBehaviour


{
    public CharacterBrain characterBrain;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            characterBrain.health += 10;
            Destroy(this.gameObject);

        }
      
    }
}
