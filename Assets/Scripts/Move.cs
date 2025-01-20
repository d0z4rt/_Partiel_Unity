using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] public float speed = 1;
    public LayerMask layerOrb;

    void Update()
    {
        Vector3 deltaPosition = speed * Time.deltaTime * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.Translate(deltaPosition);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (layerOrb == 1 << other.gameObject.layer)
        {
            Destroy(other.gameObject);
            GameManager.instance.AddScore();
        }
        if (other.CompareTag("Ghost"))
        {
            GameManager.instance.Exit();
        }
    }
}
