namespace Restaurante.ComidasForm
{
    partial class Postres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postres));
            this.buttonDesc = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpDownDesa = new System.Windows.Forms.NumericUpDown();
            this.CBPost = new System.Windows.Forms.ComboBox();
            this.pictureBoxpost = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpost)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDesc
            // 
            this.buttonDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDesc.Location = new System.Drawing.Point(80, 221);
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
            this.buttonAgregar.Location = new System.Drawing.Point(266, 221);
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
            this.label2.Location = new System.Drawing.Point(43, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Postres";
            // 
            // UpDownDesa
            // 
            this.UpDownDesa.Location = new System.Drawing.Point(180, 146);
            this.UpDownDesa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownDesa.Name = "UpDownDesa";
            this.UpDownDesa.Size = new System.Drawing.Size(57, 20);
            this.UpDownDesa.TabIndex = 9;
            this.UpDownDesa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CBPost
            // 
            this.CBPost.FormattingEnabled = true;
            this.CBPost.Items.AddRange(new object[] {
            "Volcán de Chocolate",
            "Alfafor",
            "Strudel de Manzana",
            "Flan Napolitano",
            "Helados",
            "Platanos Flambee"});
            this.CBPost.Location = new System.Drawing.Point(180, 63);
            this.CBPost.Name = "CBPost";
            this.CBPost.Size = new System.Drawing.Size(121, 21);
            this.CBPost.TabIndex = 8;
            // 
            // pictureBoxpost
            // 
            this.pictureBoxpost.Image = global::Restaurante.Properties.Resources.Postres;
            this.pictureBoxpost.Location = new System.Drawing.Point(471, 32);
            this.pictureBoxpost.Name = "pictureBoxpost";
            this.pictureBoxpost.Size = new System.Drawing.Size(290, 237);
            this.pictureBoxpost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxpost.TabIndex = 7;
            this.pictureBoxpost.TabStop = false;
            // 
            // Postres
            // 
            this.AcceptButton = this.buttonAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(789, 300);
            this.Controls.Add(this.buttonDesc);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpDownDesa);
            this.Controls.Add(this.CBPost);
            this.Controls.Add(this.pictureBoxpost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Postres";
            this.ShowInTaskbar = false;
            this.Text = "Postres";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDesc;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UpDownDesa;
        private System.Windows.Forms.ComboBox CBPost;
        private System.Windows.Forms.PictureBox pictureBoxpost;
    }
}