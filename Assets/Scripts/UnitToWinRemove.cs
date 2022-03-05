using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitToWinRemove : MonoBehaviour
{
    public ZombieMove zombiesToWin;

    // Start is called before the first frame update
    void Start()
    {
        zombiesToWin = FindObjectOfType<ZombieMove>();
        GetComponent<TextMesh>().text = "5";
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<TMPro.TextMeshProUGUI>().text = zombiesToWin.UnitsToWin.ToString();
    }
}
