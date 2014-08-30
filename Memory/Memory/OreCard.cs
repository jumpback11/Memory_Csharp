using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Memory
{
    class OreCard
    {
        //card image
        public Bitmap picture;
        
        public OreCard(String p)
        {
            Initialize(p);
        }
        public void Initialize(String p)
        {
            
            //set card flip image
            switch (p)
            {
                case ("picture1"):
                    {
                        picture = Memory.Properties.Resources.Arkonor;
                    }
                    break;
                case ("picture2"):
                    {
                        picture = Memory.Properties.Resources.Bistot;
                    }
                    break;
                case ("picture3"):
                    {
                        picture = Memory.Properties.Resources.Crokite;
                    }
                    break;
                case ("picture4"):
                    {
                        picture = Memory.Properties.Resources.Dark_Ochre;
                    }
                    break;
                case ("picture5"):
                    {
                        picture = Memory.Properties.Resources.Gneiss;
                    }
                    break;
                case ("picture6"):
                    {
                        picture = Memory.Properties.Resources.Hedbergite;
                    }
                    break;
                case ("picture7"):
                    {
                        picture = Memory.Properties.Resources.Hemorphite;
                    }
                    break;
                case ("picture8"):
                    {
                        picture = Memory.Properties.Resources.Jaspet;
                    }
                    break;
                case ("picture9"):
                    {
                        picture = Memory.Properties.Resources.Kernite;
                    }
                    break;
                                    
            }
        }
    }
}
