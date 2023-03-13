using UnityEngine;

public class InicialForceRandomizer : MonoBehaviour
{
    [SerializeField][Range(0f, 5f)] float forceStartingNudge = 1f;

    void Start()
    {
        //Nudges the ball at the start in a random direction defined by a force
        GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-forceStartingNudge * 100, forceStartingNudge * 100), 0f));
    }
}
