namespace Calculatrice
{
    partial class Calculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_decimal = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_opposed = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_substract = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_display = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_equal, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_decimal, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_opposed, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_add, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_substract, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_multiply, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_divide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_C, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_CE, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_delete, 2, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 160);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 280);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_equal
            // 
            this.btn_equal.Location = new System.Drawing.Point(228, 227);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(69, 50);
            this.btn_equal.TabIndex = 19;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_decimal
            // 
            this.btn_decimal.Location = new System.Drawing.Point(153, 227);
            this.btn_decimal.Name = "btn_decimal";
            this.btn_decimal.Size = new System.Drawing.Size(69, 50);
            this.btn_decimal.TabIndex = 18;
            this.btn_decimal.Text = ",";
            this.btn_decimal.UseVisualStyleBackColor = true;
            this.btn_decimal.Click += new System.EventHandler(this.btn_decimal_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(78, 227);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(69, 50);
            this.btn_0.TabIndex = 17;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_opposed
            // 
            this.btn_opposed.Location = new System.Drawing.Point(3, 227);
            this.btn_opposed.Name = "btn_opposed";
            this.btn_opposed.Size = new System.Drawing.Size(69, 50);
            this.btn_opposed.TabIndex = 16;
            this.btn_opposed.Text = "+-";
            this.btn_opposed.UseVisualStyleBackColor = true;
            this.btn_opposed.Click += new System.EventHandler(this.btn_opposed_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(228, 171);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(69, 50);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = " + ";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(153, 171);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(69, 50);
            this.btn_3.TabIndex = 14;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(78, 171);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(69, 50);
            this.btn_2.TabIndex = 13;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(3, 171);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(69, 50);
            this.btn_1.TabIndex = 12;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_substract
            // 
            this.btn_substract.Location = new System.Drawing.Point(228, 115);
            this.btn_substract.Name = "btn_substract";
            this.btn_substract.Size = new System.Drawing.Size(69, 50);
            this.btn_substract.TabIndex = 11;
            this.btn_substract.Text = " - ";
            this.btn_substract.UseVisualStyleBackColor = true;
            this.btn_substract.Click += new System.EventHandler(this.btn_substract_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(153, 115);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(69, 50);
            this.btn_6.TabIndex = 10;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(78, 115);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(69, 50);
            this.btn_5.TabIndex = 9;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(3, 115);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(69, 50);
            this.btn_4.TabIndex = 8;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Location = new System.Drawing.Point(228, 59);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(69, 50);
            this.btn_multiply.TabIndex = 7;
            this.btn_multiply.Text = " * ";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(153, 59);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(69, 50);
            this.btn_9.TabIndex = 6;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(78, 59);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(69, 50);
            this.btn_8.TabIndex = 5;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(3, 59);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(69, 50);
            this.btn_7.TabIndex = 4;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(228, 3);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(69, 50);
            this.btn_divide.TabIndex = 3;
            this.btn_divide.Text = " / ";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_C
            // 
            this.btn_C.Location = new System.Drawing.Point(78, 3);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(69, 50);
            this.btn_C.TabIndex = 1;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.Location = new System.Drawing.Point(3, 3);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(69, 50);
            this.btn_CE.TabIndex = 0;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(153, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 50);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "<--";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_display
            // 
            this.txt_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_display.Location = new System.Drawing.Point(17, 24);
            this.txt_display.Margin = new System.Windows.Forms.Padding(10);
            this.txt_display.Name = "txt_display";
            this.txt_display.ReadOnly = true;
            this.txt_display.Size = new System.Drawing.Size(300, 111);
            this.txt_display.TabIndex = 1;
            this.txt_display.Text = "";
            // 
            // Calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 453);
            this.Controls.Add(this.txt_display);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Calculatrice";
            this.Text = "Calculatrice";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_decimal;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_opposed;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_substract;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.RichTextBox txt_display;
    }
}

