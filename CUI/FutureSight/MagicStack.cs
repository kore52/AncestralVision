using System;
using System.Collections;
using System.Collections.Generic;

namespace FutureSight
{
    [Serializable()]
    public class MagicStack : LinkedList<IStackItem>
    {
        public bool IsEmpty()
        {
            return Count == 0;
        }
    }
}