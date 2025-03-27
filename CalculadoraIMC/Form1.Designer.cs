namespace CalculadoraIMC
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
            butt = new Button();
            label2 = new Label();
            cxa1 = new TextBox();
            cxa2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            classif = new Label();
            recom = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 150);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Peso (KG)";
            label1.Click += label1_Click;
            // 
            // butt
            // 
            butt.BackColor = Color.FloralWhite;
            butt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butt.ForeColor = SystemColors.ActiveCaptionText;
            butt.Location = new Point(267, 317);
            butt.Name = "butt";
            butt.Size = new Size(92, 34);
            butt.TabIndex = 1;
            butt.Text = "Calcular";
            butt.UseVisualStyleBackColor = false;
            butt.Click += butt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 207);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Altura (m)";
            // 
            // cxa1
            // 
            cxa1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cxa1.Location = new Point(133, 150);
            cxa1.Name = "cxa1";
            cxa1.Size = new Size(125, 27);
            cxa1.TabIndex = 3;
            // 
            // cxa2
            // 
            cxa2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cxa2.Location = new Point(133, 207);
            cxa2.Name = "cxa2";
            cxa2.Size = new Size(125, 27);
            cxa2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 34);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 5;
            label3.Text = "Calculadora IMC";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 85);
            label4.Name = "label4";
            label4.Size = new Size(192, 20);
            label4.TabIndex = 6;
            label4.Text = "Digite os dados solicitados:";
            label4.Click += label4_Click;
            // 
            // classif
            // 
            classif.AutoSize = true;
            classif.Location = new Point(12, 273);
            classif.Name = "classif";
            classif.Size = new Size(13, 20);
            classif.TabIndex = 7;
            classif.Text = " ";
            classif.Click += classif_Click;
            // 
            // recom
            // 
            recom.AutoSize = true;
            recom.Location = new Point(40, 292);
            recom.Name = "recom";
            recom.Size = new Size(13, 20);
            recom.TabIndex = 8;
            recom.Text = " ";
            recom.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 363);
            Controls.Add(recom);
            Controls.Add(classif);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cxa2);
            Controls.Add(cxa1);
            Controls.Add(label2);
            Controls.Add(butt);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calculadora IMC";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button butt;
        private Label label2;
        private TextBox cxa1;
        private TextBox cxa2;
        private Label label3;
        private Label label4;
        private Label classif;
        private Label recom;
    }
}
