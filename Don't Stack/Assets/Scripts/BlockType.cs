using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockType : MonoBehaviour {

    public enum blockTypes {
        Erdbeere, Marshmallow, Apfel, Wurst, Stein, Feder
    }

    public blockTypes myType;

    public blockTypes type(){
        return myType;
    }

}
