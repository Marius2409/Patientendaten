namespace Patientendaten_Projekt
{
    partial class Home
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
            this.Anlegen = new System.Windows.Forms.Button();
            this.Ausgeben = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Anlegen
            // 
            this.Anlegen.Location = new System.Drawing.Point(87, 277);
            this.Anlegen.Name = "Anlegen";
            this.Anlegen.Size = new System.Drawing.Size(184, 57);
            this.Anlegen.TabIndex = 0;
            this.Anlegen.Text = "Anlegen";
            this.Anlegen.UseVisualStyleBackColor = true;
            this.Anlegen.Click += new System.EventHandler(this.Anlegen_Click);
            // 
            // Ausgeben
            // 
            this.Ausgeben.Location = new System.Drawing.Point(505, 277);
            this.Ausgeben.Name = "Ausgeben";
            this.Ausgeben.Size = new System.Drawing.Size(184, 57);
            this.Ausgeben.TabIndex = 1;
            this.Ausgeben.Text = "Ausgeben";
            this.Ausgeben.UseVisualStyleBackColor = true;
            this.Ausgeben.Click += new System.EventHandler(this.Ausgeben_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ausgeben);
            this.Controls.Add(this.Anlegen);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Anlegen;
        private System.Windows.Forms.Button Ausgeben;
    }
}