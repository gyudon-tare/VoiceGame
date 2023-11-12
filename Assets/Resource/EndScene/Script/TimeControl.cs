using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    public float time;
    public Text ClearText;

    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
        StartCoroutine(DelayCoroutine());
    }

    private IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(3);
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        ClearText.text = time.ToString("F2");
    }
}
