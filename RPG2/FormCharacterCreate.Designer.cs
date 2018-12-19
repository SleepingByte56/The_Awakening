namespace RPG2
{
    partial class FormCharacterCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCharacterCreate));
            this.Txt_CharacterName = new System.Windows.Forms.TextBox();
            this.lbl_CharacterName = new System.Windows.Forms.Label();
            this.Gbox_Gender = new System.Windows.Forms.GroupBox();
            this.Rdo_GenderFemale = new System.Windows.Forms.RadioButton();
            this.Rdo_GenderMale = new System.Windows.Forms.RadioButton();
            this.Lbl_CharacterClass = new System.Windows.Forms.Label();
            this.Pbx_CreateCharacter = new System.Windows.Forms.PictureBox();
            this.Btn_SaveCharacter = new System.Windows.Forms.Button();
            this.Rdo_Fighter = new System.Windows.Forms.RadioButton();
            this.Rdo_Mage = new System.Windows.Forms.RadioButton();
            this.Rdo_Ranger = new System.Windows.Forms.RadioButton();
            this.Rdo_Thief = new System.Windows.Forms.RadioButton();
            this.Gbox_Gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_CreateCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_CharacterName
            // 
            this.Txt_CharacterName.Location = new System.Drawing.Point(91, 21);
            this.Txt_CharacterName.Name = "Txt_CharacterName";
            this.Txt_CharacterName.Size = new System.Drawing.Size(220, 26);
            this.Txt_CharacterName.TabIndex = 1;

            // 
            // lbl_CharacterName
            // 
            this.lbl_CharacterName.AutoSize = true;
            this.lbl_CharacterName.Location = new System.Drawing.Point(23, 27);
            this.lbl_CharacterName.Name = "lbl_CharacterName";
            this.lbl_CharacterName.Size = new System.Drawing.Size(51, 20);
            this.lbl_CharacterName.TabIndex = 2;
            this.lbl_CharacterName.Text = "Name";
            // 
            // Gbox_Gender
            // 
            this.Gbox_Gender.Controls.Add(this.Rdo_GenderFemale);
            this.Gbox_Gender.Controls.Add(this.Rdo_GenderMale);
            this.Gbox_Gender.Location = new System.Drawing.Point(397, 21);
            this.Gbox_Gender.Name = "Gbox_Gender";
            this.Gbox_Gender.Size = new System.Drawing.Size(189, 53);
            this.Gbox_Gender.TabIndex = 3;
            this.Gbox_Gender.TabStop = false;
            this.Gbox_Gender.Text = "Gender";
            // 
            // Rdo_GenderFemale
            // 
            this.Rdo_GenderFemale.AutoSize = true;
            this.Rdo_GenderFemale.Location = new System.Drawing.Point(80, 25);
            this.Rdo_GenderFemale.Name = "Rdo_GenderFemale";
            this.Rdo_GenderFemale.Size = new System.Drawing.Size(87, 24);
            this.Rdo_GenderFemale.TabIndex = 1;
            this.Rdo_GenderFemale.TabStop = true;
            this.Rdo_GenderFemale.Text = "Female";
            this.Rdo_GenderFemale.UseVisualStyleBackColor = true;
            // 
            // Rdo_GenderMale
            // 
            this.Rdo_GenderMale.AutoSize = true;
            this.Rdo_GenderMale.Location = new System.Drawing.Point(6, 25);
            this.Rdo_GenderMale.Name = "Rdo_GenderMale";
            this.Rdo_GenderMale.Size = new System.Drawing.Size(68, 24);
            this.Rdo_GenderMale.TabIndex = 0;
            this.Rdo_GenderMale.TabStop = true;
            this.Rdo_GenderMale.Text = "Male";
            this.Rdo_GenderMale.UseVisualStyleBackColor = true;
            // 
            // Lbl_CharacterClass
            // 
            this.Lbl_CharacterClass.AutoSize = true;
            this.Lbl_CharacterClass.Location = new System.Drawing.Point(23, 77);
            this.Lbl_CharacterClass.Name = "Lbl_CharacterClass";
            this.Lbl_CharacterClass.Size = new System.Drawing.Size(122, 20);
            this.Lbl_CharacterClass.TabIndex = 5;
            this.Lbl_CharacterClass.Text = "Character Class";
            // 
            // Pbx_CreateCharacter
            // 
            this.Pbx_CreateCharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pbx_CreateCharacter.BackgroundImage")));
            this.Pbx_CreateCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pbx_CreateCharacter.Location = new System.Drawing.Point(12, 27);
            this.Pbx_CreateCharacter.Name = "Pbx_CreateCharacter";
            this.Pbx_CreateCharacter.Size = new System.Drawing.Size(591, 426);
            this.Pbx_CreateCharacter.TabIndex = 6;
            this.Pbx_CreateCharacter.TabStop = false;
            // 
            // Btn_SaveCharacter
            // 
            this.Btn_SaveCharacter.Location = new System.Drawing.Point(27, 357);
            this.Btn_SaveCharacter.Name = "Btn_SaveCharacter";
            this.Btn_SaveCharacter.Size = new System.Drawing.Size(166, 49);
            this.Btn_SaveCharacter.TabIndex = 7;
            this.Btn_SaveCharacter.Text = "Save Character";
            this.Btn_SaveCharacter.UseVisualStyleBackColor = true;
            this.Btn_SaveCharacter.Click += new System.EventHandler(this.Btn_SaveCharacter_Click);
            // 
            // Rdo_Fighter
            // 
            this.Rdo_Fighter.AutoSize = true;
            this.Rdo_Fighter.Location = new System.Drawing.Point(40, 109);
            this.Rdo_Fighter.Name = "Rdo_Fighter";
            this.Rdo_Fighter.Size = new System.Drawing.Size(84, 24);
            this.Rdo_Fighter.TabIndex = 8;
            this.Rdo_Fighter.TabStop = true;
            this.Rdo_Fighter.Text = "Fighter";
            this.Rdo_Fighter.UseVisualStyleBackColor = true;
            // 
            // Rdo_Mage
            // 
            this.Rdo_Mage.AutoSize = true;
            this.Rdo_Mage.Location = new System.Drawing.Point(40, 140);
            this.Rdo_Mage.Name = "Rdo_Mage";
            this.Rdo_Mage.Size = new System.Drawing.Size(74, 24);
            this.Rdo_Mage.TabIndex = 9;
            this.Rdo_Mage.TabStop = true;
            this.Rdo_Mage.Text = "Mage";
            this.Rdo_Mage.UseVisualStyleBackColor = true;
            // 
            // Rdo_Ranger
            // 
            this.Rdo_Ranger.AutoSize = true;
            this.Rdo_Ranger.Location = new System.Drawing.Point(40, 171);
            this.Rdo_Ranger.Name = "Rdo_Ranger";
            this.Rdo_Ranger.Size = new System.Drawing.Size(87, 24);
            this.Rdo_Ranger.TabIndex = 10;
            this.Rdo_Ranger.TabStop = true;
            this.Rdo_Ranger.Text = "Ranger";
            this.Rdo_Ranger.UseVisualStyleBackColor = true;
            // 
            // Rdo_Thief
            // 
            this.Rdo_Thief.AutoSize = true;
            this.Rdo_Thief.Location = new System.Drawing.Point(40, 202);
            this.Rdo_Thief.Name = "Rdo_Thief";
            this.Rdo_Thief.Size = new System.Drawing.Size(69, 24);
            this.Rdo_Thief.TabIndex = 11;
            this.Rdo_Thief.TabStop = true;
            this.Rdo_Thief.Text = "Thief";
            this.Rdo_Thief.UseVisualStyleBackColor = true;
            // 
            // FormCharacterCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.Rdo_Thief);
            this.Controls.Add(this.Rdo_Ranger);
            this.Controls.Add(this.Rdo_Mage);
            this.Controls.Add(this.Rdo_Fighter);
            this.Controls.Add(this.Btn_SaveCharacter);
            this.Controls.Add(this.Lbl_CharacterClass);
            this.Controls.Add(this.Gbox_Gender);
            this.Controls.Add(this.lbl_CharacterName);
            this.Controls.Add(this.Txt_CharacterName);
            this.Controls.Add(this.Pbx_CreateCharacter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCharacterCreate";
            this.Text = "Create Your Character";
            this.Gbox_Gender.ResumeLayout(false);
            this.Gbox_Gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_CreateCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_CharacterName;
        private System.Windows.Forms.Label lbl_CharacterName;
        private System.Windows.Forms.GroupBox Gbox_Gender;
        private System.Windows.Forms.RadioButton Rdo_GenderFemale;
        private System.Windows.Forms.RadioButton Rdo_GenderMale;
        private System.Windows.Forms.Label Lbl_CharacterClass;
        private System.Windows.Forms.PictureBox Pbx_CreateCharacter;
        private System.Windows.Forms.Button Btn_SaveCharacter;
        private System.Windows.Forms.RadioButton Rdo_Fighter;
        private System.Windows.Forms.RadioButton Rdo_Mage;
        private System.Windows.Forms.RadioButton Rdo_Ranger;
        private System.Windows.Forms.RadioButton Rdo_Thief;
    }
}