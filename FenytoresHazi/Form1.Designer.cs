namespace FenytoresHazi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.alfaInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.n2Input = new System.Windows.Forms.NumericUpDown();
            this.n1Input = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alfaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n1Input)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(12, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "alfa:";
            // 
            // alfaInput
            // 
            this.alfaInput.Location = new System.Drawing.Point(50, 7);
            this.alfaInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.alfaInput.Name = "alfaInput";
            this.alfaInput.Size = new System.Drawing.Size(58, 20);
            this.alfaInput.TabIndex = 2;
            this.alfaInput.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.alfaInput.ValueChanged += new System.EventHandler(this.alfaInput_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "n1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "n2:";
            // 
            // n2Input
            // 
            this.n2Input.DecimalPlaces = 2;
            this.n2Input.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.n2Input.Location = new System.Drawing.Point(254, 7);
            this.n2Input.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.n2Input.Name = "n2Input";
            this.n2Input.Size = new System.Drawing.Size(58, 20);
            this.n2Input.TabIndex = 6;
            this.n2Input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n2Input.ValueChanged += new System.EventHandler(this.n2Input_ValueChanged);
            // 
            // n1Input
            // 
            this.n1Input.DecimalPlaces = 2;
            this.n1Input.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.n1Input.Location = new System.Drawing.Point(152, 7);
            this.n1Input.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.n1Input.Name = "n1Input";
            this.n1Input.Size = new System.Drawing.Size(58, 20);
            this.n1Input.TabIndex = 7;
            this.n1Input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n1Input.ValueChanged += new System.EventHandler(this.n1Input_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "beta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 255);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n1Input);
            this.Controls.Add(this.n2Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alfaInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alfaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n1Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown alfaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown n2Input;
        private System.Windows.Forms.NumericUpDown n1Input;
        private System.Windows.Forms.Label label4;
    }
}

