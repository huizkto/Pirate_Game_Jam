using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    [SerializeField] private float speed = 70f;
    [SerializeField] private GameObject train;
    Rigidbody2D trainRb;
    
    private void Start()
    {
        trainRb = train.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (trainRb == null)
            return;
        else
            trainRb.MovePosition(trainRb.position + Vector2.left * Time.deltaTime * speed);    

    }

}
