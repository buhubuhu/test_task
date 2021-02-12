using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Task2Counter : MonoBehaviour
{
    [SerializeField]
    private float time = 3;

    public TextMeshProUGUI timer;

    private void OnEnable()
    {
        time = 3;
    }
    private void Update()
    {
        time -= Time.deltaTime;
        float timeLeft = Mathf.RoundToInt(time);
        timer.text = timeLeft.ToString();

        if(time <= 0)
        {
            gameObject.SetActive(false);
        }
    }

}
