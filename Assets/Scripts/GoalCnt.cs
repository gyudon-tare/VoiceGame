using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalCnt : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Coroutine");
        SceneManager.LoadScene("EndScene");
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(0.5f); 
    }

}
