using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafik_för_joppesDjur
{
    public partial class Form1
    {
        private void playFetchBtn_Click(object sender, EventArgs e)
        {
            Action = "Fetch";
            DisplayListBox();
        }
        private void playFetch(string petName)
        {
            string[] InteractResponse = new string[2];
            int petIndex = Joppe.Pets.FindIndex(pet => pet.Name == petName);

            if (Joppe.Pets[petIndex].ID == 0)
            {
                InteractResponse = Joppe.Pets[petIndex].Interact(Joppe.Ball);
                if (InteractResponse[0] == "HungryDog")
                {
                    AnimalPicture.Image = Properties.Resources.hungrydog;
                }
                else if (InteractResponse[0] == "BallBroken")
                {
                    AnimalPicture.Image = Properties.Resources.brokenball;
                }
                else
                {
                    AnimalPicture.Image = Properties.Resources.dogplaying;
                }
            }
            else if (Joppe.Pets[petIndex].ID == 1)
            {
                InteractResponse = Joppe.Pets[petIndex].Interact(Joppe.Laser);
                if (InteractResponse[0] == "HungryCat")
                {
                    AnimalPicture.Image = Properties.Resources.hungrycat;

                }
                else if (InteractResponse[0] == "batterylow")
                {
                    AnimalPicture.Image = Properties.Resources.lowbattery;
                }
                else
                {
                    AnimalPicture.Image = Properties.Resources.cat_laser;
                }
            }
            AnimalPicLabel.Text = InteractResponse[1];
            AnimalPicture.Visible = true;
            AnimalPicLabel.Visible = true;
        }
    }
}
