using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class healthWatcher : MonoBehaviour
{
    public CharacterBrain characterBrain;
    public TextMeshProUGUI healthText;

    void Update()
    {
        healthText.text = "Health: "+ characterBrain.health.ToString();
    }
}
