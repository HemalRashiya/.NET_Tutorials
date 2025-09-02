namespace TutorialSix
{
    partial class RestrictedPolicy
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
            label1 = new Label();
            numeric = new TextBox();
            upper = new TextBox();
            label2 = new Label();
            characters = new TextBox();
            label3 = new Label();
            sub = new Button();
            display = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 30);
            label1.Name = "label1";
            label1.Size = new Size(208, 30);
            label1.TabIndex = 0;
            label1.Text = "Numeric Data Only:-";
            // 
            // numeric
            // 
            numeric.Location = new Point(243, 27);
            numeric.Name = "numeric";
            numeric.Size = new Size(145, 35);
            numeric.TabIndex = 1;
            numeric.KeyPress += numkey;
            // 
            // upper
            // 
            upper.Location = new Point(243, 90);
            upper.Name = "upper";
            upper.Size = new Size(145, 35);
            upper.TabIndex = 3;
            upper.KeyPress += upperkey;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 93);
            label2.Name = "label2";
            label2.Size = new Size(228, 30);
            label2.TabIndex = 2;
            label2.Text = "Uppercase Data Only:-";
            // 
            // characters
            // 
            characters.Location = new Point(243, 154);
            characters.Name = "characters";
            characters.Size = new Size(145, 35);
            characters.TabIndex = 5;
            characters.TextChanged += characters_TextChanged;
            characters.KeyPress += charonly;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 157);
            label3.Name = "label3";
            label3.Size = new Size(219, 30);
            label3.TabIndex = 4;
            label3.Text = "Character Data Only:-";
            // 
            // sub
            // 
            sub.Location = new Point(149, 222);
            sub.Name = "sub";
            sub.Size = new Size(94, 29);
            sub.TabIndex = 6;
            sub.Text = "Submit";
            sub.UseVisualStyleBackColor = true;
            sub.Click += sub_Click;
            // 
            // display
            // 
            display.AutoSize = true;
            display.Location = new Point(173, 297);
            display.Name = "display";
            display.Size = new Size(58, 30);
            display.TabIndex = 7;
            display.Text = "Data";
            display.Visible = false;
            // 
            // RestrictedPolicy
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(429, 338);
            Controls.Add(display);
            Controls.Add(sub);
            Controls.Add(characters);
            Controls.Add(label3);
            Controls.Add(upper);
            Controls.Add(label2);
            Controls.Add(numeric);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RestrictedPolicy";
            Text = "RestrictedPolicy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numeric;
        private TextBox upper;
        private Label label2;
        private TextBox characters;
        private Label label3;
        private Button sub;
        private Label display;
    }
}