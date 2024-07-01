using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorFunctions : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonController;
    public bool disableOnce;

    void PlaySound(AudioClip whichSound)
    {
        if (whichSound == null)
        {
            Debug.LogWarning("PlaySound was called with a null AudioClip.");
            return;
        }
        if (!disableOnce)
        {
            menuButtonController.audioSource.PlayOneShot(whichSound);
        }
        else
        {
            disableOnce = false;
        }
    }
}
