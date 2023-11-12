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
        ClearText = GetComponentInChildren<Text>();
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        ClearText.text = time.ToString("F2");
    }
}
