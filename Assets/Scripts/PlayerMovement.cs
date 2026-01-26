using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public bool isGameStart = false;
    void FixedUpdate()
    {
        if(isGameStart == true)
        {
            float horizontal = Input.GetAxis("Horizontal");

            Vector2 movement = new Vector2(horizontal, 0f);

            if (movement != Vector2.zero)
            {
                transform.Translate(movement * speed * Time.deltaTime);
            }
        }
        else
        {
            // Do nothing if the game hasn't started
        }

    }
}
