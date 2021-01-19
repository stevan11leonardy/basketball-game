using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    public GameObject effectObject;
    public GameContoller gc;

    private bool alreadyEnter = false;
    private bool foul = false;

    private void Start()
    {
        effectObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        Vector3 direction = transform.position - other.gameObject.transform.position;
        if (
            other.GetComponent<Ball>() != null
            && Mathf.Abs(direction.y) > Mathf.Abs(direction.x)
        )
        {
            if (direction.y < 0 && !foul && !alreadyEnter)
            {
                effectObject.SetActive(true);
                gc.addScore();
                alreadyEnter = true;
            } else
            {
                foul = true;
            }
        }
    }
}
