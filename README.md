# Generic-Enum-Flags

Enums have [System.Flags] attribute so there can be multiple selections in the inspector.

The method in the EnumUtilities class enables you to compare two enums of the same type and return a boolean result. The method is generic so it can compare two of any enum type.

In the project there are two example use cases.
 * DamageDealerType: This enum is used to determine the player's damage dealer type and the type that the enemy can take damage from.
 * AttackType: This is the attack type such as fire, water etc. This determines the attack type of the player and the super effective attack types against the enemy.

Demo Concept:
When you left click with the mouse, the player calls the enemy's "TakeDamage" method and you can see the result in Console. If the player's damage dealer type has any match with enemies effected by type, the result will be true and the enemy take damage (console prints "Enemy has taken damage!"). Player also sends it's attack type through the same method and the attack type is checked with enemies super effect type, if there are any matches the damage will be super effective.
