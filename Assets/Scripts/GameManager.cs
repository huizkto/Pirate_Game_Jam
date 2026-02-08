using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int levelNum;
    [HideInInspector]public int countSpy1;
    [SerializeField] private GameObject characters;
    [SerializeField] private GameObject characters2;
    [SerializeField] private GameObject characters3;
    [SerializeField] private GameObject levelCompleteMenu;
    [SerializeField] private GameObject endScreen;


    void Start()
    {
        endScreen.SetActive(false);
        levelCompleteMenu.SetActive(false);
        characters.SetActive(false);
        characters2.SetActive(false);
        characters3.SetActive(false);
        countSpy1 = 0;

    }
    private void Update()
    {
        if (levelNum == 1)
        {
            characters.SetActive(true);
        }
        else if (levelNum == 2)
        {
            FindAnyObjectByType<PlayerMovement>().isGameStart = true;
            characters.SetActive(false);
            characters2.SetActive(true);
        }
        else if (levelNum == 3)
        {
            FindAnyObjectByType<PlayerMovement>().isGameStart = true;
            characters2.SetActive(false);
            characters3.SetActive(true);
        }
        else
        {
            characters.SetActive(false);
            characters2.SetActive(false);
            characters3.SetActive(false);
        }

        if ((countSpy1 == 4 && levelNum == 1) || (countSpy1 == 8 && levelNum == 2))
        {
            levelCompleteMenu.SetActive(true);
            FindAnyObjectByType<PlayerMovement>().isGameStart = false;
            FindAnyObjectByType<Timer>().isStarted = false;
            countSpy1 = 0;
        }
        else if (countSpy1 == 2 && levelNum == 3)
        {
            endScreen.SetActive(true);
            FindAnyObjectByType<PlayerMovement>().isGameStart = false;
        }

        
    }
}
