using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;
    
    void Update()
    {
        //kamera pozisyonu = player pozisyonu;
        transform.position = Player.position + offset;
    }
}
