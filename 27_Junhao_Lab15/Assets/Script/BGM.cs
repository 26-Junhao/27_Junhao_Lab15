using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] AudioClipArr;
    float audioVolume = 0.5f ;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = audioVolume;
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            audioSource.Stop();
            int rand = Random.Range(0, AudioClipArr.Length);
            audioSource.PlayOneShot(AudioClipArr[rand]);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            audioVolume = audioVolume + 0.1f;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            audioVolume = audioVolume - 0.1f;
        }
    }
}
