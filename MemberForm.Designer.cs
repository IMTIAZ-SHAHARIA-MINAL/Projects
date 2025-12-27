
namespace AIRLINEMANAGEMENT
{
    partial class MemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            this.lblOutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Ticketbook = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnviewflight = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Help = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(222, 483);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(192, 34);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "WELCOME  ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1129, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            // btn_Ticketbook
            // 
            this.btn_Ticketbook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ticketbook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ticketbook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Ticketbook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Ticketbook.FillColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Ticketbook.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ticketbook.ForeColor = System.Drawing.Color.White;
            this.btn_Ticketbook.Location = new System.Drawing.Point(245, 187);
            this.btn_Ticketbook.Name = "btn_Ticketbook";
            this.btn_Ticketbook.Size = new System.Drawing.Size(658, 45);
            this.btn_Ticketbook.TabIndex = 17;
            this.btn_Ticketbook.Text = "BOOKED TICKETS";
            this.btn_Ticketbook.Click += new System.EventHandler(this.btn_Ticketbook_Click);
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
            this.btnlogout.Location = new System.Drawing.Point(245, 350);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(658, 45);
            this.btnlogout.TabIndex = 19;
            this.btnlogout.Text = "Logout";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
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
            this.btnviewflight.Location = new System.Drawing.Point(245, 88);
            this.btnviewflight.Name = "btnviewflight";
            this.btnviewflight.Size = new System.Drawing.Size(658, 44);
            this.btnviewflight.TabIndex = 56;
            this.btnviewflight.Text = "VIEW FLIGHT";
            this.btnviewflight.Click += new System.EventHandler(this.btnviewflight_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Help.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Help.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Help.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Help.FillColor = System.Drawing.Color.Green;
            this.btn_Help.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.ForeColor = System.Drawing.Color.White;
            this.btn_Help.Location = new System.Drawing.Point(245, 268);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(658, 45);
            this.btn_Help.TabIndex = 57;
            this.btn_Help.Text = "Help and Support";
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 570);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btnviewflight);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btn_Ticketbook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberForm";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_Close;
        private Guna.UI2.WinForms.Guna2Button btn_Ticketbook;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private Guna.UI2.WinForms.Guna2Button btnviewflight;
        private Guna.UI2.WinForms.Guna2Button btn_Help;
    }
}