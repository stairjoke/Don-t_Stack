using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace gameJam
{
    public enum blockTypes
    {
        undefined, Erdbeere, Marshmallow, Apfel, Wurst, Chicken
    }
    public class Type : MonoBehaviour
    {

        public blockTypes myType = blockTypes.undefined;
    }
}