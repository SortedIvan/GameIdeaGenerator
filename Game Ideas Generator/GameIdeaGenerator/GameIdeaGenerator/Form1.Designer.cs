
namespace GameIdeaGenerator
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
            this.btnGenerateIdea = new System.Windows.Forms.Button();
            this.lbxAddedGenres = new System.Windows.Forms.ListBox();
            this.cbxGameType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerateIdea
            // 
            this.btnGenerateIdea.Location = new System.Drawing.Point(61, 351);
            this.btnGenerateIdea.Name = "btnGenerateIdea";
            this.btnGenerateIdea.Size = new System.Drawing.Size(113, 54);
            this.btnGenerateIdea.TabIndex = 0;
            this.btnGenerateIdea.Text = "Generate";
            this.btnGenerateIdea.UseVisualStyleBackColor = true;
            this.btnGenerateIdea.Click += new System.EventHandler(this.btnGenerateIdea_Click);
            // 
            // lbxAddedGenres
            // 
            this.lbxAddedGenres.FormattingEnabled = true;
            this.lbxAddedGenres.ItemHeight = 16;
            this.lbxAddedGenres.Location = new System.Drawing.Point(295, 81);
            this.lbxAddedGenres.Name = "lbxAddedGenres";
            this.lbxAddedGenres.Size = new System.Drawing.Size(286, 276);
            this.lbxAddedGenres.TabIndex = 2;
            // 
            // cbxGameType
            // 
            this.cbxGameType.FormattingEnabled = true;
            this.cbxGameType.Items.AddRange(new object[] {
            "Adventure"});
            this.cbxGameType.Location = new System.Drawing.Point(53, 106);
            this.cbxGameType.Name = "cbxGameType";
            this.cbxGameType.Size = new System.Drawing.Size(156, 24);
            this.cbxGameType.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxGameType);
            this.Controls.Add(this.lbxAddedGenres);
            this.Controls.Add(this.btnGenerateIdea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateIdea;
        private System.Windows.Forms.ListBox lbxAddedGenres;
        private System.Windows.Forms.ComboBox cbxGameType;
    }
}

