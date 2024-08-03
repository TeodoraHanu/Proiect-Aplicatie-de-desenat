using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Aplicatie_de_desenat
{
    internal class Player : Butoane
    {
        private string name;
        private InstrumentDesen selectedDrawingTool;

          public Player(string numeJucator) : base()
          {
              name = numeJucator;
              selectedDrawingTool = InstrumentDesen.Creion;
          }

        public void SetSelectedDrawingTool(InstrumentDesen instrument)
        {
            selectedDrawingTool = instrument;
        }

        public override void creion_Click()
        {
            SetSelectedDrawingTool(InstrumentDesen.Creion);
            base.creion_Click();
        }

        public override void Pensula_Click()
        {
            SetSelectedDrawingTool(InstrumentDesen.Pensula);
            base.Pensula_Click();
        }

        public enum InstrumentDesen
        {
            Creion,
            Pensula
        }

    }
}