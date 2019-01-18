namespace Restaurante
{
    partial class Desayunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desayunos));
            this.CBDes = new System.Windows.Forms.ComboBox();
            this.UpDownDesa = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonDesc = new System.Windows.Forms.Button();
            this.pictureBoxDes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDes)).BeginInit();
            this.SuspendLayout();
            // 
            // CBDes
            // 
            this.CBDes.FormattingEnabled = true;
            this.CBDes.Items.AddRange(new object[] {
            "Botes de Bannana",
            "Burritos",
            "Pan de Calabaza",
            "Panqué de Elote",
            "Chilaquiles"});
            this.CBDes.Location = new System.Drawing.Point(186, 43);
            this.CBDes.Name = "CBDes";
            this.CBDes.Size = new System.Drawing.Size(121, 21);
            this.CBDes.TabIndex = 1;
            // 
            // UpDownDesa
            // 
            this.UpDownDesa.Location = new System.Drawing.Point(186, 126);
            this.UpDownDesa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownDesa.Name = "UpDownDesa";
            this.UpDownDesa.Size = new System.Drawing.Size(57, 20);
            this.UpDownDesa.TabIndex = 2;
            this.UpDownDesa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desayunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAgregar.Location = new System.Drawing.Point(272, 201);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 5;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonDesc
            // 
            this.buttonDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDesc.Location = new System.Drawing.Point(86, 201);
            this.buttonDesc.Name = "buttonDesc";
            this.buttonDesc.Size = new System.Drawing.Size(104, 23);
            this.buttonDesc.TabIndex = 6;
            this.buttonDesc.Text = "Ver Descripción";
            this.buttonDesc.UseVisualStyleBackColor = true;
            this.buttonDesc.Click += new System.EventHandler(this.buttonDesc_Click);
            // 
            // pictureBoxDes
            // 
            this.pictureBoxDes.Image = global::Restaurante.Properties.Resources.Desayunos;
            this.pictureBoxDes.Location = new System.Drawing.Point(477, 12);
            this.pictureBoxDes.Name = "pictureBoxDes";
            this.pictureBoxDes.Size = new System.Drawing.Size(290, 237);
            this.pictureBoxDes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDes.TabIndex = 0;
            this.pictureBoxDes.TabStop = false;
            // 
            // Desayunos
            // 
            this.AcceptButton = this.buttonAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(769, 261);
            this.Controls.Add(this.buttonDesc);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpDownDesa);
            this.Controls.Add(this.CBDes);
            this.Controls.Add(this.pictureBoxDes);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Desayunos";
            this.ShowInTaskbar = false;
            this.Text = "Desayunos";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDes;
        private System.Windows.Forms.ComboBox CBDes;
        private System.Windows.Forms.NumericUpDown UpDownDesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonDesc;
    }
}