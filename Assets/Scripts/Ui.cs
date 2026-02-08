using System.Collections;
using UnityEngine;

public class Ui : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject levelDoneMenu;
    [SerializeField] private GameObject blackScreen;
    private Animator blackScreenAnim;

    private void Start()
    {
        blackScreenAnim = blackScreen.GetComponent<Animator>();
        blackScreen.SetActive(false);
    }
    public void MainMenuButton()
    {
        levelDoneMenu.SetActive(false);
        mainMenu .SetActive(true);
        FindAnyObjectByType<Timer>().isStarted = false;

    }

    public void NextLevelButton()
    {
        StartCoroutine(NextLevelAnimation());
    }

    private IEnumerator NextLevelAnimation()
    {
        blackScreenAnim.SetBool("isButtonClick", true);
        blackScreen.SetActive(true);
        yield return new WaitForSeconds(2f);
        FindAnyObjectByType<GameManager>().levelNum += 1;
        FindAnyObjectByType<Timer>().isStarted = true;
        levelDoneMenu.SetActive(false);
        blackScreenAnim.SetBool("isButtonClick", false);
        blackScreen.SetActive(false);
    }
}
