using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private AudioClip button;
    [SerializeField] private GameObject panel;
    AudioManager audio;
    private bool view = false;

    private void Start()
    {
        panel.SetActive(false);
        audio = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    public void OnStartButton()
    {
        
        audio.PlaySe(button);
        StartCoroutine("Coroutine");
        SceneManager.LoadScene("MainScene");
    }

    public void PanelView()
    {
        audio.PlaySe(button);
        if (view)
        {
            view = false;
        }
        else
        {
            view = true;
        }
        panel.SetActive(view);
    }

    public void OnExitButton()
    {
        audio.PlaySe(button);
        StartCoroutine("Coroutine");
        Application.Quit();
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(1f);
    }
}
