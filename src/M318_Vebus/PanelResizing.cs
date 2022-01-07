namespace M318_Vebus
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class PanelResizing
    {
        public void OpenClose(Panel panelMain, Panel panelSide1, Panel panelSide2, Panel panelSide3)
        {

            // Idee, für Methode um Panelresizen
            // Open
            panelMain.Size = new Size(916, 466);
            panelMain.Location = new Point(1, 66);

            // Close
            panelSide1.Size = new Size(0, 0);
            panelSide1.Location = new Point(941, 517);
            panelSide2.Size = new Size(0, 0);
            panelSide2.Location = new Point(985, 421);
            panelSide3.Size = new Size(0, 0);
            panelSide3.Location = new Point(985, 463);
        }
    }
}
