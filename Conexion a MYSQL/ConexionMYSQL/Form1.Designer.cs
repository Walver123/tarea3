﻿
namespace ConexionMYSQL
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSERVIDOR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPUERTO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.btnCONECTAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MYSQL";
            // 
            // txtSERVIDOR
            // 
            this.txtSERVIDOR.Location = new System.Drawing.Point(136, 72);
            this.txtSERVIDOR.Name = "txtSERVIDOR";
            this.txtSERVIDOR.Size = new System.Drawing.Size(139, 20);
            this.txtSERVIDOR.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENTRADA";
            // 
            // txtPUERTO
            // 
            this.txtPUERTO.Location = new System.Drawing.Point(136, 122);
            this.txtPUERTO.Name = "txtPUERTO";
            this.txtPUERTO.Size = new System.Drawing.Size(139, 20);
            this.txtPUERTO.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "USUARIO";
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(136, 162);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(139, 20);
            this.txtUSUARIO.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CONTRASEÑA";
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Location = new System.Drawing.Point(136, 208);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.PasswordChar = '*';
            this.txtPASSWORD.Size = new System.Drawing.Size(139, 20);
            this.txtPASSWORD.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "BASE DE DATOS";
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(136, 254);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(139, 20);
            this.txtBD.TabIndex = 9;
            // 
            // btnCONECTAR
            // 
            this.btnCONECTAR.Location = new System.Drawing.Point(285, 319);
            this.btnCONECTAR.Name = "btnCONECTAR";
            this.btnCONECTAR.Size = new System.Drawing.Size(145, 49);
            this.btnCONECTAR.TabIndex = 10;
            this.btnCONECTAR.Text = "CONECTAR";
            this.btnCONECTAR.UseVisualStyleBackColor = true;
            this.btnCONECTAR.Click += new System.EventHandler(this.btnCONECTAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCONECTAR);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUSUARIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPUERTO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSERVIDOR);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ConexionMSQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSERVIDOR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPUERTO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.Button btnCONECTAR;
    }
}

