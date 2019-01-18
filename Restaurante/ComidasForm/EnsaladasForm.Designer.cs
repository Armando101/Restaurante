namespace Restaurante.ComidasForm
{
    partial class EnsaladasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnsaladasForm));
            this.buttonDesc = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEns = new System.Windows.Forms.Label();
            this.UpDownEns = new System.Windows.Forms.NumericUpDown();
            this.CBEns = new System.Windows.Forms.ComboBox();
            this.pictureBoxEns = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownEns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEns)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDesc
            // 
            this.buttonDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDesc.Location = new System.Drawing.Point(64, 202);
            this.buttonDesc.Name = "buttonDesc";
            this.buttonDesc.Size = new System.Drawing.Size(104, 23);
            this.buttonDesc.TabIndex = 13;
            this.buttonDesc.Text = "Ver Descripción";
            this.buttonDesc.UseVisualStyleBackColor = true;
            this.buttonDesc.Click += new System.EventHandler(this.buttonDesc_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAgregar.Location = new System.Drawing.Point(250, 202);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 12;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad";
            // 
            // labelEns
            // 
            this.labelEns.AutoSize = true;
            this.labelEns.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEns.Location = new System.Drawing.Point(27, 33);
            this.labelEns.Name = "labelEns";
            this.labelEns.Size = new System.Drawing.Size(104, 33);
            this.labelEns.TabIndex = 10;
            this.labelEns.Text = "Ensalada";
            // 
            // UpDownEns
            // 
            this.UpDownEns.Location = new System.Drawing.Point(164, 127);
            this.UpDownEns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownEns.Name = "UpDownEns";
            this.UpDownEns.Size = new System.Drawing.Size(57, 20);
            this.UpDownEns.TabIndex = 9;
            this.UpDownEns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CBEns
            // 
            this.CBEns.FormattingEnabled = true;
            this.CBEns.Items.AddRange(new object[] {
            "Ensalada FI´s Family",
            "Julio César",
            "Argentina",
            "Mixta",
            "Dine",
            "César",
            "De la Granja"});
            this.CBEns.Location = new System.Drawing.Point(164, 44);
            this.CBEns.Name = "CBEns";
            this.CBEns.Size = new System.Drawing.Size(121, 21);
            this.CBEns.TabIndex = 8;
            // 
            // pictureBoxEns
            // 
            this.pictureBoxEns.Image = global::Restaurante.Properties.Resources.Ensalada;
            this.pictureBoxEns.Location = new System.Drawing.Point(451, 33);
            this.pictureBoxEns.Name = "pictureBoxEns";
            this.pictureBoxEns.Size = new System.Drawing.Size(280, 183);
            this.pictureBoxEns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEns.TabIndex = 7;
            this.pictureBoxEns.TabStop = false;
            // 
            // EnsaladasForm
            // 
            this.AcceptButton = this.buttonAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(756, 263);
            this.Controls.Add(this.buttonDesc);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEns);
            this.Controls.Add(this.UpDownEns);
            this.Controls.Add(this.CBEns);
            this.Controls.Add(this.pictureBoxEns);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnsaladasForm";
            this.ShowInTaskbar = false;
            this.Text = "Ensaladas";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownEns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDesc;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEns;
        private System.Windows.Forms.NumericUpDown UpDownEns;
        private System.Windows.Forms.ComboBox CBEns;
        private System.Windows.Forms.PictureBox pictureBoxEns;
    }
}