using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Enemy enemy;
    [SerializeField] DamageDealerType damageDealerType;
    [SerializeField] AttackType attackType;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            enemy.TakeDamage(damageDealerType, attackType);
        }
    }
}
