using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private bool view = false;

    private void Start()
    {
        StartCoroutine("Coroutine");
        panel.SetActive(false);
    }

    public void OnStartButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void PanelView()
    {
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
        StartCoroutine("Coroutine");
        Application.Quit();
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(1f);
    }
}
