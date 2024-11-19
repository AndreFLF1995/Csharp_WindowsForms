namespace Exercicio1_Calculadora
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
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.btn_total = new System.Windows.Forms.Button();
            this.grpBox_op = new System.Windows.Forms.GroupBox();
            this.rdoBtn_div = new System.Windows.Forms.RadioButton();
            this.rdoBtn_mult = new System.Windows.Forms.RadioButton();
            this.rdoBtn_sub = new System.Windows.Forms.RadioButton();
            this.rdoBtn_add = new System.Windows.Forms.RadioButton();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.grpBox_op.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num1.Location = new System.Drawing.Point(108, 55);
            this.lbl_num1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(94, 24);
            this.lbl_num1.TabIndex = 0;
            this.lbl_num1.Text = "Número 1";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num2.Location = new System.Drawing.Point(108, 144);
            this.lbl_num2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(94, 24);
            this.lbl_num2.TabIndex = 1;
            this.lbl_num2.Text = "Número 2";
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_res.Location = new System.Drawing.Point(108, 400);
            this.lbl_res.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(94, 24);
            this.lbl_res.TabIndex = 2;
            this.lbl_res.Text = "Resultado";
            // 
            // btn_total
            // 
            this.btn_total.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_total.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_total.Location = new System.Drawing.Point(498, 383);
            this.btn_total.Margin = new System.Windows.Forms.Padding(6);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(237, 58);
            this.btn_total.TabIndex = 3;
            this.btn_total.Text = "Total";
            this.btn_total.UseVisualStyleBackColor = false;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // grpBox_op
            // 
            this.grpBox_op.Controls.Add(this.rdoBtn_div);
            this.grpBox_op.Controls.Add(this.rdoBtn_mult);
            this.grpBox_op.Controls.Add(this.rdoBtn_sub);
            this.grpBox_op.Controls.Add(this.rdoBtn_add);
            this.grpBox_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_op.Location = new System.Drawing.Point(103, 236);
            this.grpBox_op.Margin = new System.Windows.Forms.Padding(6);
            this.grpBox_op.Name = "grpBox_op";
            this.grpBox_op.Padding = new System.Windows.Forms.Padding(6);
            this.grpBox_op.Size = new System.Drawing.Size(367, 122);
            this.grpBox_op.TabIndex = 6;
            this.grpBox_op.TabStop = false;
            this.grpBox_op.Text = "Operador";
            // 
            // rdoBtn_div
            // 
            this.rdoBtn_div.AutoSize = true;
            this.rdoBtn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtn_div.Location = new System.Drawing.Point(263, 79);
            this.rdoBtn_div.Margin = new System.Windows.Forms.Padding(6);
            this.rdoBtn_div.Name = "rdoBtn_div";
            this.rdoBtn_div.Size = new System.Drawing.Size(79, 28);
            this.rdoBtn_div.TabIndex = 3;
            this.rdoBtn_div.TabStop = true;
            this.rdoBtn_div.Text = "Dividir";
            this.rdoBtn_div.UseVisualStyleBackColor = true;
            // 
            // rdoBtn_mult
            // 
            this.rdoBtn_mult.AutoSize = true;
            this.rdoBtn_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtn_mult.Location = new System.Drawing.Point(9, 79);
            this.rdoBtn_mult.Margin = new System.Windows.Forms.Padding(6);
            this.rdoBtn_mult.Name = "rdoBtn_mult";
            this.rdoBtn_mult.Size = new System.Drawing.Size(112, 28);
            this.rdoBtn_mult.TabIndex = 2;
            this.rdoBtn_mult.TabStop = true;
            this.rdoBtn_mult.Text = "Multiplicar";
            this.rdoBtn_mult.UseVisualStyleBackColor = true;
            // 
            // rdoBtn_sub
            // 
            this.rdoBtn_sub.AutoSize = true;
            this.rdoBtn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtn_sub.Location = new System.Drawing.Point(263, 30);
            this.rdoBtn_sub.Margin = new System.Windows.Forms.Padding(6);
            this.rdoBtn_sub.Name = "rdoBtn_sub";
            this.rdoBtn_sub.Size = new System.Drawing.Size(92, 28);
            this.rdoBtn_sub.TabIndex = 1;
            this.rdoBtn_sub.TabStop = true;
            this.rdoBtn_sub.Text = "Subtraír";
            this.rdoBtn_sub.UseVisualStyleBackColor = true;
            // 
            // rdoBtn_add
            // 
            this.rdoBtn_add.AutoSize = true;
            this.rdoBtn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtn_add.Location = new System.Drawing.Point(11, 30);
            this.rdoBtn_add.Margin = new System.Windows.Forms.Padding(6);
            this.rdoBtn_add.Name = "rdoBtn_add";
            this.rdoBtn_add.Size = new System.Drawing.Size(108, 28);
            this.rdoBtn_add.TabIndex = 0;
            this.rdoBtn_add.TabStop = true;
            this.rdoBtn_add.Text = "Adicionar";
            this.rdoBtn_add.UseVisualStyleBackColor = true;
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(290, 50);
            this.txt_n1.Margin = new System.Windows.Forms.Padding(6);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(180, 29);
            this.txt_n1.TabIndex = 7;
            this.txt_n1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(290, 139);
            this.txt_n2.Margin = new System.Windows.Forms.Padding(6);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(180, 29);
            this.txt_n2.TabIndex = 8;
            this.txt_n2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(290, 397);
            this.txt_total.Margin = new System.Windows.Forms.Padding(6);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(180, 29);
            this.txt_total.TabIndex = 9;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_clear.Location = new System.Drawing.Point(498, 316);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(237, 58);
            this.btn_clear.TabIndex = 19;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 496);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.grpBox_op);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.grpBox_op.ResumeLayout(false);
            this.grpBox_op.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.GroupBox grpBox_op;
        private System.Windows.Forms.RadioButton rdoBtn_div;
        private System.Windows.Forms.RadioButton rdoBtn_mult;
        private System.Windows.Forms.RadioButton rdoBtn_sub;
        private System.Windows.Forms.RadioButton rdoBtn_add;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_clear;
    }
}