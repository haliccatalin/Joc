namespace Joc
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
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_numeJucator1 = new System.Windows.Forms.Label();
            this.lbl_numeJucator2 = new System.Windows.Forms.Label();
            this.lbl_scorJucator1 = new System.Windows.Forms.Label();
            this.lbl_scorJucator2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_iesire = new System.Windows.Forms.Button();
            this.groupBox_infoJucatori = new System.Windows.Forms.GroupBox();
            this.txt_numeJucator2 = new System.Windows.Forms.TextBox();
            this.txt_numeJucator1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picBox_loading = new System.Windows.Forms.PictureBox();
            this.picBox_jucator2 = new System.Windows.Forms.PictureBox();
            this.picBox_jucator1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_infoJucatori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_jucator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_jucator1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(6, 25);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(126, 65);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_numeJucator1
            // 
            this.lbl_numeJucator1.AutoSize = true;
            this.lbl_numeJucator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeJucator1.Location = new System.Drawing.Point(6, 38);
            this.lbl_numeJucator1.Name = "lbl_numeJucator1";
            this.lbl_numeJucator1.Size = new System.Drawing.Size(101, 26);
            this.lbl_numeJucator1.TabIndex = 3;
            this.lbl_numeJucator1.Text = "Jucator 1";
            // 
            // lbl_numeJucator2
            // 
            this.lbl_numeJucator2.AutoSize = true;
            this.lbl_numeJucator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeJucator2.Location = new System.Drawing.Point(209, 38);
            this.lbl_numeJucator2.Name = "lbl_numeJucator2";
            this.lbl_numeJucator2.Size = new System.Drawing.Size(101, 26);
            this.lbl_numeJucator2.TabIndex = 4;
            this.lbl_numeJucator2.Text = "Jucator 2";
            // 
            // lbl_scorJucator1
            // 
            this.lbl_scorJucator1.AutoSize = true;
            this.lbl_scorJucator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scorJucator1.Location = new System.Drawing.Point(25, 83);
            this.lbl_scorJucator1.Name = "lbl_scorJucator1";
            this.lbl_scorJucator1.Size = new System.Drawing.Size(51, 55);
            this.lbl_scorJucator1.TabIndex = 5;
            this.lbl_scorJucator1.Text = "0";
            // 
            // lbl_scorJucator2
            // 
            this.lbl_scorJucator2.AutoSize = true;
            this.lbl_scorJucator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scorJucator2.Location = new System.Drawing.Point(235, 83);
            this.lbl_scorJucator2.Name = "lbl_scorJucator2";
            this.lbl_scorJucator2.Size = new System.Drawing.Size(51, 55);
            this.lbl_scorJucator2.TabIndex = 6;
            this.lbl_scorJucator2.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_scorJucator2);
            this.groupBox1.Controls.Add(this.lbl_numeJucator1);
            this.groupBox1.Controls.Add(this.lbl_scorJucator1);
            this.groupBox1.Controls.Add(this.lbl_numeJucator2);
            this.groupBox1.Location = new System.Drawing.Point(498, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.btn_iesire);
            this.groupBox2.Controls.Add(this.btn_start);
            this.groupBox2.Location = new System.Drawing.Point(240, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Butoane";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(138, 25);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(126, 65);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Resetare";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_iesire
            // 
            this.btn_iesire.Location = new System.Drawing.Point(270, 25);
            this.btn_iesire.Name = "btn_iesire";
            this.btn_iesire.Size = new System.Drawing.Size(126, 65);
            this.btn_iesire.TabIndex = 2;
            this.btn_iesire.Text = "Iesire";
            this.btn_iesire.UseVisualStyleBackColor = true;
            this.btn_iesire.Click += new System.EventHandler(this.btn_iesire_Click);
            // 
            // groupBox_infoJucatori
            // 
            this.groupBox_infoJucatori.Controls.Add(this.txt_numeJucator2);
            this.groupBox_infoJucatori.Controls.Add(this.txt_numeJucator1);
            this.groupBox_infoJucatori.Controls.Add(this.label7);
            this.groupBox_infoJucatori.Controls.Add(this.label6);
            this.groupBox_infoJucatori.Location = new System.Drawing.Point(498, 194);
            this.groupBox_infoJucatori.Name = "groupBox_infoJucatori";
            this.groupBox_infoJucatori.Size = new System.Drawing.Size(316, 208);
            this.groupBox_infoJucatori.TabIndex = 9;
            this.groupBox_infoJucatori.TabStop = false;
            this.groupBox_infoJucatori.Text = "Informatii Jucatori";
            // 
            // txt_numeJucator2
            // 
            this.txt_numeJucator2.Location = new System.Drawing.Point(100, 108);
            this.txt_numeJucator2.Name = "txt_numeJucator2";
            this.txt_numeJucator2.Size = new System.Drawing.Size(180, 26);
            this.txt_numeJucator2.TabIndex = 3;
            // 
            // txt_numeJucator1
            // 
            this.txt_numeJucator1.Location = new System.Drawing.Point(100, 48);
            this.txt_numeJucator1.Name = "txt_numeJucator1";
            this.txt_numeJucator1.Size = new System.Drawing.Size(180, 26);
            this.txt_numeJucator1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Jucator 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Jucator 1";
            // 
            // picBox_loading
            // 
            this.picBox_loading.Location = new System.Drawing.Point(12, 12);
            this.picBox_loading.Name = "picBox_loading";
            this.picBox_loading.Size = new System.Drawing.Size(480, 390);
            this.picBox_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_loading.TabIndex = 12;
            this.picBox_loading.TabStop = false;
            // 
            // picBox_jucator2
            // 
            this.picBox_jucator2.Location = new System.Drawing.Point(255, 12);
            this.picBox_jucator2.Name = "picBox_jucator2";
            this.picBox_jucator2.Size = new System.Drawing.Size(237, 390);
            this.picBox_jucator2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_jucator2.TabIndex = 11;
            this.picBox_jucator2.TabStop = false;
            // 
            // picBox_jucator1
            // 
            this.picBox_jucator1.Location = new System.Drawing.Point(12, 12);
            this.picBox_jucator1.Name = "picBox_jucator1";
            this.picBox_jucator1.Size = new System.Drawing.Size(237, 390);
            this.picBox_jucator1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_jucator1.TabIndex = 10;
            this.picBox_jucator1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 533);
            this.Controls.Add(this.picBox_loading);
            this.Controls.Add(this.picBox_jucator2);
            this.Controls.Add(this.picBox_jucator1);
            this.Controls.Add(this.groupBox_infoJucatori);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piatra - Hartie - Foarfeca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_infoJucatori.ResumeLayout(false);
            this.groupBox_infoJucatori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_jucator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_jucator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_numeJucator1;
        private System.Windows.Forms.Label lbl_numeJucator2;
        private System.Windows.Forms.Label lbl_scorJucator1;
        private System.Windows.Forms.Label lbl_scorJucator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_iesire;
        private System.Windows.Forms.GroupBox groupBox_infoJucatori;
        private System.Windows.Forms.TextBox txt_numeJucator2;
        private System.Windows.Forms.TextBox txt_numeJucator1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picBox_jucator1;
        private System.Windows.Forms.PictureBox picBox_jucator2;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.PictureBox picBox_loading;
    }
}

