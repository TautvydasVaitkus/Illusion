using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private AudioSource source;
    public float minWaitBetweenPlays = 3f;
    public float maxWaitBetweenPlays = 7f;
    public float waitTimeCountdown = -1f;
    public GameObject timer;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer.GetComponent<Timer>().timeLeft <= 0)
        {
            if (!source.isPlaying)
            {
                if (waitTimeCountdown < 0f)
                {
                    source.Play();
                    waitTimeCountdown = Random.Range(minWaitBetweenPlays, maxWaitBetweenPlays);
                }
                else
                {
                    waitTimeCountdown -= Time.deltaTime;
                }
            }
        }
    }

    IEnumerator wait()
    {
            yield return new WaitForSecondsRealtime(1f);
    }
}
