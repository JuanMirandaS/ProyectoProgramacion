namespace ProyectoProgramacion
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            ID = new Label();
            label0 = new Label();
            label1 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ID);
            groupBox1.Controls.Add(label0);
            groupBox1.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(657, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Fluent Icons", 14.25F);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(386, 304);
            button1.Name = "button1";
            button1.Size = new Size(102, 50);
            button1.TabIndex = 9;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(170, 267);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(67, 28);
            numericUpDown1.TabIndex = 8;
            // 
            // label4
            // 
            label4.Location = new Point(22, 267);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 7;
            label4.Text = "Horas totales";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 148);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(463, 100);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.Location = new Point(22, 148);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 4;
            label3.Text = "Descripción";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(463, 28);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(22, 87);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 2;
            label2.Text = "Proyecto";
            // 
            // ID
            // 
            ID.Location = new Point(81, 29);
            ID.Name = "ID";
            ID.Size = new Size(39, 28);
            ID.TabIndex = 1;
            ID.Text = "00";
            // 
            // label0
            // 
            label0.Location = new Point(22, 29);
            label0.Name = "label0";
            label0.Size = new Size(44, 28);
            label0.TabIndex = 0;
            label0.Text = "ID";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(657, 57);
            label1.TabIndex = 2;
            label1.Text = "Gestión de Proyectos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Fluent Icons", 14.25F);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(531, 304);
            button2.Name = "button2";
            button2.Size = new Size(102, 50);
            button2.TabIndex = 10;
            button2.Text = "Limpiar Campos";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 519);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label ID;
        private Label label0;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Button button2;
    }
}
