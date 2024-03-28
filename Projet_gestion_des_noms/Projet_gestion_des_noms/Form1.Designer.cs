namespace Projet_gestion_des_noms
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
            listNoms = new ListBox();
            label1 = new Label();
            label2 = new Label();
            Button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listNoms
            // 
            listNoms.FormattingEnabled = true;
            listNoms.ItemHeight = 15;
            listNoms.Location = new Point(36, 77);
            listNoms.Name = "listNoms";
            listNoms.Size = new Size(141, 229);
            listNoms.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 59);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Liste des noms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 59);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Nom";
            // 
            // Button1
            // 
            Button1.Location = new Point(343, 127);
            Button1.Name = "Button1";
            Button1.Size = new Size(204, 32);
            Button1.TabIndex = 3;
            Button1.Text = "Enregistrer";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(343, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 377);
            Controls.Add(textBox1);
            Controls.Add(Button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listNoms);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listNoms;
        private Label label1;
        private Label label2;
        private Button Button1;
        private TextBox textBox1;
    }
}
