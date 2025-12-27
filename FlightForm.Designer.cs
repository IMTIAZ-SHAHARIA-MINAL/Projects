
namespace AIRLINEMANAGEMENT
{
    partial class FlightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightForm));
            this.btnexit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnrecord = new Guna.UI2.WinForms.Guna2Button();
            this.btnreset = new Guna.UI2.WinForms.Guna2Button();
            this.btnback = new Guna.UI2.WinForms.Guna2Button();
            this.cbFrom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbDes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNos = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnviewflight = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Fdate = new System.Windows.Forms.DateTimePicker();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnexit.FillColor = System.Drawing.Color.Transparent;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(930, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnexit.Size = new System.Drawing.Size(54, 44);
            this.btnexit.TabIndex = 7;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.btnexit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(984, 44);
            this.guna2Panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(405, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "SPEED AIRLINE";
            // 
            // btnrecord
            // 
            this.btnrecord.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnrecord.BorderColor = System.Drawing.Color.White;
            this.btnrecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnrecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnrecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnrecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnrecord.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnrecord.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecord.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnrecord.Location = new System.Drawing.Point(146, 380);
            this.btnrecord.Name = "btnrecord";
            this.btnrecord.Size = new System.Drawing.Size(710, 45);
            this.btnrecord.TabIndex = 15;
            this.btnrecord.Text = "INSERT";
            this.btnrecord.Click += new System.EventHandler(this.btnrecord_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnreset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreset.FillColor = System.Drawing.Color.Transparent;
            this.btnreset.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnreset.Location = new System.Drawing.Point(146, 431);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(710, 45);
            this.btnreset.TabIndex = 16;
            this.btnreset.Text = "RESET";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnback
            // 
            this.btnback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnback.FillColor = System.Drawing.Color.Transparent;
            this.btnback.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.DimGray;
            this.btnback.Location = new System.Drawing.Point(146, 533);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(710, 45);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "BACK";
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cbFrom
            // 
            this.cbFrom.BackColor = System.Drawing.Color.Transparent;
            this.cbFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFrom.Font = new System.Drawing.Font("Century", 10.2F);
            this.cbFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFrom.ItemHeight = 30;
            this.cbFrom.Items.AddRange(new object[] {
            "Azerbaijan",
            "Aruba",
            "Armenia",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Argentina",
            "Austria",
            "Angola",
            "Bangladesh",
            "Belarus",
            "Brazil",
            "Bulgaria",
            "Bahamas",
            "Barbados",
            "Bahrain",
            "Belgium",
            "Bhutan",
            "China",
            "England",
            "India",
            "Iran",
            "Ireland",
            "Newzeland",
            "Pakistan",
            "United States"});
            this.cbFrom.Location = new System.Drawing.Point(464, 132);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(403, 36);
            this.cbFrom.TabIndex = 18;
            // 
            // cbDes
            // 
            this.cbDes.BackColor = System.Drawing.Color.Transparent;
            this.cbDes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDes.Font = new System.Drawing.Font("Century", 10.2F);
            this.cbDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDes.ItemHeight = 30;
            this.cbDes.Items.AddRange(new object[] {
            "Azerbaijan",
            "Aruba",
            "Armenia",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Argentina",
            "Austria",
            "Angola",
            "Bangladesh",
            "Belarus",
            "Brazil",
            "Bulgaria",
            "Bahamas",
            "Barbados",
            "Bahrain",
            "Belgium",
            "Bhutan",
            "China",
            "England",
            "India",
            "Iran",
            "Ireland",
            "Newzeland",
            "Pakistan",
            "United States"});
            this.cbDes.Location = new System.Drawing.Point(464, 185);
            this.cbDes.Name = "cbDes";
            this.cbDes.Size = new System.Drawing.Size(403, 36);
            this.cbDes.TabIndex = 19;
            // 
            // txtFcode
            // 
            this.txtFcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFcode.DefaultText = "";
            this.txtFcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFcode.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFcode.Location = new System.Drawing.Point(464, 96);
            this.txtFcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFcode.Name = "txtFcode";
            this.txtFcode.PasswordChar = '\0';
            this.txtFcode.PlaceholderText = "";
            this.txtFcode.SelectedText = "";
            this.txtFcode.Size = new System.Drawing.Size(403, 29);
            this.txtFcode.TabIndex = 20;
            // 
            // txtNos
            // 
            this.txtNos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNos.DefaultText = "";
            this.txtNos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNos.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNos.Location = new System.Drawing.Point(464, 246);
            this.txtNos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNos.Name = "txtNos";
            this.txtNos.PasswordChar = '\0';
            this.txtNos.PlaceholderText = "";
            this.txtNos.SelectedText = "";
            this.txtNos.Size = new System.Drawing.Size(403, 29);
            this.txtNos.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Flight Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Number of Seat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 33);
            this.label6.TabIndex = 27;
            this.label6.Text = "Record New Flights";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 584);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(984, 35);
            this.guna2Panel2.TabIndex = 28;
            // 
            // btnviewflight
            // 
            this.btnviewflight.BackColor = System.Drawing.Color.Crimson;
            this.btnviewflight.BorderColor = System.Drawing.Color.Blue;
            this.btnviewflight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnviewflight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnviewflight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnviewflight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnviewflight.FillColor = System.Drawing.Color.Transparent;
            this.btnviewflight.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewflight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnviewflight.Location = new System.Drawing.Point(146, 482);
            this.btnviewflight.Name = "btnviewflight";
            this.btnviewflight.Size = new System.Drawing.Size(710, 45);
            this.btnviewflight.TabIndex = 29;
            this.btnviewflight.Text = "VIEW FLIGHT";
            this.btnviewflight.Click += new System.EventHandler(this.btnviewflight_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(984, 619);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 30;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 28);
            this.label7.TabIndex = 33;
            this.label7.Text = "TakeOFF Date";
            // 
            // Fdate
            // 
            this.Fdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fdate.Location = new System.Drawing.Point(464, 302);
            this.Fdate.Name = "Fdate";
            this.Fdate.Size = new System.Drawing.Size(403, 32);
            this.Fdate.TabIndex = 40;
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 619);
            this.Controls.Add(this.Fdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnviewflight);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNos);
            this.Controls.Add(this.txtFcode);
            this.Controls.Add(this.cbDes);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnrecord);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2PictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnexit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnrecord;
        private Guna.UI2.WinForms.Guna2Button btnreset;
        private Guna.UI2.WinForms.Guna2Button btnback;
        private Guna.UI2.WinForms.Guna2ComboBox cbFrom;
        private Guna.UI2.WinForms.Guna2ComboBox cbDes;
        private Guna.UI2.WinForms.Guna2TextBox txtFcode;
        private Guna.UI2.WinForms.Guna2TextBox txtNos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnviewflight;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Fdate;
    }
}