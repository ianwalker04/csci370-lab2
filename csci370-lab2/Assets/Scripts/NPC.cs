using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] bool firstInteraction;
    [SerializeField] int repeatStartPosition;


    [SerializeField] public string npcName;

    [SerializeField] public bool Carl;
    [SerializeField] public bool Susan;
    public DialogueAsset dialogueAsset;

    [HideInInspector]
    public int StartPosition {
        get
        {  RaycastHit2D hit = Physics2D.CircleCast(transform.position, 2, Vector2.up, 0, LayerMask.GetMask("Player"));
            if (hit){
                if(hit.collider.gameObject.TryGetComponent(out PlayerConvo player));
                if (Susan && player.storeInteraction){
                    return 0;
                }
            }
            if (Susan) {
                return 1;
                }
            if (firstInteraction)
            {
                firstInteraction = false;
                return 0;
            }
            else
            {
                return repeatStartPosition;
            }
        }
    }
}

