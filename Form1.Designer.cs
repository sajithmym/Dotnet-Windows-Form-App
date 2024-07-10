namespace Init_Desktop_App
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstContacts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Contact Manager";
            this.BackColor = System.Drawing.Color.LightBlue;

            // Title Label
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Text = "Contact Manager";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(250, 20);
            this.lblTitle.AutoSize = true;
            this.Controls.Add(this.lblTitle);

            // Input TextBox
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtInput.PlaceholderText = "Enter contact name";
            this.txtInput.Location = new System.Drawing.Point(200, 100);
            this.txtInput.Size = new System.Drawing.Size(400, 30);
            this.txtInput.Font = new System.Drawing.Font("Arial", 12F);
            this.Controls.Add(this.txtInput);

            // Submit Button
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSubmit.Text = "Add";
            this.btnSubmit.Location = new System.Drawing.Point(350, 150);
            this.btnSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.Controls.Add(this.btnSubmit);

            // Contacts ListBox
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.lstContacts.Location = new System.Drawing.Point(200, 200);
            this.lstContacts.Size = new System.Drawing.Size(400, 200);
            this.lstContacts.Font = new System.Drawing.Font("Arial", 12F);
            this.lstContacts.BackColor = System.Drawing.Color.White;
            this.lstContacts.ForeColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lstContacts);
        }

        #endregion

        // Event Handler for Button Click
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtInput.Text))
            {
                this.lstContacts.Items.Add(this.txtInput.Text);
                this.txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a contact name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
