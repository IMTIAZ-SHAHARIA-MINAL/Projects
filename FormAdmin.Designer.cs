
namespace AIRLINEMANAGEMENT
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnFlight = new Guna.UI2.WinForms.Guna2Button();
            this.btnPassenger = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Ticketbook = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 40);
            this.panel1.TabIndex = 14;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.FillColor = System.Drawing.Color.Transparent;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(1098, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_Close.Size = new System.Drawing.Size(31, 40);
            this.btn_Close.TabIndex = 12;
            this.btn_Close.UseTransparentBackground = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1129, 530);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(221, 489);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(192, 34);
            this.lblOutput.TabIndex = 16;
            this.lblOutput.Text = "WELCOME  ";
            // 
            // btnFlight
            // 
            this.btnFlight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFlight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFlight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFlight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFlight.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnFlight.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlight.ForeColor = System.Drawing.Color.White;
            this.btnFlight.Location = new System.Drawing.Point(241, 101);
            this.btnFlight.Name = "btnFlight";
            this.btnFlight.Size = new System.Drawing.Size(658, 45);
            this.btnFlight.TabIndex = 17;
            this.btnFlight.Text = "FLIGHTS";
            this.btnFlight.Click += new System.EventHandler(this.btnFlight_Click);
            // 
            // btnPassenger
            // 
            this.btnPassenger.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPassenger.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPassenger.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPassenger.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPassenger.FillColor = System.Drawing.Color.SeaGreen;
            this.btnPassenger.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassenger.ForeColor = System.Drawing.Color.White;
            this.btnPassenger.Location = new System.Drawing.Point(241, 172);
            this.btnPassenger.Name = "btnPassenger";
            this.btnPassenger.Size = new System.Drawing.Size(658, 45);
            this.btnPassenger.TabIndex = 18;
            this.btnPassenger.Text = "PASSENGERS";
            this.btnPassenger.Click += new System.EventHandler(this.btnPassenger_Click);
            // 
            // btn_Ticketbook
            // 
            this.btn_Ticketbook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ticketbook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ticketbook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Ticketbook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Ticketbook.FillColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Ticketbook.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ticketbook.ForeColor = System.Drawing.Color.White;
            this.btn_Ticketbook.Location = new System.Drawing.Point(241, 245);
            this.btn_Ticketbook.Name = "btn_Ticketbook";
            this.btn_Ticketbook.Size = new System.Drawing.Size(658, 45);
            this.btn_Ticketbook.TabIndex = 19;
            this.btn_Ticketbook.Text = "TICKET BOOKINGS";
            this.btn_Ticketbook.Click += new System.EventHandler(this.btn_Ticketbook_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.FillColor = System.Drawing.Color.Red;
            this.btn_Cancel.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(241, 311);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(658, 45);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "FLIGHT CANCELLATION";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogout.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnlogout.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(241, 373);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(658, 45);
            this.btnlogout.TabIndex = 21;
            this.btnlogout.Text = "Logout";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 570);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ticketbook);
            this.Controls.Add(this.btnPassenger);
            this.Controls.Add(this.btnFlight);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOutput;
        private Guna.UI2.WinForms.Guna2Button btnFlight;
        private Guna.UI2.WinForms.Guna2Button btnPassenger;
        private Guna.UI2.WinForms.Guna2Button btn_Ticketbook;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
    }
}