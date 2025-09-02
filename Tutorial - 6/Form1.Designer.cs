namespace TutorialSix
{
    partial class Form1
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
            label1 = new Label();
            name = new TextBox();
            label2 = new Label();
            male = new RadioButton();
            female = new RadioButton();
            label3 = new Label();
            news = new CheckBox();
            friends = new CheckBox();
            oth = new CheckBox();
            website = new CheckBox();
            submit = new Button();
            display = new Label();
            spec = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // name
            // 
            name.Location = new Point(121, 31);
            name.Name = "name";
            name.Size = new Size(125, 27);
            name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(29, 84);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 2;
            label2.Text = "Gender";
            label2.Click += label2_Click;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(121, 89);
            male.Name = "male";
            male.Size = new Size(63, 24);
            male.TabIndex = 3;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(201, 88);
            female.Name = "female";
            female.Size = new Size(78, 24);
            female.TabIndex = 4;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(44, 132);
            label3.Name = "label3";
            label3.Size = new Size(216, 28);
            label3.TabIndex = 5;
            label3.Text = "Source Of Information";
            // 
            // news
            // 
            news.AutoSize = true;
            news.Location = new Point(44, 181);
            news.Name = "news";
            news.Size = new Size(108, 24);
            news.TabIndex = 6;
            news.Text = "News Paper";
            news.UseVisualStyleBackColor = true;
            // 
            // friends
            // 
            friends.AutoSize = true;
            friends.Location = new Point(159, 181);
            friends.Name = "friends";
            friends.Size = new Size(78, 24);
            friends.TabIndex = 7;
            friends.Text = "Friends";
            friends.UseVisualStyleBackColor = true;
            // 
            // oth
            // 
            oth.AutoSize = true;
            oth.Location = new Point(159, 223);
            oth.Name = "oth";
            oth.Size = new Size(74, 24);
            oth.TabIndex = 9;
            oth.Text = "Others";
            oth.UseVisualStyleBackColor = true;
            // 
            // website
            // 
            website.AutoSize = true;
            website.Location = new Point(44, 223);
            website.Name = "website";
            website.Size = new Size(84, 24);
            website.TabIndex = 8;
            website.Text = "Website";
            website.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            submit.AutoEllipsis = true;
            submit.BackColor = SystemColors.ButtonHighlight;
            submit.Cursor = Cursors.Hand;
            submit.ForeColor = SystemColors.ActiveCaptionText;
            submit.Location = new Point(90, 320);
            submit.Name = "submit";
            submit.Size = new Size(143, 49);
            submit.TabIndex = 10;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // display
            // 
            display.AutoSize = true;
            display.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            display.Location = new Point(44, 392);
            display.Name = "display";
            display.Size = new Size(0, 28);
            display.TabIndex = 11;
            display.Visible = false;
            // 
            // spec
            // 
            spec.Location = new Point(203, 265);
            spec.Name = "spec";
            spec.Size = new Size(125, 27);
            spec.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(43, 264);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 12;
            label4.Text = "If other, Specify";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(spec);
            Controls.Add(label4);
            Controls.Add(display);
            Controls.Add(submit);
            Controls.Add(oth);
            Controls.Add(website);
            Controls.Add(friends);
            Controls.Add(news);
            Controls.Add(label3);
            Controls.Add(female);
            Controls.Add(male);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private Label label2;
        private RadioButton male;
        private RadioButton female;
        private Label label3;
        private CheckBox news;
        private CheckBox friends;
        private CheckBox oth;
        private CheckBox website;
        private Button submit;
        private Label display;
        private TextBox spec;
        private Label label4;
    }
}
