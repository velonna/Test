
namespace CodingChallenge.FormApp
{
    partial class Form1
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
            this.lblSelectLang = new System.Windows.Forms.Label();
            this.cmbSelectLenguages = new System.Windows.Forms.ComboBox();
            this.cmbSelectFigura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblSb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectLang
            // 
            this.lblSelectLang.AutoSize = true;
            this.lblSelectLang.Location = new System.Drawing.Point(188, 95);
            this.lblSelectLang.Name = "lblSelectLang";
            this.lblSelectLang.Size = new System.Drawing.Size(133, 17);
            this.lblSelectLang.TabIndex = 0;
            this.lblSelectLang.Text = "Cambiar de idioma :";
            this.lblSelectLang.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbSelectLenguages
            // 
            this.cmbSelectLenguages.FormattingEnabled = true;
            this.cmbSelectLenguages.Items.AddRange(new object[] {
            "Español",
            "English"});
            this.cmbSelectLenguages.Location = new System.Drawing.Point(344, 95);
            this.cmbSelectLenguages.Name = "cmbSelectLenguages";
            this.cmbSelectLenguages.Size = new System.Drawing.Size(233, 24);
            this.cmbSelectLenguages.TabIndex = 1;
            this.cmbSelectLenguages.Text = "Seleccione Idioma";
            this.cmbSelectLenguages.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbSelectFigura
            // 
            this.cmbSelectFigura.FormattingEnabled = true;
            this.cmbSelectFigura.Location = new System.Drawing.Point(344, 172);
            this.cmbSelectFigura.Name = "cmbSelectFigura";
            this.cmbSelectFigura.Size = new System.Drawing.Size(172, 24);
            this.cmbSelectFigura.TabIndex = 2;
            this.cmbSelectFigura.Text = "Seleccione la Figura";
            this.cmbSelectFigura.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione una Figura : ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(139, 235);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 17);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Resultado";
            // 
            // lblSb
            // 
            this.lblSb.AutoSize = true;
            this.lblSb.Location = new System.Drawing.Point(129, 283);
            this.lblSb.Name = "lblSb";
            this.lblSb.Size = new System.Drawing.Size(13, 17);
            this.lblSb.TabIndex = 5;
            this.lblSb.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSb);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelectFigura);
            this.Controls.Add(this.cmbSelectLenguages);
            this.Controls.Add(this.lblSelectLang);
            this.Name = "Form1";
            this.Text = "Formas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectLang;
        private System.Windows.Forms.ComboBox cmbSelectLenguages;
        private System.Windows.Forms.ComboBox cmbSelectFigura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblSb;
    }
}

