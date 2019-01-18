namespace Restaurante
{
    partial class FormPrinc
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrinc));
            this.labelDesayuno = new System.Windows.Forms.Label();
            this.labelCarne = new System.Windows.Forms.Label();
            this.labelEnsa = new System.Windows.Forms.Label();
            this.labelPostres = new System.Windows.Forms.Label();
            this.labelBebidas = new System.Windows.Forms.Label();
            this.labelTítulo = new System.Windows.Forms.Label();
            this.buttonTerm = new System.Windows.Forms.Button();
            this.labelQyS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPrinc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrinc)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDesayuno
            // 
            this.labelDesayuno.AutoSize = true;
            this.labelDesayuno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDesayuno.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesayuno.Location = new System.Drawing.Point(42, 560);
            this.labelDesayuno.Name = "labelDesayuno";
            this.labelDesayuno.Size = new System.Drawing.Size(127, 33);
            this.labelDesayuno.TabIndex = 0;
            this.labelDesayuno.Text = "Desayunos";
            this.labelDesayuno.Click += new System.EventHandler(this.labelDesayuno_Click);
            // 
            // labelCarne
            // 
            this.labelCarne.AutoSize = true;
            this.labelCarne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCarne.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarne.Location = new System.Drawing.Point(239, 557);
            this.labelCarne.Name = "labelCarne";
            this.labelCarne.Size = new System.Drawing.Size(84, 33);
            this.labelCarne.TabIndex = 1;
            this.labelCarne.Text = "Carnes";
            this.labelCarne.Click += new System.EventHandler(this.labelCarne_Click);
            // 
            // labelEnsa
            // 
            this.labelEnsa.AutoSize = true;
            this.labelEnsa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEnsa.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnsa.Location = new System.Drawing.Point(403, 557);
            this.labelEnsa.Name = "labelEnsa";
            this.labelEnsa.Size = new System.Drawing.Size(122, 33);
            this.labelEnsa.TabIndex = 2;
            this.labelEnsa.Text = "Ensaladas";
            this.labelEnsa.Click += new System.EventHandler(this.labelEnsa_Click);
            // 
            // labelPostres
            // 
            this.labelPostres.AutoSize = true;
            this.labelPostres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPostres.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostres.Location = new System.Drawing.Point(583, 557);
            this.labelPostres.Name = "labelPostres";
            this.labelPostres.Size = new System.Drawing.Size(92, 33);
            this.labelPostres.TabIndex = 3;
            this.labelPostres.Text = "Postres";
            this.labelPostres.Click += new System.EventHandler(this.labelPostres_Click);
            // 
            // labelBebidas
            // 
            this.labelBebidas.AutoSize = true;
            this.labelBebidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBebidas.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBebidas.Location = new System.Drawing.Point(739, 557);
            this.labelBebidas.Name = "labelBebidas";
            this.labelBebidas.Size = new System.Drawing.Size(97, 33);
            this.labelBebidas.TabIndex = 4;
            this.labelBebidas.Text = "Bebidas";
            this.labelBebidas.Click += new System.EventHandler(this.labelBebidas_Click);
            // 
            // labelTítulo
            // 
            this.labelTítulo.AutoEllipsis = true;
            this.labelTítulo.AutoSize = true;
            this.labelTítulo.Font = new System.Drawing.Font("Mistral", 30.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTítulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTítulo.Location = new System.Drawing.Point(370, 30);
            this.labelTítulo.Name = "labelTítulo";
            this.labelTítulo.Size = new System.Drawing.Size(199, 49);
            this.labelTítulo.TabIndex = 5;
            this.labelTítulo.Text = "FI´s Family";
            // 
            // buttonTerm
            // 
            this.buttonTerm.BackColor = System.Drawing.Color.Red;
            this.buttonTerm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTerm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonTerm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTerm.Location = new System.Drawing.Point(15, 55);
            this.buttonTerm.Name = "buttonTerm";
            this.buttonTerm.Size = new System.Drawing.Size(154, 42);
            this.buttonTerm.TabIndex = 8;
            this.buttonTerm.Text = "Terminar Orden";
            this.buttonTerm.UseVisualStyleBackColor = false;
            this.buttonTerm.Click += new System.EventHandler(this.buttonTerm_Click);
            // 
            // labelQyS
            // 
            this.labelQyS.AutoSize = true;
            this.labelQyS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelQyS.Font = new System.Drawing.Font("Microsoft Himalaya", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQyS.Location = new System.Drawing.Point(727, 9);
            this.labelQyS.Name = "labelQyS";
            this.labelQyS.Size = new System.Drawing.Size(185, 27);
            this.labelQyS.TabIndex = 9;
            this.labelQyS.Text = "Quejas y sugerencias";
            this.labelQyS.Click += new System.EventHandler(this.labelQyS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ver Mi Orden ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxPrinc
            // 
            this.pictureBoxPrinc.Image = global::Restaurante.Properties.Resources.received_703468073173629;
            this.pictureBoxPrinc.Location = new System.Drawing.Point(62, 103);
            this.pictureBoxPrinc.Name = "pictureBoxPrinc";
            this.pictureBoxPrinc.Size = new System.Drawing.Size(800, 451);
            this.pictureBoxPrinc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPrinc.TabIndex = 7;
            this.pictureBoxPrinc.TabStop = false;
            // 
            // FormPrinc
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(914, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQyS);
            this.Controls.Add(this.buttonTerm);
            this.Controls.Add(this.pictureBoxPrinc);
            this.Controls.Add(this.labelTítulo);
            this.Controls.Add(this.labelBebidas);
            this.Controls.Add(this.labelPostres);
            this.Controls.Add(this.labelEnsa);
            this.Controls.Add(this.labelCarne);
            this.Controls.Add(this.labelDesayuno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrinc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrinc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDesayuno;
        private System.Windows.Forms.Label labelCarne;
        private System.Windows.Forms.Label labelEnsa;
        private System.Windows.Forms.Label labelPostres;
        private System.Windows.Forms.Label labelBebidas;
        private System.Windows.Forms.Label labelTítulo;
        private System.Windows.Forms.PictureBox pictureBoxPrinc;
        private System.Windows.Forms.Button buttonTerm;
        private System.Windows.Forms.Label labelQyS;
        private System.Windows.Forms.Label label1;
    }
}

