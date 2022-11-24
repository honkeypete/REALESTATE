using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCommentaries : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip interactClip;
    bool isAudioPlaying = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Interaction.Instance.CurrentTooltip != null)
        {
            if (Interaction.Instance.CurrentTooltip.gameObject == this.gameObject)
            {
                
                    if (isAudioPlaying == false)
                    {
                        audioSource.PlayOneShot(interactClip);
                        isAudioPlaying = true;
                    }
                
            }
            else
            {

                audioSource.Stop();
                isAudioPlaying = false;

            }
        }
        else
        {

            audioSource.Stop();
            isAudioPlaying = false;

        }
    }
}
