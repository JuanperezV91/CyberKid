using UnityEngine;
using System.Collections.Generic;

///<summary>
/// Sort card position, it garantees cards will always be
/// in a diferente position in Start method, once
///</summary>
public class SortPosition : MonoBehaviour
{
	[Header("Cards, drop theem here")]
	public TouchCard[] card;
	[Header("Autodestroy this object after sorting cards?")]
	public bool autodestroy;
	//list of cards positions
    private List<Vector2> positions = new List<Vector2>();
	//size of the list
    private int listSize;
	//list index
    private int index;
	//position to rand
    private Vector2 randPosition;
	//check to autodestroy this object after processing sorting
    private int check;
	//search cards automatically
	public bool searchCardsAutomatically;

    void Awake()
    {
		if(searchCardsAutomatically)
			card = FindObjectsOfType<TouchCard>();
		//get list size
        listSize = card.Length;

		//store list itens
        for (int i = 0; i < listSize; i++)
        {
            if (card[i] != null)
            {
                positions.Add(card[i].transform.position);
            }
        }
    }

    void Start()
    {
		//sort the cards
        for (int i = 0; i < listSize; i++)
        {
            index = Random.Range(0, positions.Count - 1);
            randPosition = positions[index];
            card[i].transform.position = randPosition;
            positions.RemoveAt(index);
            check = i;
        }

		//increment card
        if (check == listSize - 1)
        {
            check++;
        }

		//if so and autodestroy bool is checked, autodestroy this object
        if (check >= listSize)
        {
			if(autodestroy)
				Destroy(gameObject, 0.5f);
        }
    }
}
