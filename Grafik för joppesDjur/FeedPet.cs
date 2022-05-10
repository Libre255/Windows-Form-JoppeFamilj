using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafik_för_joppesDjur
{
    public partial class Form1
    {
        private void FeedPetBtn_Click(object sender, EventArgs e)
        {
            Action = "Feed";
            DisplayListBox();
            textBox1.Text = null;
        }
        private void FeedMyPet(string petName)
        {
            string[] InteractResponse = new string[2];
            petIndex = Joppe.Pets.FindIndex(pet => pet.Name == petName);

            if (Joppe.Pets[petIndex].Hungry)
            {
                AnimalPicLabel.Text = $"Insert {Joppe.Pets[petIndex].Name} favorite food and press enter";
                AnimalPicLabel.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                AnimalPicLabel.Text = "The pet is full";
                AnimalPicLabel.Visible = true;
                if (Joppe.Pets[petIndex].ID == 0)
                {
                    AnimalPicture.Image = Properties.Resources.dog_eat;
                }
                else
                {
                    AnimalPicture.Image = Properties.Resources.cateating;
                }
                AnimalPicture.Visible = true;
            }
        }
        private void textBox1KeyDown(object sender, KeyEventArgs e)
        {
            var pet = Joppe.Pets[petIndex];
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == pet.Fav_Food)
                {
                    string response = Joppe.Pets[petIndex].eat(textBox1.Text.ToLower());
                    textBox1.Visible = false;
                    AnimalPicLabel.Text = response;
                    if (pet.ID == 0)
                    {
                        AnimalPicture.Image = Properties.Resources.dog_eat;
                    }
                    else
                    {
                        AnimalPicture.Image = Properties.Resources.cateating;
                    }
                    AnimalPicture.Visible = true;
                    
                }
                else
                {
                    MessageBox.Show($"That's not {pet.Name} favorite food, try again.");
                }
            }

        }
    }
}
