using UnityEngine;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Crafting/Recipe")]
public class RecipeSO : ScriptableObject
{
    public string recipeName;
    public ItemSO[] ingredients;  // Lista de ingredientes necess�rios
    public ItemSO resultItem;     // Item que � o resultado da receita
}