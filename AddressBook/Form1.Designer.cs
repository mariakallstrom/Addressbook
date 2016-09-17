namespace AddressBook
{
    partial class Form1
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
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtZip = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblZip = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.BtnGetContact = new System.Windows.Forms.Button();
            this.BtnRegistrate = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(90, 31);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(157, 20);
            this.TxtFirstName.TabIndex = 0;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(90, 68);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(157, 20);
            this.TxtLastName.TabIndex = 1;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(90, 104);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(157, 20);
            this.TxtAddress.TabIndex = 2;
            // 
            // TxtZip
            // 
            this.TxtZip.Location = new System.Drawing.Point(90, 141);
            this.TxtZip.Name = "TxtZip";
            this.TxtZip.Size = new System.Drawing.Size(157, 20);
            this.TxtZip.TabIndex = 3;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(90, 179);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(157, 20);
            this.TxtCity.TabIndex = 4;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(90, 217);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(157, 20);
            this.TxtPhone.TabIndex = 5;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(90, 255);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(157, 20);
            this.TxtEmail.TabIndex = 6;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(13, 34);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(48, 13);
            this.LblFirstName.TabIndex = 7;
            this.LblFirstName.Text = "Förnamn";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(12, 71);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(55, 13);
            this.LblLastName.TabIndex = 8;
            this.LblLastName.Text = "Efternamn";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(13, 107);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(61, 13);
            this.LblAddress.TabIndex = 9;
            this.LblAddress.Text = "Gatuadress";
            // 
            // LblZip
            // 
            this.LblZip.AutoSize = true;
            this.LblZip.Location = new System.Drawing.Point(12, 144);
            this.LblZip.Name = "LblZip";
            this.LblZip.Size = new System.Drawing.Size(65, 13);
            this.LblZip.TabIndex = 10;
            this.LblZip.Text = "Postnummer";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(12, 182);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(40, 13);
            this.LblCity.TabIndex = 11;
            this.LblCity.Text = "Postort";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(12, 220);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(43, 13);
            this.LblPhone.TabIndex = 12;
            this.LblPhone.Text = "Telefon";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(13, 258);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 13;
            this.LblEmail.Text = "E-mail";
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(314, 31);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(237, 82);
            this.ListBox.TabIndex = 14;
            // 
            // BtnGetContact
            // 
            this.BtnGetContact.Location = new System.Drawing.Point(314, 2);
            this.BtnGetContact.Name = "BtnGetContact";
            this.BtnGetContact.Size = new System.Drawing.Size(126, 23);
            this.BtnGetContact.TabIndex = 15;
            this.BtnGetContact.Text = "Hämta Kontakter";
            this.BtnGetContact.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrate
            // 
            this.BtnRegistrate.Location = new System.Drawing.Point(116, 291);
            this.BtnRegistrate.Name = "BtnRegistrate";
            this.BtnRegistrate.Size = new System.Drawing.Size(92, 23);
            this.BtnRegistrate.TabIndex = 16;
            this.BtnRegistrate.Text = "Registrera";
            this.BtnRegistrate.UseVisualStyleBackColor = true;
            // 
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(245, 291);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(98, 23);
            this.BtnChange.TabIndex = 17;
            this.BtnChange.Text = "Ändra";
            this.BtnChange.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(384, 291);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(167, 23);
            this.BtnSearch.TabIndex = 18;
            this.BtnSearch.Text = "Sök ";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(384, 250);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(167, 20);
            this.TxtSearch.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 357);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.BtnRegistrate);
            this.Controls.Add(this.BtnGetContact);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblZip);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtZip);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Name = "Form1";
            this.Text = "Mina Kontakter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtZip;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblZip;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button BtnGetContact;
        private System.Windows.Forms.Button BtnRegistrate;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
    }
}

