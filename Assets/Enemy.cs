using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] DamageDealerType effectedByType;
    [SerializeField] AttackType superEffectiveAttackType;

    public void TakeDamage(DamageDealerType damageDealerType, AttackType recievedAttackType)
    {
        if (!EnumUtilities.CompareEnums(effectedByType, damageDealerType)) return;

        Debug.Log("Enemy took damage");

        if (EnumUtilities.CompareEnums(superEffectiveAttackType, recievedAttackType))
        {
            Debug.Log("Attack was Super Effective!");
        }
    }
}
