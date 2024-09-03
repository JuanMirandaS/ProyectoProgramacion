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
            numericIDProyecto = new NumericUpDown();
            btnLimpiarProyecto = new Button();
            btnGuardarProyecto = new Button();
            numHorasTotales = new NumericUpDown();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtProyecto = new TextBox();
            label2 = new Label();
            idProyecto = new Label();
            label0 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            groupBox2 = new GroupBox();
            numericIDTarea = new NumericUpDown();
            boxUsuarios = new ComboBox();
            label9 = new Label();
            txtTarea = new TextBox();
            boxArea = new ComboBox();
            label11 = new Label();
            boxProyecto = new ComboBox();
            label7 = new Label();
            btnLimpiarTarea = new Button();
            btnGuardarTarea = new Button();
            numHorasTarea = new NumericUpDown();
            label6 = new Label();
            label8 = new Label();
            idTarea = new Label();
            label10 = new Label();
            dataGridView2 = new DataGridView();
            btnEditarProyecto = new Button();
            btnEditarTarea = new Button();
            btnEliminarProyecto = new Button();
            btnEliminarTarea = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericIDProyecto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHorasTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericIDTarea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHorasTarea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericIDProyecto);
            groupBox1.Controls.Add(btnLimpiarProyecto);
            groupBox1.Controls.Add(btnGuardarProyecto);
            groupBox1.Controls.Add(numHorasTotales);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtProyecto);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(idProyecto);
            groupBox1.Controls.Add(label0);
            groupBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(657, 288);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // numericIDProyecto
            // 
            numericIDProyecto.Location = new Point(577, 21);
            numericIDProyecto.Name = "numericIDProyecto";
            numericIDProyecto.Size = new Size(56, 31);
            numericIDProyecto.TabIndex = 11;
            // 
            // btnLimpiarProyecto
            // 
            btnLimpiarProyecto.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarProyecto.ForeColor = Color.Red;
            btnLimpiarProyecto.Location = new Point(531, 206);
            btnLimpiarProyecto.Name = "btnLimpiarProyecto";
            btnLimpiarProyecto.Size = new Size(102, 33);
            btnLimpiarProyecto.TabIndex = 10;
            btnLimpiarProyecto.Text = "Limpiar";
            btnLimpiarProyecto.TextAlign = ContentAlignment.TopCenter;
            btnLimpiarProyecto.UseVisualStyleBackColor = true;
            btnLimpiarProyecto.Click += btnLimpiarProyecto_Click;
            // 
            // btnGuardarProyecto
            // 
            btnGuardarProyecto.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarProyecto.ForeColor = Color.Green;
            btnGuardarProyecto.ImageAlign = ContentAlignment.TopCenter;
            btnGuardarProyecto.Location = new Point(399, 206);
            btnGuardarProyecto.Name = "btnGuardarProyecto";
            btnGuardarProyecto.Size = new Size(102, 33);
            btnGuardarProyecto.TabIndex = 9;
            btnGuardarProyecto.Text = "Guardar";
            btnGuardarProyecto.TextAlign = ContentAlignment.TopCenter;
            btnGuardarProyecto.UseVisualStyleBackColor = true;
            btnGuardarProyecto.Click += btnGuardarProyecto_Click;
            // 
            // numHorasTotales
            // 
            numHorasTotales.Location = new Point(181, 158);
            numHorasTotales.Name = "numHorasTotales";
            numHorasTotales.Size = new Size(67, 31);
            numHorasTotales.TabIndex = 8;
            // 
            // label4
            // 
            label4.Location = new Point(22, 158);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 7;
            label4.Text = "Horas totales";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(181, 79);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(277, 56);
            txtDescripcion.TabIndex = 6;
            // 
            // label3
            // 
            label3.Location = new Point(22, 79);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 4;
            label3.Text = "Descripción";
            // 
            // txtProyecto
            // 
            txtProyecto.Location = new Point(181, 29);
            txtProyecto.Name = "txtProyecto";
            txtProyecto.Size = new Size(277, 31);
            txtProyecto.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(22, 29);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 2;
            label2.Text = "Nombre Proyecto";
            // 
            // idProyecto
            // 
            idProyecto.Location = new Point(581, 67);
            idProyecto.Name = "idProyecto";
            idProyecto.Size = new Size(39, 28);
            idProyecto.TabIndex = 1;
            idProyecto.Text = "00";
            // 
            // label0
            // 
            label0.Location = new Point(531, 24);
            label0.Name = "label0";
            label0.Size = new Size(44, 28);
            label0.TabIndex = 0;
            label0.Text = "ID";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(657, 57);
            label1.TabIndex = 2;
            label1.Text = "Gestión de Proyectos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(727, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(519, 192);
            dataGridView1.TabIndex = 3;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 372);
            label5.Name = "label5";
            label5.Size = new Size(657, 57);
            label5.TabIndex = 4;
            label5.Text = "Gestión de Tareas";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericIDTarea);
            groupBox2.Controls.Add(boxUsuarios);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtTarea);
            groupBox2.Controls.Add(boxArea);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(boxProyecto);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnLimpiarTarea);
            groupBox2.Controls.Add(btnGuardarTarea);
            groupBox2.Controls.Add(numHorasTarea);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(idTarea);
            groupBox2.Controls.Add(label10);
            groupBox2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 432);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(657, 300);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // numericIDTarea
            // 
            numericIDTarea.Location = new Point(577, 31);
            numericIDTarea.Name = "numericIDTarea";
            numericIDTarea.Size = new Size(56, 31);
            numericIDTarea.TabIndex = 11;
            // 
            // boxUsuarios
            // 
            boxUsuarios.FormattingEnabled = true;
            boxUsuarios.Location = new Point(172, 159);
            boxUsuarios.Name = "boxUsuarios";
            boxUsuarios.Size = new Size(222, 33);
            boxUsuarios.TabIndex = 17;
            // 
            // label9
            // 
            label9.Location = new Point(22, 159);
            label9.Name = "label9";
            label9.Size = new Size(144, 28);
            label9.TabIndex = 16;
            label9.Text = "Usuario asignado";
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(172, 31);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(286, 31);
            txtTarea.TabIndex = 11;
            // 
            // boxArea
            // 
            boxArea.FormattingEnabled = true;
            boxArea.Items.AddRange(new object[] { "Hardware", "Redes" });
            boxArea.Location = new Point(486, 71);
            boxArea.Name = "boxArea";
            boxArea.Size = new Size(147, 33);
            boxArea.TabIndex = 15;
            // 
            // label11
            // 
            label11.Location = new Point(422, 72);
            label11.Name = "label11";
            label11.Size = new Size(49, 28);
            label11.TabIndex = 14;
            label11.Text = "Area";
            // 
            // boxProyecto
            // 
            boxProyecto.DisplayMember = "2";
            boxProyecto.FormattingEnabled = true;
            boxProyecto.Location = new Point(172, 71);
            boxProyecto.Name = "boxProyecto";
            boxProyecto.Size = new Size(222, 33);
            boxProyecto.TabIndex = 13;
            // 
            // label7
            // 
            label7.Location = new Point(22, 31);
            label7.Name = "label7";
            label7.Size = new Size(144, 28);
            label7.TabIndex = 12;
            label7.Text = "Descripcion Tarea";
            // 
            // btnLimpiarTarea
            // 
            btnLimpiarTarea.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarTarea.ForeColor = Color.Red;
            btnLimpiarTarea.Location = new Point(531, 216);
            btnLimpiarTarea.Name = "btnLimpiarTarea";
            btnLimpiarTarea.Size = new Size(102, 32);
            btnLimpiarTarea.TabIndex = 10;
            btnLimpiarTarea.Text = "Limpiar";
            btnLimpiarTarea.TextAlign = ContentAlignment.TopCenter;
            btnLimpiarTarea.UseVisualStyleBackColor = true;
            btnLimpiarTarea.Click += btnLimpiarTarea_Click;
            // 
            // btnGuardarTarea
            // 
            btnGuardarTarea.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarTarea.ForeColor = Color.Green;
            btnGuardarTarea.Location = new Point(399, 216);
            btnGuardarTarea.Name = "btnGuardarTarea";
            btnGuardarTarea.Size = new Size(102, 32);
            btnGuardarTarea.TabIndex = 9;
            btnGuardarTarea.Text = "Guardar";
            btnGuardarTarea.TextAlign = ContentAlignment.TopCenter;
            btnGuardarTarea.UseVisualStyleBackColor = true;
            btnGuardarTarea.Click += btnGuardarTarea_Click;
            // 
            // numHorasTarea
            // 
            numHorasTarea.Location = new Point(172, 115);
            numHorasTarea.Name = "numHorasTarea";
            numHorasTarea.Size = new Size(67, 31);
            numHorasTarea.TabIndex = 8;
            // 
            // label6
            // 
            label6.Location = new Point(22, 117);
            label6.Name = "label6";
            label6.Size = new Size(123, 28);
            label6.TabIndex = 7;
            label6.Text = "Horas";
            // 
            // label8
            // 
            label8.Location = new Point(22, 71);
            label8.Name = "label8";
            label8.Size = new Size(144, 28);
            label8.TabIndex = 2;
            label8.Text = "Proyecto vinculado";
            // 
            // idTarea
            // 
            idTarea.Location = new Point(531, 127);
            idTarea.Name = "idTarea";
            idTarea.Size = new Size(39, 28);
            idTarea.TabIndex = 1;
            idTarea.Text = "00";
            // 
            // label10
            // 
            label10.Location = new Point(531, 31);
            label10.Name = "label10";
            label10.Size = new Size(44, 28);
            label10.TabIndex = 0;
            label10.Text = "ID";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(727, 423);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(519, 213);
            dataGridView2.TabIndex = 12;
            // 
            // btnEditarProyecto
            // 
            btnEditarProyecto.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditarProyecto.ForeColor = Color.Green;
            btnEditarProyecto.Location = new Point(727, 294);
            btnEditarProyecto.Name = "btnEditarProyecto";
            btnEditarProyecto.Size = new Size(83, 33);
            btnEditarProyecto.TabIndex = 11;
            btnEditarProyecto.Text = "Editar";
            btnEditarProyecto.TextAlign = ContentAlignment.TopCenter;
            btnEditarProyecto.UseVisualStyleBackColor = true;
            // 
            // btnEditarTarea
            // 
            btnEditarTarea.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditarTarea.ForeColor = Color.Green;
            btnEditarTarea.Location = new Point(727, 659);
            btnEditarTarea.Name = "btnEditarTarea";
            btnEditarTarea.Size = new Size(83, 33);
            btnEditarTarea.TabIndex = 13;
            btnEditarTarea.Text = "Editar";
            btnEditarTarea.TextAlign = ContentAlignment.TopCenter;
            btnEditarTarea.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProyecto
            // 
            btnEliminarProyecto.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarProyecto.ForeColor = Color.Red;
            btnEliminarProyecto.Location = new Point(1135, 294);
            btnEliminarProyecto.Name = "btnEliminarProyecto";
            btnEliminarProyecto.Size = new Size(102, 33);
            btnEliminarProyecto.TabIndex = 11;
            btnEliminarProyecto.Text = "Eliminar";
            btnEliminarProyecto.TextAlign = ContentAlignment.TopCenter;
            btnEliminarProyecto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarTarea.ForeColor = Color.Red;
            btnEliminarTarea.Location = new Point(1144, 659);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(102, 33);
            btnEliminarTarea.TabIndex = 14;
            btnEliminarTarea.Text = "Eliminar";
            btnEliminarTarea.TextAlign = ContentAlignment.TopCenter;
            btnEliminarTarea.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 739);
            Controls.Add(btnEliminarTarea);
            Controls.Add(btnEliminarProyecto);
            Controls.Add(btnEditarTarea);
            Controls.Add(btnEditarProyecto);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericIDProyecto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHorasTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericIDTarea).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHorasTarea).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label idProyecto;
        private Label label1;
        private Label label2;
        private TextBox txtProyecto;
        private TextBox txtDescripcion;
        private Label label3;
        private Label label4;
        private Button btnGuardarProyecto;
        private NumericUpDown numHorasTotales;
        private Button btnLimpiarProyecto;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label0;
        private GroupBox groupBox2;
        private Button btnLimpiarTarea;
        private Button btnGuardarTarea;
        private Label label6;
        private Label label8;
        private Label idTarea;
        private Label label10;
        private NumericUpDown numHorasTarea;
        private TextBox txtTarea;
        private Label label7;
        private DataGridView dataGridView2;
        private ComboBox boxProyecto;
        private ComboBox boxArea;
        private Label label11;
        private ComboBox boxUsuarios;
        private Label label9;
        private Button btnEditarProyecto;
        private Button btnEditarTarea;
        private Button btnEliminarProyecto;
        private Button btnEliminarTarea;
        private NumericUpDown numericIDProyecto;
        private NumericUpDown numericIDTarea;
    }
}
