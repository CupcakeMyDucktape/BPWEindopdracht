using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceScript : MonoBehaviour {

    public AudioClip Goal;
    public AudioClip Loadlevelclip;

    public AudioSource GoalSound;

    private void Start()
    {
        GoalSound.clip = Loadlevelclip;
        GoalSound.Play();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "GoalLine")
        {
            GoalSound.clip = Goal;
            GoalSound.Play();

        }
    }
}
