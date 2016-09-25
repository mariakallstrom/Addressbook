using System.ComponentModel;
using System.Windows.Forms;

namespace AddressBook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDeleteContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(148, 49);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(234, 26);
            this.TxtFirstName.TabIndex = 0;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(148, 106);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(234, 26);
            this.TxtLastName.TabIndex = 1;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(148, 161);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(234, 26);
            this.TxtAddress.TabIndex = 2;
            // 
            // TxtZip
            // 
            this.TxtZip.Location = new System.Drawing.Point(148, 218);
            this.TxtZip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtZip.Name = "TxtZip";
            this.TxtZip.Size = new System.Drawing.Size(234, 26);
            this.TxtZip.TabIndex = 3;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(148, 276);
            this.TxtCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(234, 26);
            this.TxtCity.TabIndex = 4;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(148, 335);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(234, 26);
            this.TxtPhone.TabIndex = 5;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(148, 393);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(234, 26);
            this.TxtEmail.TabIndex = 6;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(20, 52);
            this.LblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(73, 20);
            this.LblFirstName.TabIndex = 7;
            this.LblFirstName.Text = "Förnamn";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(18, 109);
            this.LblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(84, 20);
            this.LblLastName.TabIndex = 8;
            this.LblLastName.Text = "Efternamn";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(20, 165);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(93, 20);
            this.LblAddress.TabIndex = 9;
            this.LblAddress.Text = "Gatuadress";
            // 
            // LblZip
            // 
            this.LblZip.AutoSize = true;
            this.LblZip.Location = new System.Drawing.Point(18, 222);
            this.LblZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblZip.Name = "LblZip";
            this.LblZip.Size = new System.Drawing.Size(99, 20);
            this.LblZip.TabIndex = 10;
            this.LblZip.Text = "Postnummer";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(18, 280);
            this.LblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(60, 20);
            this.LblCity.TabIndex = 11;
            this.LblCity.Text = "Postort";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(18, 338);
            this.LblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(120, 20);
            this.LblPhone.TabIndex = 12;
            this.LblPhone.Text = "Telefonnummer";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(20, 397);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(53, 20);
            this.LblEmail.TabIndex = 13;
            this.LblEmail.Text = "E-mail";
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 20;
            this.ListBox.Location = new System.Drawing.Point(404, 48);
            this.ListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(421, 124);
            this.ListBox.TabIndex = 14;
            this.ListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            // 
            // BtnGetContact
            // 
            this.BtnGetContact.Location = new System.Drawing.Point(404, 183);
            this.BtnGetContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGetContact.Name = "BtnGetContact";
            this.BtnGetContact.Size = new System.Drawing.Size(196, 42);
            this.BtnGetContact.TabIndex = 15;
            this.BtnGetContact.Text = "Hämta Kontakter";
            this.BtnGetContact.UseVisualStyleBackColor = true;
            this.BtnGetContact.Click += new System.EventHandler(this.BtnGetContact_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(135, 448);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(236, 35);
            this.BtnSave.TabIndex = 16;
            this.BtnSave.Text = "Spara";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnRegistrate_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(744, 247);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(88, 37);
            this.BtnSearch.TabIndex = 18;
            this.BtnSearch.Text = "Sök ";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtSearch.Location = new System.Drawing.Point(404, 252);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(332, 26);
            this.TxtSearch.TabIndex = 19;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(404, 448);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(134, 35);
            this.BtnClear.TabIndex = 22;
            this.BtnClear.Text = "Rensa";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDeleteContact
            // 
            this.BtnDeleteContact.Location = new System.Drawing.Point(624, 182);
            this.BtnDeleteContact.Name = "BtnDeleteContact";
            this.BtnDeleteContact.Size = new System.Drawing.Size(202, 43);
            this.BtnDeleteContact.TabIndex = 23;
            this.BtnDeleteContact.Text = "Ta bort kontakt";
            this.BtnDeleteContact.UseVisualStyleBackColor = true;
            this.BtnDeleteContact.Click += new System.EventHandler(this.BtnDeleteContact_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 549);
            this.Controls.Add(this.BtnDeleteContact);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnSave);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Mina Kontakter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox TxtFirstName;
        private Label LblFirstName;
        private Label LblLastName;
        private Label LblAddress;
        private Label LblZip;
        private Label LblCity;
        private Label LblPhone;
        private Label LblEmail;
        public ListBox ListBox;
        private Button BtnGetContact;
        private Button BtnSave;
        private Button BtnSearch;
        public TextBox TxtSearch;
        public TextBox TxtLastName;
        public TextBox TxtAddress;
        public TextBox TxtZip;
        public TextBox TxtCity;
        public TextBox TxtPhone;
        public TextBox TxtEmail;
        private Button BtnClear;
        private Button BtnDeleteContact;
    }
}

