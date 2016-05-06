namespace WindowsForms.Estados
{
    partial class EstadosIndex
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
            this.grdEstadoIndex = new System.Windows.Forms.DataGridView();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadoIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEstadoIndex
            // 
            this.grdEstadoIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstadoIndex.Location = new System.Drawing.Point(12, 12);
            this.grdEstadoIndex.Name = "grdEstadoIndex";
            this.grdEstadoIndex.Size = new System.Drawing.Size(633, 141);
            this.grdEstadoIndex.TabIndex = 0;
            // 
            // cbEstados
            // 
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Location = new System.Drawing.Point(701, 32);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(121, 21);
            this.cbEstados.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateEstado);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(795, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EstadosIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbEstados);
            this.Controls.Add(this.grdEstadoIndex);
            this.Name = "EstadosIndex";
            this.Text = "EstadosIndex";
            ((System.ComponentModel.ISupportInitialize)(this.grdEstadoIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEstadoIndex;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}