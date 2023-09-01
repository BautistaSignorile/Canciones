
namespace Canciones
{
    partial class Temas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temas));
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.cbTema = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // wmp
            // 
            this.wmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(12, 39);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(730, 426);
            this.wmp.TabIndex = 0;
            this.wmp.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // cbTema
            // 
            this.cbTema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTema.FormattingEnabled = true;
            this.cbTema.Location = new System.Drawing.Point(12, 12);
            this.cbTema.Name = "cbTema";
            this.cbTema.Size = new System.Drawing.Size(730, 21);
            this.cbTema.TabIndex = 1;
            this.cbTema.SelectedIndexChanged += new System.EventHandler(this.cbTema_SelectedIndexChanged);
            // 
            // Temas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 477);
            this.Controls.Add(this.cbTema);
            this.Controls.Add(this.wmp);
            this.Name = "Temas";
            this.Text = "Temas";
            this.Load += new System.EventHandler(this.Temas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.ComboBox cbTema;
    }
}

