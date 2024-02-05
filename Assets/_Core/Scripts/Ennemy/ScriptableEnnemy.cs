using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableEnnemy), menuName = "ScriptableObject/Ennemy")]
public class ScriptableEnnemy : ScriptableObject
{
    public int EnnemyDamage => _ennemyDamage;
    
    [SerializeField] private int _ennemyDamage;
}
