using UnityEngine;

public class goalTouch : MonoBehaviour
{
    public playerMove move;
    void OnCollisionEnter (Collision c)
    {
        if(c.collider.tag == "Goal")
        {
            move.enabled = false;
            Debug.Log("You Win");
        }
    }
}
