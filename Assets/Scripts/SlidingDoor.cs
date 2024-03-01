using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : MonoBehaviour
{

    // private bool isOpen = false;
    // [Header("Sliding Config")]
    // [SerializeField]
    // private Vector3 slideDirection = Vector3.back;
    // [SerializeField]
    // private float slideAmount = 1.9f;
    //
    // private Vector3 startPosition;

    public Animator slidingDoorAnim;
    // private Collider doorCollider;

    // Start is called before the first frame update
    void Start()
    {
        // doorCollider = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            slidingDoorAnim.SetTrigger("open");
            Debug.Log("Door Open");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            slidingDoorAnim.SetTrigger("close");
            Debug.Log("Door Closed");
        }
        
    }
}
