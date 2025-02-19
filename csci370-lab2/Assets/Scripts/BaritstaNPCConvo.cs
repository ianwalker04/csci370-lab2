using UnityEngine;

public class NPC2 : MonoBehaviour
{
    [SerializeField] bool firstInteraction;
    [SerializeField] int repeatStartPosition;

    bool storeInteraction = false;

    public string npcName;
    public DialogueAsset dialogueAsset;

    [HideInInspector]
    public int StartPosition {
        get
        {
            if (npcName == "Carl at Cafe Supply"){
                storeInteraction = true;
            }
            if (firstInteraction)
            {
                firstInteraction = false;
                return 0;
            }
            else
            {
                if ((npcName == "Susan the Barista") && storeInteraction){
                    return 2;
                }
                else{
                return repeatStartPosition;
                }
            }
        }
    }
}
