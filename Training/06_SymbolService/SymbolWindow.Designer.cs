namespace _06_SymbolService
{
    partial class SymbolWindow
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.Linking = new System.Windows.Forms.TextBox();
            this.Right = new System.Windows.Forms.TextBox();
            this.Left = new System.Windows.Forms.TextBox();
            this.Downing = new System.Windows.Forms.TextBox();
            this.Down = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.Label();
            this.TOP = new System.Windows.Forms.Label();
            this.Top2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(38, 390);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "button1";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(241, 389);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "button2";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Linking
            // 
            this.Linking.Location = new System.Drawing.Point(194, 327);
            this.Linking.Name = "Linking";
            this.Linking.Size = new System.Drawing.Size(100, 22);
            this.Linking.TabIndex = 2;
            this.Linking.TextChanged += new System.EventHandler(this.Link_TextChanged);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(194, 280);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(100, 22);
            this.Right.TabIndex = 3;
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(194, 226);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(100, 22);
            this.Left.TabIndex = 4;
            // 
            // Downing
            // 
            this.Downing.Location = new System.Drawing.Point(194, 180);
            this.Downing.Name = "Downing";
            this.Downing.Size = new System.Drawing.Size(100, 22);
            this.Downing.TabIndex = 5;
            // 
            // Down
            // 
            this.Down.AutoSize = true;
            this.Down.Location = new System.Drawing.Point(65, 185);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(41, 16);
            this.Down.TabIndex = 6;
            this.Down.Text = "Down";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Right";
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Location = new System.Drawing.Point(68, 327);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(31, 16);
            this.Link.TabIndex = 9;
            this.Link.Text = "Link";
            // 
            // TOP
            // 
            this.TOP.AutoSize = true;
            this.TOP.Location = new System.Drawing.Point(65, 127);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(32, 16);
            this.TOP.TabIndex = 10;
            this.TOP.Text = "Top";
            // 
            // Top2
            // 
            this.Top2.Location = new System.Drawing.Point(194, 124);
            this.Top2.Name = "Top2";
            this.Top2.Size = new System.Drawing.Size(100, 22);
            this.Top2.TabIndex = 11;
            this.Top2.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // SymbolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.Top2);
            this.Controls.Add(this.TOP);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Downing);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Linking);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Cancel);
            this.Name = "SymbolWindow";
            this.Text = "SymbolWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.TextBox Linking;
        private System.Windows.Forms.TextBox Right;
        private System.Windows.Forms.TextBox Left;
        private System.Windows.Forms.TextBox Downing;
        private System.Windows.Forms.Label Down;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Link;
        private System.Windows.Forms.Label TOP;
        private System.Windows.Forms.TextBox Top2;
    }
}