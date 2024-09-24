using DnDCharacterSheet.CharacterDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
namespace DnDCharacterSheet
{
    public partial class InfoSheet : Form
    {
        string CharName;
        public InfoSheet(string name)
        {
            CharName = name;
            InitializeComponent();
        }
        public int CalculateAbilityScore(int stat)
        {
            int number = stat;
            int score = (number - 10) / 2;
            return score;
        }
        private void InfoSheet_Load(object sender, EventArgs e)
        {
            this.mainStatsTableAdapter.Fill(this.characterDBDataSet.MainStats);
            CharacterDataDataContext Data = new CharacterDataDataContext();

            foreach (var i in Data.MainStats)
            {
                if(i.Name == CharName){
                    nameTextBox.Text = i.Name;
                    raceTextBox.Text = i.Race;
                    classTextBox.Text = i.Class;
                    strTextBox.Text = i.Str.ToString();
                    dexTextBox.Text = i.Dex.ToString();
                    conTextBox.Text = i.Con.ToString();
                    intTextBox.Text = i.Int.ToString();
                    wisTextBox.Text = i.Wis.ToString();
                    chaTextBox.Text = i.Cha.ToString();
                    hPTextBox.Text = i.HP.ToString();
                    aCTextBox.Text = i.AC.ToString();
                    
                }
            }


            //had to manually bind textboxes the data sources so they would fill
            //nameTextBox.DataBindings.Add("Text", mainStatsBindingSource1, "Name");
            //raceTextBox.DataBindings.Add("Text", mainStatsBindingSource1, "Race");
            //classTextBox.DataBindings.Add("Text", mainStatsBindingSource1, "Class");
            //strTextBox.DataBindings.Add("Text", mainStatsBindingSource1, "Str");
            //dexTextBox.DataBindings.Add("Text", mainStatsBindingSource1, "Dex");
            //conTextBox.DataBindings.Add("Text", mainStatsBindingSource1, "Con");
            //intTextBox.DataBindings.Add("Text", mainStatsBindingSource1, "Int");
            //wisTextBox.DataBindings.Add("Text", mainStatsBindingSource1, "Wis");
            //chaTextBox.DataBindings.Add("Text", mainStatsBindingSource1, "Cha");
            //hPTextBox.DataBindings.Add("Text", mainStatsBindingSource1, "HP");
            //aCTextBox.DataBindings.Add("Text", mainStatsBindingSource1, "AC");

            // TODO: This line of code loads data into the 'characterDBDataSet.MainStats' table. You can move, or remove it, as needed.
            
            //checks if the name of the character has an inventory 
            if (File.Exists(nameTextBox.Text.ToString() + " Inventory"))
            {
                string[] items = File.ReadAllLines(nameTextBox.Text.ToString() + " Inventory");

                inventoryLB.Items.AddRange(items);
            }

            //clears the inventory listbox if there is not a file that exists
            else
            {
                inventoryLB.Items.Clear();  
            }
            //checks if the name of the chara
            if (File.Exists(nameTextBox.Text.ToString() + " Feats"))
            {
                string[] feats = File.ReadAllLines(nameTextBox.Text.ToString() + " Feats");

                featsLB.Items.AddRange(feats);
            }
            //clears the feats listbox if there is not a file that exists
            else
            {
                featsLB.Items.Clear();
            }
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE


            //ability score modifiers
            int stat;
            if (int.TryParse(strTextBox.Text, out stat))
            { 
                int abilityscore  = CalculateAbilityScore(stat);
                strSVLblDisplay.Text = abilityscore.ToString();
            }
            
            if (int.TryParse(dexTextBox.Text, out stat))
            {
                int abilityscore = CalculateAbilityScore(stat);
                dexSVLblDisplay.Text = abilityscore.ToString();
            }
            if (int.TryParse(conTextBox.Text, out stat))
            {
                int abilityscore = CalculateAbilityScore(stat);
                conSVLblDisplay.Text = abilityscore.ToString();
            }
            if (int.TryParse(intTextBox.Text, out stat))
            {
                int abilityscore = CalculateAbilityScore(stat);
                intSVLblDisplay.Text = abilityscore.ToString();
            }
            if (int.TryParse(wisTextBox.Text, out stat))
            {
                int abilityscore = CalculateAbilityScore(stat);
                wisSVLblDisplay.Text = abilityscore.ToString();
            }
            if (int.TryParse(chaTextBox.Text, out stat))
            {
                int abilityscore = CalculateAbilityScore(stat);
                chaSVLblDisplay.Text = abilityscore.ToString();
            }
        }

//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE

        private void helpLbL_Click(object sender, EventArgs e)
        {
            //clicking on the help label makes it dissapear 
            helpLbL.Visible = false;
            helpLbL.Enabled = false;
            helpLbL.SendToBack();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            //makes a label appear with instructions for helping 
            helpLbL.Visible = true;
            helpLbL.Enabled = true;
            helpLbL.BringToFront();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //creates the file for the inventory saving
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText(nameTextBox.Text.ToString() + " Inventory");

                foreach (var item in inventoryLB.Items) 
                {
                    outputFile.WriteLine(item);
                }
                outputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                StreamWriter outputFile2;
                outputFile2 = File.CreateText(nameTextBox.Text.ToString() + " Feats");

                foreach (var item in featsLB.Items)
                {
                    outputFile2.WriteLine(item);
                }
                outputFile2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE

            //updates the saved data

            this.Validate();
            
            this.mainStatsBindingSource1.EndEdit();
            
            this.tableAdapterManager.UpdateAll(this.characterDBDataSet);
            

            this.Close();
        }
        //adds the item from the textbox to the listbox for the inventory
        private void addBtn_Click(object sender, EventArgs e)
        {
            string newItem = addTB.Text.ToString();
            inventoryLB.Items.Add(newItem); 
            addTB.Clear();
        }
        //deletes the selected item in the listbox
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (inventoryLB.SelectedIndex != -1)
            {
                inventoryLB.Items.RemoveAt(inventoryLB.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to delete");
            }
        }
        //does the same as the inventory buttons
        private void delFeatsBtn_Click(object sender, EventArgs e)
        {
            if (featsLB.SelectedIndex != -1)
            {
                featsLB.Items.RemoveAt(featsLB.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to delete");
            }
        }

        private void addFeatsBtn_Click(object sender, EventArgs e)
        {
            string newItem = featsTB.Text.ToString();
            featsLB.Items.Add(newItem);
            featsTB.Clear();
        }
    }
}
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE
//WARNING THIS WILL NOT RUN IT IS JUST AN EXAMPLE