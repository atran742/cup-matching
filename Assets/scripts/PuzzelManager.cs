using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class PuzzelManager : MonoBehaviour
{
    //maybe fix later, sprite renderer; public void initalizefunction, take in puzzel slot 14:30 vid 

    
    
   [SerializeField] private List<PuzzelSlot> SlotPreFabs;
    [SerializeField] private Transform slotParent, pieceParent;
    [SerializeField] private PuzzelPiece piecePrefab;
    
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        var randomSet = SlotPreFabs.OrderBy(s => Random.value).Take(7).ToList();
        
        for (int i = 0; i < randomSet.Count; i++)
       {
           var spawnedSlot = Instantiate(randomSet[i], slotParent.GetChild(i).position, Quaternion.identity);
             var spawenedPiece = Instantiate(piecePrefab, pieceParent.GetChild(i).position, Quaternion.identity);
          spawenedPiece.Init(spawnedSlot);
          
       }

   }
}
