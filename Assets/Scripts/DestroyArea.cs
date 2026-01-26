using System.Collections;
using UnityEngine;

public class DestroyArea : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Train"))
        {
            Destroy(collision.gameObject);
        }
    }
}
