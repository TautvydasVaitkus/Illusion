using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UnitToWinRemove : MonoBehaviour
{
    public ZombieMove zombiesToWin;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        zombiesToWin = FindObjectOfType<ZombieMove>();
        GetComponent<TextMeshProUGUI>().text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<TMPro.TextMeshProUGUI>().text = zombiesToWin.UnitsToWin.ToString();
    }
}
