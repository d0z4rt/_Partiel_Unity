using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0;
    public LayerMask layerOrb;

    void Update()
    {
        Vector3 deltaPosition = speed * Time.deltaTime * new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));

        transform.position += deltaPosition;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (layerOrb == 1 << other.gameObject.layer)
        {
            Destroy(other.gameObject);
            GameManager.instance.AddScore();
        }

    }
}
