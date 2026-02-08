using UnityEngine;

public class Character : MonoBehaviour
{
    private void OnMouseDown()
    {
        Object.FindFirstObjectByType<Timer>().timer -= 5.0f;
    }
}
