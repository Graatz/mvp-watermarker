namespace MVPMarker
{
    partial class MarkerForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageControl = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.opacityControl = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeControl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.fontControl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textControl = new System.Windows.Forms.TextBox();
            this.applyControl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageControl)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeControl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.imageControl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 562);
            this.panel1.TabIndex = 0;
            // 
            // imageControl
            // 
            this.imageControl.Location = new System.Drawing.Point(3, 3);
            this.imageControl.Name = "imageControl";
            this.imageControl.Size = new System.Drawing.Size(742, 556);
            this.imageControl.TabIndex = 0;
            this.imageControl.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.opacityControl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sizeControl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fontControl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textControl);
            this.groupBox1.Controls.Add(this.applyControl);
            this.groupBox1.Location = new System.Drawing.Point(12, 580);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opacity:";
            // 
            // opacityControl
            // 
            this.opacityControl.Location = new System.Drawing.Point(435, 30);
            this.opacityControl.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.opacityControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.opacityControl.Name = "opacityControl";
            this.opacityControl.Size = new System.Drawing.Size(296, 20);
            this.opacityControl.TabIndex = 7;
            this.opacityControl.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Size:";
            // 
            // sizeControl
            // 
            this.sizeControl.Location = new System.Drawing.Point(57, 83);
            this.sizeControl.Name = "sizeControl";
            this.sizeControl.Size = new System.Drawing.Size(284, 20);
            this.sizeControl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Font:";
            // 
            // fontControl
            // 
            this.fontControl.FormattingEnabled = true;
            this.fontControl.Location = new System.Drawing.Point(57, 56);
            this.fontControl.Name = "fontControl";
            this.fontControl.Size = new System.Drawing.Size(284, 21);
            this.fontControl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text:";
            // 
            // textControl
            // 
            this.textControl.Location = new System.Drawing.Point(57, 30);
            this.textControl.Name = "textControl";
            this.textControl.Size = new System.Drawing.Size(284, 20);
            this.textControl.TabIndex = 1;
            // 
            // applyControl
            // 
            this.applyControl.Location = new System.Drawing.Point(656, 80);
            this.applyControl.Name = "applyControl";
            this.applyControl.Size = new System.Drawing.Size(75, 23);
            this.applyControl.TabIndex = 0;
            this.applyControl.Text = "Apply";
            this.applyControl.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(303, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Drag and drop";
            // 
            // MarkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 717);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MarkerForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageControl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imageControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sizeControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fontControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textControl;
        private System.Windows.Forms.Button applyControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown opacityControl;
        private System.Windows.Forms.Label label5;
    }
}

