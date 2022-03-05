using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeLeft;
    public int unit;
    public GameObject unitCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(unit>=0)
    //sdfhkl
    unitCount.GetComponent<UnitToWinRemove>().count=unit;
        this.GetComponent<TextMeshProUGUI>().text = ((int)timeLeft).ToString();
        if(timeLeft > 0)
        timeLeft -= Time.deltaTime;
    }
}
