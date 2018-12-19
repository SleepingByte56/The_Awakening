using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPG2.CharacterClasses;

namespace RPG2
{
    public partial class FormCharacterCreate : Form
    {
        public FormCharacterCreate()
        {
            InitializeComponent();
        }

        private void Btn_SaveCharacter_Click(object sender, EventArgs e)
        {

            //Get info from form
            // Make sure fields are not empty
            if (String.IsNullOrEmpty(Txt_CharacterName.Text) ||
                Txt_CharacterName.Text[0] == ' ')
            {
                MessageBox.Show("You must enter a name and " +
                    "names can't start with a space");
                return;
            }



            if (this.Rdo_GenderMale.Checked == false &&
                this.Rdo_GenderFemale.Checked == false)
            {
                MessageBox.Show("You must select a gender!");
                return;
            }

            //Define the varible for gender
           string gender = (string)(this.Rdo_GenderFemale.Checked ? "Female" :
                "Male");

            //MessageBox.Show("Your character is " + gender);


            if (this.Rdo_Fighter.Checked == true)
            {
                MessageBox.Show("Your gender is " + gender + ", and you are a Fighter, named " + Txt_CharacterName.Text);
            }

            else if(this.Rdo_Mage.Checked == true)
            {
                MessageBox.Show("Your gender is " + gender + ", and you are a Mage, named " + Txt_CharacterName.Text);
            }

            else if(this.Rdo_Ranger.Checked == true)
            {
                MessageBox.Show("Your gender is " + gender + ", and you are a Ranger, named " + Txt_CharacterName.Text);
            }
            else if(this.Rdo_Thief.Checked == true)
            {
                MessageBox.Show("Your gender is " + gender + ", and you are a Thief, named " + Txt_CharacterName.Text);
            }
                    
        }
    }

     
}
