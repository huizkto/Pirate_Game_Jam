using UnityEngine;
using TMPro;

public class SpyFound : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI spyFoundText;
    private int counter = 0;

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
        counter++;
        spyFoundText.text = "Spies Found: " + counter;
    }
}
