using JoppesDjurFamilj;
namespace Grafik_för_joppesDjur
{
    public partial class Form1 : Form
    {
        string Action = "Neutral";
        int petIndex;
        PetOwner Joppe = new PetOwner();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string pet in Joppe.petsNames)
            {
                listBox1.Items.Add(pet);
            }
            listView1.Columns.Add("Name", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Age", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Favorite food", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Breed", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Hungry", 100, HorizontalAlignment.Center);

            
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            if(listBox1.SelectedItem != null)
            {
                string SelectedPet = listBox1.SelectedItem.ToString();
                switch (Action)
                {
                    case "Fetch":
                        playFetch(SelectedPet);
                        break;
                    case "Feed":
                        FeedMyPet(SelectedPet);
                        break;
                }
                
            }
        }
        private void DisplayListBox()
        {
            listBox1.Visible = true;
            AnimalPicLabel.Visible = false;
            AnimalPicture.Visible = false;
            textBox1.Visible=false;
            listView1.Visible=false;
            Checkstatus.Visible = false;
        }
        private void ListAnimalsBtn_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            AnimalPicLabel.Visible = false;
            AnimalPicture.Visible = false;
            textBox1.Visible = false;
            listView1.Visible = true;
            Checkstatus.Visible = false;
            listView1.Items.Clear();

            foreach (var pet in Joppe.Pets)
            {
                addToListView(pet.Name, pet.Age, pet.Fav_Food, pet.Breed, pet.Hungry);
            }
        }

        private void PrintAnimals_Click(object sender, EventArgs e)
        {
            Checkstatus.Visible = false;
            listBox1.Visible = false;
            AnimalPicLabel.Visible = false;
            AnimalPicture.Visible = false;
            textBox1.Visible = false;
            listView1.Visible = false;
            MessageBox.Show(Joppe.Print_Out_Animals());
        }

        private void CheckBallStatus_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            AnimalPicLabel.Visible = false;
            AnimalPicture.Visible = false;
            textBox1.Visible = false;
            listView1.Visible = false;
            Checkstatus.Visible = true;

            Checkstatus.Text = Joppe.Check_Ball();
        }

        private void CheckLaserStatus_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            AnimalPicLabel.Visible = false;
            AnimalPicture.Visible = false;
            textBox1.Visible = false;
            listView1.Visible = false;
            Checkstatus.Visible = true;

            Checkstatus.Text = Joppe.Check_Laser();
        }
        private void addToListView(string Name, int Age, string FavFood, string Breed, bool Hungry)
        {
            ListViewItem eachRow = new ListViewItem(Name);
            ListViewItem.ListViewSubItem rowAge = new ListViewItem.ListViewSubItem(eachRow, Age.ToString());
            ListViewItem.ListViewSubItem rowFavFood = new ListViewItem.ListViewSubItem(eachRow, FavFood);
            ListViewItem.ListViewSubItem rowBred = new ListViewItem.ListViewSubItem(eachRow, Breed);
            ListViewItem.ListViewSubItem rowHungry = new ListViewItem.ListViewSubItem(eachRow, Hungry.ToString());

            eachRow.SubItems.Add(rowAge);
            eachRow.SubItems.Add(rowFavFood);
            eachRow.SubItems.Add(rowBred);
            eachRow.SubItems.Add(rowHungry);
            listView1.Items.Add(eachRow);
        }

        private void AnimalPicLabel_Click(object sender, EventArgs e)
        {

        }
    }
}