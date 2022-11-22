using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCommentaries : MonoBehaviour
{
    [SerializeField] public AudioSource audioSource { get; private set; }
    public AudioClip interactClip;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Interaction.Instance.CurrentTooltip.TryGetComponent(out AudioSource audioSource) == true)
        {
            audioSource.PlayOneShot(interactClip);
        }
    }
}
