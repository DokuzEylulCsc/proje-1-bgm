namespace WindowsFormsApp1
{
    partial class Tur
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.zorlukLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sureLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cozulmeyenLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.soruLabel = new System.Windows.Forms.Label();
            this.harfPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yerAlanLabel = new System.Windows.Forms.Label();
            this.eslesenLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zorluk :";
            // 
            // zorlukLabel
            // 
            this.zorlukLabel.AutoSize = true;
            this.zorlukLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zorlukLabel.Location = new System.Drawing.Point(87, 9);
            this.zorlukLabel.Name = "zorlukLabel";
            this.zorlukLabel.Size = new System.Drawing.Size(52, 20);
            this.zorlukLabel.TabIndex = 1;
            this.zorlukLabel.Text = "Kolay";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(429, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kalan Süre :";
            // 
            // sureLabel
            // 
            this.sureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sureLabel.AutoSize = true;
            this.sureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sureLabel.Location = new System.Drawing.Point(542, 9);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(54, 20);
            this.sureLabel.TabIndex = 3;
            this.sureLabel.Text = "00:00";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(167, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Çözülmemiş Soru Sayısı :";
            // 
            // cozulmeyenLabel
            // 
            this.cozulmeyenLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cozulmeyenLabel.AutoSize = true;
            this.cozulmeyenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cozulmeyenLabel.Location = new System.Drawing.Point(383, 9);
            this.cozulmeyenLabel.Name = "cozulmeyenLabel";
            this.cozulmeyenLabel.Size = new System.Drawing.Size(19, 20);
            this.cozulmeyenLabel.TabIndex = 5;
            this.cozulmeyenLabel.Text = "8";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Önceki Soru";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(300, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sonraki Soru";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(9, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 45);
            this.panel1.TabIndex = 8;
            // 
            // soruLabel
            // 
            this.soruLabel.AutoSize = true;
            this.soruLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruLabel.Location = new System.Drawing.Point(304, 64);
            this.soruLabel.Name = "soruLabel";
            this.soruLabel.Size = new System.Drawing.Size(27, 29);
            this.soruLabel.TabIndex = 10;
            this.soruLabel.Text = "8";
            // 
            // harfPanel
            // 
            this.harfPanel.AutoSize = true;
            this.harfPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.harfPanel.Location = new System.Drawing.Point(12, 123);
            this.harfPanel.Name = "harfPanel";
            this.harfPanel.Size = new System.Drawing.Size(0, 0);
            this.harfPanel.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(215, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Soru : ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sözcükte yer alan harfler : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Eşleşme sağlanan harfler : ";
            // 
            // yerAlanLabel
            // 
            this.yerAlanLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yerAlanLabel.AutoSize = true;
            this.yerAlanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yerAlanLabel.Location = new System.Drawing.Point(242, 185);
            this.yerAlanLabel.Name = "yerAlanLabel";
            this.yerAlanLabel.Size = new System.Drawing.Size(0, 20);
            this.yerAlanLabel.TabIndex = 16;
            // 
            // eslesenLabel
            // 
            this.eslesenLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eslesenLabel.AutoSize = true;
            this.eslesenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eslesenLabel.Location = new System.Drawing.Point(242, 209);
            this.eslesenLabel.Name = "eslesenLabel";
            this.eslesenLabel.Size = new System.Drawing.Size(0, 20);
            this.eslesenLabel.TabIndex = 17;
            // 
            // Tur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 302);
            this.Controls.Add(this.eslesenLabel);
            this.Controls.Add(this.yerAlanLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.harfPanel);
            this.Controls.Add(this.soruLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cozulmeyenLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sureLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zorlukLabel);
            this.Controls.Add(this.label1);
            this.Name = "Tur";
            this.Text = "Tur";
            this.Load += new System.EventHandler(this.Tur_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zorlukLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cozulmeyenLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel harfPanel;
        private System.Windows.Forms.Label soruLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label yerAlanLabel;
        private System.Windows.Forms.Label eslesenLabel;
    }
}