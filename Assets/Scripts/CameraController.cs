using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector2 offset;
    [SerializeField] private Camera playerCamera;

    void Update()
    {
        if(player.transform.position.x > - 8.85f && player.transform.position.x < 8.85)
        {
            playerCamera.transform.position = new Vector3(player.transform.position.x + offset.x,player.transform.position.y + offset.y,playerCamera.transform.position.z);
        }
        
    }
}
