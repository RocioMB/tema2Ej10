namespace Ejercicio_10_Tema_2
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
            this.EurosLabel = new System.Windows.Forms.Label();
            this.PesetasLabel = new System.Windows.Forms.Label();
            this.txtEuros = new System.Windows.Forms.TextBox();
            this.txtPesetas = new System.Windows.Forms.TextBox();
            this.BotonAPesetas = new System.Windows.Forms.Button();
            this.BotonAEuros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EurosLabel
            // 
            this.EurosLabel.AutoSize = true;
            this.EurosLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EurosLabel.Location = new System.Drawing.Point(194, 50);
            this.EurosLabel.Name = "EurosLabel";
            this.EurosLabel.Size = new System.Drawing.Size(57, 21);
            this.EurosLabel.TabIndex = 0;
            this.EurosLabel.Text = "Euros";
            // 
            // PesetasLabel
            // 
            this.PesetasLabel.AutoSize = true;
            this.PesetasLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PesetasLabel.Location = new System.Drawing.Point(194, 154);
            this.PesetasLabel.Name = "PesetasLabel";
            this.PesetasLabel.Size = new System.Drawing.Size(75, 21);
            this.PesetasLabel.TabIndex = 1;
            this.PesetasLabel.Text = "Pesetas";
            // 
            // txtEuros
            // 
            this.txtEuros.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEuros.Location = new System.Drawing.Point(299, 47);
            this.txtEuros.Name = "txtEuros";
            this.txtEuros.Size = new System.Drawing.Size(150, 28);
            this.txtEuros.TabIndex = 2;
            // 
            // txtPesetas
            // 
            this.txtPesetas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesetas.Location = new System.Drawing.Point(299, 148);
            this.txtPesetas.Name = "txtPesetas";
            this.txtPesetas.Size = new System.Drawing.Size(150, 28);
            this.txtPesetas.TabIndex = 3;
            // 
            // BotonAPesetas
            // 
            this.BotonAPesetas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotonAPesetas.Location = new System.Drawing.Point(299, 237);
            this.BotonAPesetas.Name = "BotonAPesetas";
            this.BotonAPesetas.Size = new System.Drawing.Size(159, 50);
            this.BotonAPesetas.TabIndex = 4;
            this.BotonAPesetas.Text = "Pasar a Pesetas";
            this.BotonAPesetas.UseVisualStyleBackColor = true;
            this.BotonAPesetas.Click += new System.EventHandler(this.BotonAPesetas_Click);
            // 
            // BotonAEuros
            // 
            this.BotonAEuros.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotonAEuros.Location = new System.Drawing.Point(299, 330);
            this.BotonAEuros.Name = "BotonAEuros";
            this.BotonAEuros.Size = new System.Drawing.Size(159, 50);
            this.BotonAEuros.TabIndex = 5;
            this.BotonAEuros.Text = "Pasar a Euros";
            this.BotonAEuros.UseVisualStyleBackColor = true;
            this.BotonAEuros.Click += new System.EventHandler(this.BotonAEuros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonAEuros);
            this.Controls.Add(this.BotonAPesetas);
            this.Controls.Add(this.txtPesetas);
            this.Controls.Add(this.txtEuros);
            this.Controls.Add(this.PesetasLabel);
            this.Controls.Add(this.EurosLabel);
            this.Name = "Form1";
            this.Text = "Ejercicio 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label EurosLabel;
        private Label PesetasLabel;
        private TextBox txtEuros;
        private TextBox txtPesetas;
        private Button BotonAPesetas;
        private Button BotonAEuros;
    }
}