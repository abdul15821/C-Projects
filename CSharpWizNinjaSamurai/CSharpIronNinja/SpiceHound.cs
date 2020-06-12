using System;

namespace Hungry_Ninja
{
    class SpiceHound: Ninja
    {
        public override bool IsFull{
            get
            {
                if(calorieIntake >= 1200)
                {
                    return true;
                }
                    return false;
                }
            }
        public override void Consume(IConsumable item)
            {

            }

            
        }

    }
