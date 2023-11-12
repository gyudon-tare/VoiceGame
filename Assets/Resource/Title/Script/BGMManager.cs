using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    AudioManager soundManager;
    [SerializeField]AudioClip bgm;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = FindObjectOfType<AudioManager>();
        soundManager.PlayBgm(bgm);
    }
}
