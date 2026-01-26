using UnityEngine;

public class MenuUi : MonoBehaviour
{
    public GameObject menu;
    public GameObject rulesMenu;
    public GameObject player;


    private void Start()
    {
        rulesMenu.SetActive(false);
    }
    public void StartGame()
    {
        player.GetComponent<PlayerMovement>().isGameStart = true;
        menu.SetActive(false);
    }

    public void Rules()
    {
        rulesMenu.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void ExitFromRules()
    {
        rulesMenu.SetActive(false);
    }

}
