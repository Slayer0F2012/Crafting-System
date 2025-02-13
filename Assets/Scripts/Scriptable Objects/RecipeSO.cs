using UnityEngine;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Crafting/Recipe")]
public class RecipeSO : ScriptableObject
{
    public string recipeName;
    public ItemSO[] ingredients;  // Lista de ingredientes necessários
    public ItemSO resultItem;     // Item que é o resultado da receita
}