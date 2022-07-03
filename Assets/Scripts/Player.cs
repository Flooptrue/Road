using UnityEngine;

public class Player : MonoBehaviour
{
    private WaypointMover _mover;
    private byte          _items;

    private void Awake()
    {
        _mover = GetComponent<WaypointMover>();
    }

    public void AddItem()
    {
        _items++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Difficulty"))
        {
            _mover.MoveToStart();
        }
    }
}