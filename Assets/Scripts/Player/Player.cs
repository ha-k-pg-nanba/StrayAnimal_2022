using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void MoveUp()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f);
    }
    public void MoveDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.05f);
    }
    public void MoveLeft()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f);
    }
    public void MoveRight()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f);
    }
}
