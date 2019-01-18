namespace Restaurante.ComidasForm
{
    partial class BebidasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BebidasForm));
            this.buttonDesc = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpDownDesa = new System.Windows.Forms.NumericUpDown();
            this.CBBeb = new System.Windows.Forms.ComboBox();
            this.pictureBoxBeb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeb)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDesc
            // 
            this.buttonDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDesc.Location = new System.Drawing.Point(111, 219);
            this.buttonDesc.Name = "buttonDesc";
            this.buttonDesc.Size = new System.Drawing.Size(104, 23);
            this.buttonDesc.TabIndex = 20;
            this.buttonDesc.Text = "Ver Descripción";
            this.buttonDesc.UseVisualStyleBackColor = true;
            this.buttonDesc.Click += new System.EventHandler(this.buttonDesc_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAgregar.Location = new System.Drawing.Point(297, 219);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 19;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bebidas";
            // 
            // UpDownDesa
            // 
            this.UpDownDesa.Location = new System.Drawing.Point(211, 144);
            this.UpDownDesa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownDesa.Name = "UpDownDesa";
            this.UpDownDesa.Size = new System.Drawing.Size(57, 20);
            this.UpDownDesa.TabIndex = 16;
            this.UpDownDesa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CBBeb
            // 
            this.CBBeb.FormattingEnabled = true;
            this.CBBeb.Items.AddRange(new object[] {
            "Café Flameado Irlandés",
            "Café Flameado Francés",
            "Café Flameado Italiano",
            "Agua de Sabor",
            "Coca-Cola"});
            this.CBBeb.Location = new System.Drawing.Point(211, 61);
            this.CBBeb.Name = "CBBeb";
            this.CBBeb.Size = new System.Drawing.Size(121, 21);
            this.CBBeb.TabIndex = 15;
            // 
            // pictureBoxBeb
            // 
            this.pictureBoxBeb.Image = global::Restaurante.Properties.Resources.Bebidas;
            this.pictureBoxBeb.Location = new System.Drawing.Point(502, 30);
            this.pictureBoxBeb.Name = "pictureBoxBeb";
            this.pictureBoxBeb.Size = new System.Drawing.Size(290, 237);
            this.pictureBoxBeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBeb.TabIndex = 14;
            this.pictureBoxBeb.TabStop = false;
            // 
            // BebidasForm
            // 
            this.AcceptButton = this.buttonAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(867, 296);
            this.Controls.Add(this.buttonDesc);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpDownDesa);
            this.Controls.Add(this.CBBeb);
            this.Controls.Add(this.pictureBoxBeb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BebidasForm";
            this.ShowInTaskbar = false;
            this.Text = "Bebidas";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDesc;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UpDownDesa;
        private System.Windows.Forms.ComboBox CBBeb;
        private System.Windows.Forms.PictureBox pictureBoxBeb;
    }
}