using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Memory
{
    class IceCard
    {
        //card image
        public Bitmap picture;
        
        public IceCard(String p)
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
                        picture = Memory.Properties.Resources.Blue_Ice;
                    }
                    break;
                case ("picture2"):
                    {
                        picture = Memory.Properties.Resources.Clear_Ice;
                    }
                    break;
                case ("picture3"):
                    {
                        picture = Memory.Properties.Resources.Dark_Glitter;
                    }
                    break;
                case ("picture4"):
                    {
                        picture = Memory.Properties.Resources.Gelidus;
                    }
                    break;
                case ("picture5"):
                    {
                        picture = Memory.Properties.Resources.Glacial_Mass;
                    }
                    break;
                case ("picture6"):
                    {
                        picture = Memory.Properties.Resources.Glare_Crust;
                    }
                    break;
                case ("picture7"):
                    {
                        picture = Memory.Properties.Resources.Krystallos;
                    }
                    break;
                case ("picture8"):
                    {
                        picture = Memory.Properties.Resources.Strontium;
                    }
                    break;
                case ("picture9"):
                    {
                        picture = Memory.Properties.Resources.White_Glaze;
                    }
                    break;
                                    
            }
        }
    }
}
