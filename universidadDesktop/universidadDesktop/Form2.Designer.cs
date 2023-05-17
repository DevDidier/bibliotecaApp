namespace universidadDesktop
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.inputAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputCategoria = new System.Windows.Forms.ComboBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.msmError = new System.Windows.Forms.Label();
            this.msmSuccess = new System.Windows.Forms.Label();
            this.inputPaginas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Nuevo Libro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(103, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Libro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputNombre
            // 
            this.inputNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputNombre.BackColor = System.Drawing.SystemColors.Window;
            this.inputNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNombre.Location = new System.Drawing.Point(92, 127);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(222, 26);
            this.inputNombre.TabIndex = 2;
            // 
            // inputAutor
            // 
            this.inputAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputAutor.BackColor = System.Drawing.SystemColors.Window;
            this.inputAutor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAutor.Location = new System.Drawing.Point(496, 127);
            this.inputAutor.Name = "inputAutor";
            this.inputAutor.Size = new System.Drawing.Size(222, 26);
            this.inputAutor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(576, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(100, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero de Paginas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(543, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Categoria";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputCategoria
            // 
            this.inputCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputCategoria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCategoria.FormattingEnabled = true;
            this.inputCategoria.Location = new System.Drawing.Point(482, 248);
            this.inputCategoria.Name = "inputCategoria";
            this.inputCategoria.Size = new System.Drawing.Size(256, 27);
            this.inputCategoria.TabIndex = 8;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIngresar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIngresar.Location = new System.Drawing.Point(325, 324);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(159, 43);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // msmError
            // 
            this.msmError.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.msmError.AutoSize = true;
            this.msmError.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msmError.ForeColor = System.Drawing.Color.Red;
            this.msmError.Location = new System.Drawing.Point(233, 390);
            this.msmError.Name = "msmError";
            this.msmError.Size = new System.Drawing.Size(334, 24);
            this.msmError.TabIndex = 10;
            this.msmError.Text = "Ingrese el nOMBRE DEL LIBRO";
            this.msmError.Visible = false;
            this.msmError.Click += new System.EventHandler(this.label6_Click);
            // 
            // msmSuccess
            // 
            this.msmSuccess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.msmSuccess.AutoSize = true;
            this.msmSuccess.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msmSuccess.ForeColor = System.Drawing.Color.ForestGreen;
            this.msmSuccess.Location = new System.Drawing.Point(255, 390);
            this.msmSuccess.Name = "msmSuccess";
            this.msmSuccess.Size = new System.Drawing.Size(298, 24);
            this.msmSuccess.TabIndex = 11;
            this.msmSuccess.Text = "Se Ingreso Correctamente";
            this.msmSuccess.Visible = false;
            // 
            // inputPaginas
            // 
            this.inputPaginas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputPaginas.BackColor = System.Drawing.SystemColors.Window;
            this.inputPaginas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPaginas.Location = new System.Drawing.Point(150, 248);
            this.inputPaginas.Name = "inputPaginas";
            this.inputPaginas.Size = new System.Drawing.Size(114, 26);
            this.inputPaginas.TabIndex = 12;
            this.inputPaginas.TextChanged += new System.EventHandler(this.inputPaginas_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::universidadDesktop.Properties.Resources.fondo_ladrillos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputPaginas);
            this.Controls.Add(this.msmSuccess);
            this.Controls.Add(this.msmError);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.inputCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.TextBox inputAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox inputCategoria;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label msmError;
        private System.Windows.Forms.Label msmSuccess;
        private System.Windows.Forms.TextBox inputPaginas;
    }
}