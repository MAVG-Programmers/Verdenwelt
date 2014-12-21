using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Verdenwelt.Client
{
    public abstract class Entity
    {
        public List<IComponent> Components { get; set; }

        public void AddComponent(IComponent component) 
        {
            
            //Add component to component list and do all the inter-component linking
             
        }
    }
}
