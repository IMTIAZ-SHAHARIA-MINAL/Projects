
namespace AIRLINEMANAGEMENT
{
    partial class PassengerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengerForm));
            this.btnexit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtPn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbNat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbGen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnrecord = new Guna.UI2.WinForms.Guna2Button();
            this.btnreset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnviewpassenger = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Back_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPn)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnexit.FillColor = System.Drawing.Color.Transparent;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(808, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnexit.Size = new System.Drawing.Size(54, 61);
            this.btnexit.TabIndex = 1;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtPn
            // 
            this.txtPn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPn.Image = ((System.Drawing.Image)(resources.GetObject("txtPn.Image")));
            this.txtPn.ImageRotate = 0F;
            this.txtPn.Location = new System.Drawing.Point(0, 0);
            this.txtPn.Name = "txtPn";
            this.txtPn.Size = new System.Drawing.Size(862, 665);
            this.txtPn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtPn.TabIndex = 27;
            this.txtPn.TabStop = false;
            this.txtPn.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 33);
            this.label1.TabIndex = 28;
            this.label1.Text = "ADDING PASSENGERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = " Passenger ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = " Passenger Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCoral;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 30);
            this.label4.TabIndex = 31;
            this.label4.Text = "Passport Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightCoral;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 30);
            this.label6.TabIndex = 32;
            this.label6.Text = " Passenger Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightCoral;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 30);
            this.label7.TabIndex = 33;
            this.label7.Text = "Nationality";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightCoral;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 30);
            this.label8.TabIndex = 34;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightCoral;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 30);
            this.label9.TabIndex = 35;
            this.label9.Text = "Phone";
            // 
            // cbNat
            // 
            this.cbNat.BackColor = System.Drawing.Color.Transparent;
            this.cbNat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNat.Font = new System.Drawing.Font("Century", 10.2F);
            this.cbNat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbNat.ItemHeight = 30;
            this.cbNat.Items.AddRange(new object[] {
            "Albanian",
            "Algerian",
            "American",
            "Bahraini",
            "Bangladeshi",
            "Barbadian",
            "British",
            "Chinese",
            "Indian",
            "New Zealander",
            "Pakistani",
            "Yemani",
            "Others"});
            this.cbNat.Location = new System.Drawing.Point(274, 299);
            this.cbNat.Name = "cbNat";
            this.cbNat.Size = new System.Drawing.Size(390, 36);
            this.cbNat.TabIndex = 38;
            // 
            // cbGen
            // 
            this.cbGen.BackColor = System.Drawing.Color.Transparent;
            this.cbGen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGen.Font = new System.Drawing.Font("Century", 10.2F);
            this.cbGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGen.ItemHeight = 30;
            this.cbGen.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGen.Location = new System.Drawing.Point(274, 346);
            this.cbGen.Name = "cbGen";
            this.cbGen.Size = new System.Drawing.Size(390, 36);
            this.cbGen.TabIndex = 39;
            // 
            // txtPid
            // 
            this.txtPid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPid.DefaultText = "";
            this.txtPid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPid.Location = new System.Drawing.Point(274, 108);
            this.txtPid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPid.Name = "txtPid";
            this.txtPid.PasswordChar = '\0';
            this.txtPid.PlaceholderText = "";
            this.txtPid.SelectedText = "";
            this.txtPid.Size = new System.Drawing.Size(390, 36);
            this.txtPid.TabIndex = 41;
            // 
            // txtPname
            // 
            this.txtPname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPname.DefaultText = "";
            this.txtPname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPname.Location = new System.Drawing.Point(274, 152);
            this.txtPname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPname.Name = "txtPname";
            this.txtPname.PasswordChar = '\0';
            this.txtPname.PlaceholderText = "";
            this.txtPname.SelectedText = "";
            this.txtPname.Size = new System.Drawing.Size(390, 36);
            this.txtPname.TabIndex = 42;
            // 
            // txtPass
            // 
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.Location = new System.Drawing.Point(274, 207);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(390, 36);
            this.txtPass.TabIndex = 43;
            // 
            // txtPad
            // 
            this.txtPad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPad.DefaultText = "";
            this.txtPad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPad.Location = new System.Drawing.Point(274, 255);
            this.txtPad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPad.Name = "txtPad";
            this.txtPad.PasswordChar = '\0';
            this.txtPad.PlaceholderText = "";
            this.txtPad.SelectedText = "";
            this.txtPad.Size = new System.Drawing.Size(390, 36);
            this.txtPad.TabIndex = 44;
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(274, 395);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(390, 36);
            this.txtPhone.TabIndex = 45;
            // 
            // btnrecord
            // 
            this.btnrecord.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnrecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnrecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnrecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnrecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnrecord.FillColor = System.Drawing.Color.Transparent;
            this.btnrecord.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecord.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnrecord.Location = new System.Drawing.Point(90, 438);
            this.btnrecord.Name = "btnrecord";
            this.btnrecord.Size = new System.Drawing.Size(691, 45);
            this.btnrecord.TabIndex = 46;
            this.btnrecord.Text = "INSERT";
            this.btnrecord.Click += new System.EventHandler(this.btnrecord_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.OrangeRed;
            this.btnreset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreset.FillColor = System.Drawing.Color.Transparent;
            this.btnreset.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnreset.Location = new System.Drawing.Point(90, 489);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(691, 45);
            this.btnreset.TabIndex = 47;
            this.btnreset.Text = "RESET";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.btnexit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(862, 61);
            this.guna2Panel1.TabIndex = 48;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnviewpassenger
            // 
            this.btnviewpassenger.BackColor = System.Drawing.Color.Lime;
            this.btnviewpassenger.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnviewpassenger.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnviewpassenger.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnviewpassenger.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnviewpassenger.FillColor = System.Drawing.Color.Transparent;
            this.btnviewpassenger.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewpassenger.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnviewpassenger.Location = new System.Drawing.Point(90, 540);
            this.btnviewpassenger.Name = "btnviewpassenger";
            this.btnviewpassenger.Size = new System.Drawing.Size(691, 45);
            this.btnviewpassenger.TabIndex = 50;
            this.btnviewpassenger.Text = "VIEW PASSENGER";
            this.btnviewpassenger.Click += new System.EventHandler(this.btnviewpassenger_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 642);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(862, 23);
            this.guna2Panel2.TabIndex = 51;
            // 
            // Back_Btn
            // 
            this.Back_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Back_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Back_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Back_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Back_Btn.FillColor = System.Drawing.Color.Gold;
            this.Back_Btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Back_Btn.Location = new System.Drawing.Point(90, 591);
            this.Back_Btn.Name = "Back_Btn";
            this.Back_Btn.Size = new System.Drawing.Size(691, 45);
            this.Back_Btn.TabIndex = 52;
            this.Back_Btn.Text = "BACK";
            this.Back_Btn.Click += new System.EventHandler(this.Back_Btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(302, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 33);
            this.label5.TabIndex = 30;
            this.label5.Text = "SPEED AIRLINE";
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 665);
            this.Controls.Add(this.Back_Btn);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btnviewpassenger);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnrecord);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPad);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.txtPid);
            this.Controls.Add(this.cbGen);
            this.Controls.Add(this.cbNat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PassengerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassengerForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtPn)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnexit;
        private Guna.UI2.WinForms.Guna2PictureBox txtPn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cbGen;
        private Guna.UI2.WinForms.Guna2TextBox txtPid;
        private Guna.UI2.WinForms.Guna2TextBox txtPname;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2TextBox txtPad;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2Button btnrecord;
        private Guna.UI2.WinForms.Guna2Button btnreset;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnviewpassenger;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        public Guna.UI2.WinForms.Guna2ComboBox cbNat;
        private Guna.UI2.WinForms.Guna2Button Back_Btn;
        private System.Windows.Forms.Label label5;
    }
}