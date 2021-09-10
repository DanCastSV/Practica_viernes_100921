
namespace Practica_7_viernes
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
            this.btngetnames = new System.Windows.Forms.Button();
            this.btngetdatta = new System.Windows.Forms.Button();
            this.lstProductsName = new System.Windows.Forms.ListBox();
            this.dgAllProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btngetnames
            // 
            this.btngetnames.Location = new System.Drawing.Point(41, 47);
            this.btngetnames.Name = "btngetnames";
            this.btngetnames.Size = new System.Drawing.Size(101, 23);
            this.btngetnames.TabIndex = 0;
            this.btngetnames.Text = "getProductsNames()";
            this.btngetnames.UseVisualStyleBackColor = true;
            this.btngetnames.Click += new System.EventHandler(this.btngetnames_Click);
            // 
            // btngetdatta
            // 
            this.btngetdatta.Location = new System.Drawing.Point(41, 244);
            this.btngetdatta.Name = "btngetdatta";
            this.btngetdatta.Size = new System.Drawing.Size(89, 29);
            this.btngetdatta.TabIndex = 1;
            this.btngetdatta.Text = "getdatta()";
            this.btngetdatta.UseVisualStyleBackColor = true;
            this.btngetdatta.Click += new System.EventHandler(this.btngetdatta_Click);
            // 
            // lstProductsName
            // 
            this.lstProductsName.FormattingEnabled = true;
            this.lstProductsName.ItemHeight = 16;
            this.lstProductsName.Location = new System.Drawing.Point(181, 23);
            this.lstProductsName.Name = "lstProductsName";
            this.lstProductsName.Size = new System.Drawing.Size(210, 196);
            this.lstProductsName.TabIndex = 2;
            // 
            // dgAllProducts
            // 
            this.dgAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllProducts.Location = new System.Drawing.Point(181, 295);
            this.dgAllProducts.Name = "dgAllProducts";
            this.dgAllProducts.RowHeadersWidth = 51;
            this.dgAllProducts.RowTemplate.Height = 24;
            this.dgAllProducts.Size = new System.Drawing.Size(742, 227);
            this.dgAllProducts.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 566);
            this.Controls.Add(this.dgAllProducts);
            this.Controls.Add(this.lstProductsName);
            this.Controls.Add(this.btngetdatta);
            this.Controls.Add(this.btngetnames);
            this.Name = "Form1";
            this.Text = "Clase Practica sobre LINQ";
            ((System.ComponentModel.ISupportInitialize)(this.dgAllProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngetnames;
        private System.Windows.Forms.Button btngetdatta;
        private System.Windows.Forms.ListBox lstProductsName;
        private System.Windows.Forms.DataGridView dgAllProducts;
    }
}

