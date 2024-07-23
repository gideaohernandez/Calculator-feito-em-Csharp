namespace Calculator
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.txtresult = new System.Windows.Forms.TextBox();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.btmult = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btsub = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btsoma = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btresult = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.fechar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ElipseCalcu = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtresult
            // 
            this.txtresult.BackColor = System.Drawing.Color.Black;
            this.txtresult.ForeColor = System.Drawing.Color.White;
            this.txtresult.Location = new System.Drawing.Point(27, 59);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(215, 20);
            this.txtresult.TabIndex = 0;
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.White;
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.ForeColor = System.Drawing.Color.Black;
            this.bt7.Location = new System.Drawing.Point(3, 77);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(64, 68);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.White;
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.ForeColor = System.Drawing.Color.Black;
            this.bt8.Location = new System.Drawing.Point(73, 77);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(64, 68);
            this.bt8.TabIndex = 2;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.White;
            this.bt9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.ForeColor = System.Drawing.Color.Black;
            this.bt9.Location = new System.Drawing.Point(143, 77);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(63, 68);
            this.bt9.TabIndex = 3;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btdiv
            // 
            this.btdiv.BackColor = System.Drawing.Color.White;
            this.btdiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdiv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdiv.ForeColor = System.Drawing.Color.Black;
            this.btdiv.Location = new System.Drawing.Point(143, 3);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(63, 68);
            this.btdiv.TabIndex = 4;
            this.btdiv.Text = "/";
            this.btdiv.UseVisualStyleBackColor = false;
            this.btdiv.Click += new System.EventHandler(this.operadores);
            // 
            // btmult
            // 
            this.btmult.BackColor = System.Drawing.Color.White;
            this.btmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmult.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmult.ForeColor = System.Drawing.Color.Black;
            this.btmult.Location = new System.Drawing.Point(73, 3);
            this.btmult.Name = "btmult";
            this.btmult.Size = new System.Drawing.Size(64, 68);
            this.btmult.TabIndex = 8;
            this.btmult.Text = "x";
            this.btmult.UseVisualStyleBackColor = false;
            this.btmult.Click += new System.EventHandler(this.operadores);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.White;
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.ForeColor = System.Drawing.Color.Black;
            this.bt6.Location = new System.Drawing.Point(143, 151);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(63, 68);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.White;
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.ForeColor = System.Drawing.Color.Black;
            this.bt5.Location = new System.Drawing.Point(73, 151);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(64, 68);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.White;
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.ForeColor = System.Drawing.Color.Black;
            this.bt4.Location = new System.Drawing.Point(3, 151);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(64, 68);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btsub
            // 
            this.btsub.BackColor = System.Drawing.Color.White;
            this.btsub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsub.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsub.ForeColor = System.Drawing.Color.Black;
            this.btsub.Location = new System.Drawing.Point(3, 3);
            this.btsub.Name = "btsub";
            this.btsub.Size = new System.Drawing.Size(59, 68);
            this.btsub.TabIndex = 12;
            this.btsub.Text = "-";
            this.btsub.UseVisualStyleBackColor = false;
            this.btsub.Click += new System.EventHandler(this.operadores);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.White;
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.Color.Black;
            this.bt3.Location = new System.Drawing.Point(143, 225);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(63, 68);
            this.bt3.TabIndex = 11;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.White;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.Color.Black;
            this.bt2.Location = new System.Drawing.Point(73, 225);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(64, 68);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.gerarnumero);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.White;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.Color.Black;
            this.bt1.Location = new System.Drawing.Point(3, 225);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(64, 68);
            this.bt1.TabIndex = 9;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btsoma
            // 
            this.btsoma.BackColor = System.Drawing.Color.White;
            this.btsoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsoma.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsoma.ForeColor = System.Drawing.Color.Black;
            this.btsoma.Location = new System.Drawing.Point(3, 77);
            this.btsoma.Name = "btsoma";
            this.btsoma.Size = new System.Drawing.Size(59, 68);
            this.btsoma.TabIndex = 16;
            this.btsoma.Text = "+";
            this.btsoma.UseVisualStyleBackColor = false;
            this.btsoma.Click += new System.EventHandler(this.operadores);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.Color.White;
            this.bt0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt0.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.ForeColor = System.Drawing.Color.Black;
            this.bt0.Location = new System.Drawing.Point(3, 225);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(59, 68);
            this.bt0.TabIndex = 15;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.gerarnumero);
            // 
            // btresult
            // 
            this.btresult.BackColor = System.Drawing.Color.White;
            this.btresult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btresult.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btresult.ForeColor = System.Drawing.Color.Black;
            this.btresult.Location = new System.Drawing.Point(3, 151);
            this.btresult.Name = "btresult";
            this.btresult.Size = new System.Drawing.Size(59, 68);
            this.btresult.TabIndex = 14;
            this.btresult.Text = "=";
            this.btresult.UseVisualStyleBackColor = false;
            this.btresult.Click += new System.EventHandler(this.btresult_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.White;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.Black;
            this.btLimpar.Location = new System.Drawing.Point(3, 3);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(64, 68);
            this.btLimpar.TabIndex = 13;
            this.btLimpar.Text = "Clean";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Controls.Add(this.fechar);
            this.panel1.Controls.Add(this.txtresult);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 95);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculator.Properties.Resources.calcu_32;
            this.pictureBox1.Location = new System.Drawing.Point(74, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Calculator";
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(194, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(36, 29);
            this.gunaControlBox1.TabIndex = 19;
            // 
            // fechar
            // 
            this.fechar.Image = global::Calculator.Properties.Resources.fechar_16;
            this.fechar.Location = new System.Drawing.Point(236, 0);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(32, 29);
            this.fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fechar.TabIndex = 18;
            this.fechar.TabStop = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.bt1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btLimpar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btmult, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btdiv, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt9, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(212, 296);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btresult, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btsoma, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btsub, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt0, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(207, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(72, 296);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "CopyRight 2023 - Gideão Hernández";
            // 
            // ElipseCalcu
            // 
            this.ElipseCalcu.Radius = 5;
            this.ElipseCalcu.TargetControl = this;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(271, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.Button btmult;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btsub;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btsoma;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btresult;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox fechar;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaElipse ElipseCalcu;
    }
}

