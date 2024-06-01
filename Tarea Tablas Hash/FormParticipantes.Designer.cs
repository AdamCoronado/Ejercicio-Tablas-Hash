namespace Tarea_Tablas_Hash
{
    partial class FormParticipantes
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
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtbxFechaNac = new TextBox();
            rbtnMasculino = new RadioButton();
            rbtnFemenino = new RadioButton();
            listCategoria = new ListBox();
            txtbxEdad = new TextBox();
            txtbxApellido = new TextBox();
            txtbxNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtbBNombre = new TextBox();
            label9 = new Label();
            txtbxBuscar = new TextBox();
            label7 = new Label();
            btnBuscar = new Button();
            btnNuevoRegistro = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnRestablecer = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtbxFechaNac);
            groupBox1.Controls.Add(rbtnMasculino);
            groupBox1.Controls.Add(rbtnFemenino);
            groupBox1.Controls.Add(listCategoria);
            groupBox1.Controls.Add(txtbxEdad);
            groupBox1.Controls.Add(txtbxApellido);
            groupBox1.Controls.Add(txtbxNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion del Participante";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(340, 13);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 5;
            label8.Text = "dd/mm/aa";
            // 
            // txtbxFechaNac
            // 
            txtbxFechaNac.Location = new Point(325, 31);
            txtbxFechaNac.Name = "txtbxFechaNac";
            txtbxFechaNac.Size = new Size(100, 23);
            txtbxFechaNac.TabIndex = 4;
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Location = new Point(340, 99);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(36, 19);
            rbtnMasculino.TabIndex = 6;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "M";
            rbtnMasculino.UseVisualStyleBackColor = true;
            rbtnMasculino.CheckedChanged += rbtnMasculino_CheckedChanged;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Location = new Point(382, 99);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(31, 19);
            rbtnFemenino.TabIndex = 7;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "F";
            rbtnFemenino.UseVisualStyleBackColor = true;
            rbtnFemenino.CheckedChanged += rbtnFemenino_CheckedChanged;
            // 
            // listCategoria
            // 
            listCategoria.FormattingEnabled = true;
            listCategoria.ItemHeight = 15;
            listCategoria.Items.AddRange(new object[] { "", "Junior", "Promesa", "Senior", "Veterano" });
            listCategoria.Location = new Point(325, 63);
            listCategoria.Name = "listCategoria";
            listCategoria.Size = new Size(100, 19);
            listCategoria.TabIndex = 5;
            // 
            // txtbxEdad
            // 
            txtbxEdad.Location = new Point(77, 93);
            txtbxEdad.Name = "txtbxEdad";
            txtbxEdad.Size = new Size(100, 23);
            txtbxEdad.TabIndex = 3;
            // 
            // txtbxApellido
            // 
            txtbxApellido.Location = new Point(77, 64);
            txtbxApellido.Name = "txtbxApellido";
            txtbxApellido.Size = new Size(100, 23);
            txtbxApellido.TabIndex = 2;
            // 
            // txtbxNombre
            // 
            txtbxNombre.Location = new Point(77, 36);
            txtbxNombre.Name = "txtbxNombre";
            txtbxNombre.Size = new Size(100, 23);
            txtbxNombre.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 67);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Categoria :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(194, 39);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Nacimiento :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 101);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Sexo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 101);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 72);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 44);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtbBNombre);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtbxBuscar);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(480, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(212, 144);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda por Apellido";
            // 
            // txtbBNombre
            // 
            txtbBNombre.Location = new Point(79, 31);
            txtbBNombre.Name = "txtbBNombre";
            txtbBNombre.Size = new Size(100, 23);
            txtbBNombre.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 39);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 17;
            label9.Text = "Nombre :";
            // 
            // txtbxBuscar
            // 
            txtbxBuscar.Location = new Point(79, 78);
            txtbxBuscar.Name = "txtbxBuscar";
            txtbxBuscar.Size = new Size(100, 23);
            txtbxBuscar.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 81);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 16;
            label7.Text = "Apellido :";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(540, 162);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 43);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "BUSCAR PARTICIPANTE";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnNuevoRegistro
            // 
            btnNuevoRegistro.Location = new Point(42, 162);
            btnNuevoRegistro.Name = "btnNuevoRegistro";
            btnNuevoRegistro.Size = new Size(79, 43);
            btnNuevoRegistro.TabIndex = 7;
            btnNuevoRegistro.Text = "NUEVO REGISTRO";
            btnNuevoRegistro.UseVisualStyleBackColor = true;
            btnNuevoRegistro.Click += btnNuevoRegistro_Click;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new Point(147, 162);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(79, 43);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "MODIFICAR REGISTRO";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(252, 162);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(79, 43);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR REGISTRO";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRestablecer
            // 
            btnRestablecer.Location = new Point(352, 162);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(98, 43);
            btnRestablecer.TabIndex = 18;
            btnRestablecer.Text = "RESTABLECER INFORMACION";
            btnRestablecer.UseVisualStyleBackColor = true;
            btnRestablecer.Click += btnRestablecer_Click;
            // 
            // FormParticipantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 212);
            Controls.Add(btnRestablecer);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevoRegistro);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormParticipantes";
            Text = "FormParticipantes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtbxApellido;
        private TextBox txtbxNombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtbxEdad;
        private ListBox listCategoria;
        private RadioButton rbtnMasculino;
        private RadioButton rbtnFemenino;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private TextBox txtbxBuscar;
        private Label label7;
        private Button btnNuevoRegistro;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label8;
        private TextBox txtbxFechaNac;
        private TextBox txtbBNombre;
        private Label label9;
        private Button btnRestablecer;
    }
}