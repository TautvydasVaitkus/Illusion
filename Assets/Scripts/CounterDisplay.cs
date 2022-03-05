using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterDisplay : MonoBehaviour
{
    public GameObject spawner;
    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = spawner.GetComponent<Spawner>().SpawnCounter.ToString();
    }
}
