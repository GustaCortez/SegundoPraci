namespace CALCULADORR
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnSigno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(12, 12);
            this.txtResultado.MaxLength = 20;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(259, 48);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            this.btnUno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUno.Location = new System.Drawing.Point(12, 267);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(45, 45);
            this.btnUno.TabIndex = 1;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnDos
            // 
            this.btnDos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDos.Location = new System.Drawing.Point(63, 267);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(45, 45);
            this.btnDos.TabIndex = 2;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTres.Location = new System.Drawing.Point(114, 267);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(45, 45);
            this.btnTres.TabIndex = 3;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeis.Location = new System.Drawing.Point(114, 216);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(45, 45);
            this.btnSeis.TabIndex = 6;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCinco.Location = new System.Drawing.Point(63, 216);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(45, 45);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCuatro.Location = new System.Drawing.Point(12, 216);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(45, 45);
            this.btnCuatro.TabIndex = 4;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitar.Location = new System.Drawing.Point(114, 114);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(45, 45);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "<-";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrarTodo.Location = new System.Drawing.Point(63, 114);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(45, 45);
            this.btnBorrarTodo.TabIndex = 11;
            this.btnBorrarTodo.Text = "C";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(12, 114);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(45, 45);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNueve.Location = new System.Drawing.Point(114, 165);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(45, 45);
            this.btnNueve.TabIndex = 9;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnOcho
            // 
            this.btnOcho.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOcho.Location = new System.Drawing.Point(63, 165);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(45, 45);
            this.btnOcho.TabIndex = 8;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnSiete
            // 
            this.btnSiete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiete.Location = new System.Drawing.Point(12, 165);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(45, 45);
            this.btnSiete.TabIndex = 7;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCuadrado.Location = new System.Drawing.Point(226, 114);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(45, 45);
            this.btnCuadrado.TabIndex = 14;
            this.btnCuadrado.Tag = "²";
            this.btnCuadrado.Text = "X²";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRaizCuadrada.Location = new System.Drawing.Point(175, 114);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(45, 45);
            this.btnRaizCuadrada.TabIndex = 13;
            this.btnRaizCuadrada.Tag = "√";
            this.btnRaizCuadrada.Text = "√";
            this.btnRaizCuadrada.UseVisualStyleBackColor = true;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicar.Location = new System.Drawing.Point(226, 165);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(45, 45);
            this.btnMultiplicar.TabIndex = 16;
            this.btnMultiplicar.Tag = "*";
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDividir.Location = new System.Drawing.Point(175, 165);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(45, 45);
            this.btnDividir.TabIndex = 15;
            this.btnDividir.Tag = "/";
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnRestar
            // 
            this.btnRestar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestar.Location = new System.Drawing.Point(226, 216);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(45, 45);
            this.btnRestar.TabIndex = 18;
            this.btnRestar.Tag = "-";
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSumar.Location = new System.Drawing.Point(175, 216);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(45, 45);
            this.btnSumar.TabIndex = 17;
            this.btnSumar.Tag = "+";
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResultado.Location = new System.Drawing.Point(175, 267);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(96, 45);
            this.btnResultado.TabIndex = 19;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPunto.Location = new System.Drawing.Point(114, 330);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(45, 45);
            this.btnPunto.TabIndex = 22;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnCero
            // 
            this.btnCero.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCero.Location = new System.Drawing.Point(63, 330);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(45, 45);
            this.btnCero.TabIndex = 21;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            // 
            // btnSigno
            // 
            this.btnSigno.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSigno.Location = new System.Drawing.Point(12, 330);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Size = new System.Drawing.Size(45, 45);
            this.btnSigno.TabIndex = 20;
            this.btnSigno.Text = "+/-";
            this.btnSigno.UseVisualStyleBackColor = true;
            this.btnSigno.Click += new System.EventHandler(this.button22_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 413);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnSigno);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnRaizCuadrada);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.Text = "CALCULADORAA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResultado;
        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnCuatro;
        private Button btnQuitar;
        private Button btnBorrarTodo;
        private Button btnBorrar;
        private Button btnNueve;
        private Button btnOcho;
        private Button btnSiete;
        private Button btnCuadrado;
        private Button btnRaizCuadrada;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnRestar;
        private Button btnSumar;
        private Button btnResultado;
        private Button btnPunto;
        private Button btnCero;
        private Button btnSigno;
    }
}