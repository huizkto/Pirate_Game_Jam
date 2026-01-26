using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    private double timer = 120f;

    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("0 s");   
    }
}
