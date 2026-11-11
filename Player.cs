using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(KeyInventory))]
public class Player : MonoBehaviour
{
    [Header("References")]
    [SerializeField] KeyInventory keyInventory;

    public float HP = 100f;
    

    void Awake()
    {
        if (keyInventory == null)
        {
            keyInventory = GetComponent<keyInventory>();
        }
    }
}
