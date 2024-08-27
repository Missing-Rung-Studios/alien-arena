using UnityEngine;
using Creatures.Api;

namespace Creatures.impl
{
    public class Glacili : Frigidariant
    {
        
        void Start()
        {
            Speed = 1f;
            HealthScript = gameObject.AddComponent<HealthScript>();
            HealthScript.health = 25;

            // Add custom initialization logic here
        }

        // Optional: Override the Update method if custom logic is needed
        protected override void Update()
        {
            base.Update();

            // Add custom update logic here, if necessary
        }
    }
}