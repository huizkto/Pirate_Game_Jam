using UnityEngine;
using TMPro;
using System.Collections;
using System.Threading;

public class Spy : MonoBehaviour
{
    bool isRevealed = false;
    private Animator spyAnimation;

    void Start()
    {
        spyAnimation = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        StartCoroutine(RevealSpy());
    }
    private void OnMouseDown()
    {
        if (isRevealed)
        {
            Destroy(gameObject);
            Object.FindFirstObjectByType<Timer>().timer += 10.0f;
            FindAnyObjectByType<GameManager>().countSpy1++;
        }
        else
        {
            Object.FindFirstObjectByType<Timer>().timer -= 5.0f;
        }
    }

    IEnumerator RevealSpy()
    {
        yield return new WaitForSeconds(Random.Range(5.0f,10.0f));
        spyAnimation.SetBool("isRevealed", true);
        isRevealed = true;
        yield return new WaitForSeconds(Random.Range(0.5f,1.5f));
        spyAnimation.SetBool("isRevealed", false);
        isRevealed = false;
    }
}
