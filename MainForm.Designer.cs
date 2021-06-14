
namespace PlayStationDiscord
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Details = new System.Windows.Forms.TextBox();
            this.playstationSwitch = new System.Windows.Forms.ComboBox();
            this.tb_State = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Details
            // 
            this.tb_Details.Location = new System.Drawing.Point(59, 71);
            this.tb_Details.Name = "tb_Details";
            this.tb_Details.PlaceholderText = "Game";
            this.tb_Details.Size = new System.Drawing.Size(91, 23);
            this.tb_Details.TabIndex = 2;
            // 
            // playstationSwitch
            // 
            this.playstationSwitch.FormattingEnabled = true;
            this.playstationSwitch.Items.AddRange(new object[] {
            "PlayStation 1",
            "PlayStation 2",
            "Wii"});
            this.playstationSwitch.Location = new System.Drawing.Point(59, 42);
            this.playstationSwitch.Name = "playstationSwitch";
            this.playstationSwitch.Size = new System.Drawing.Size(192, 23);
            this.playstationSwitch.TabIndex = 3;
            this.playstationSwitch.Text = "Choose Console";
            this.playstationSwitch.SelectedIndexChanged += new System.EventHandler(this.playstationSwitch_SelectedIndexChanged);
            // 
            // tb_State
            // 
            this.tb_State.Location = new System.Drawing.Point(151, 71);
            this.tb_State.Name = "tb_State";
            this.tb_State.PlaceholderText = "State";
            this.tb_State.Size = new System.Drawing.Size(100, 23);
            this.tb_State.TabIndex = 4;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(114, 116);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 151);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.tb_State);
            this.Controls.Add(this.playstationSwitch);
            this.Controls.Add(this.tb_Details);
            this.Name = "MainForm";
            this.Text = "PlayStation for Discord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Details;
        private System.Windows.Forms.ComboBox playstationSwitch;
        private System.Windows.Forms.TextBox tb_State;
        private System.Windows.Forms.Button updateButton;
    }
}

